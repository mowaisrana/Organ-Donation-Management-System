CREATE DATABASE OrganBloodDonation;
USE OrganBloodDonation;

drop database OrganBloodDonation;

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Phone VARCHAR(15),
    DateOfBirth DATE NOT NULL,
    AddressLine1 VARCHAR(255),
    City VARCHAR(100),
    State VARCHAR(100),
    Country VARCHAR(100),
    Role VARCHAR(10) CHECK (Role IN ('user', 'admin')) NOT NULL DEFAULT 'user',
    CreatedAt DATETIME DEFAULT GETDATE()
);

INSERT INTO Users (Username, Password, FirstName, LastName, Email, Phone, DateOfBirth,AddressLine1,City,State,Country , Role)
VALUES ('admin', 'admin123', 'Muhammad', 'Owais', 'contact@owais.com', '12345678923', '2003-08-18', 'House 1,Street 1','Karachi','Sindh','Pakistan', 'admin');


CREATE TABLE Organs (
    OrganID INT PRIMARY KEY IDENTITY(1,1),
    DonorName VARCHAR(50) NOT NULL,
    OrganName VARCHAR(50) NOT NULL,
    BloodGroup VARCHAR(3) NOT NULL,
    DonorAge INT NOT NULL,
    DonorHospital VARCHAR(100) NOT NULL,
    HospitalPhone VARCHAR(15) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Blood (
    BloodID INT PRIMARY KEY IDENTITY(1,1),
    DonorName VARCHAR(50) NOT NULL,
    BloodGroup VARCHAR(3) NOT NULL,
    DonorAge INT NOT NULL,
    DonorHospital VARCHAR(100) NOT NULL,
    HospitalPhone VARCHAR(15) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Hospitals (
    HospitalID INT PRIMARY KEY IDENTITY(1,1),
    HospitalName VARCHAR(100) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    AddressLine1 VARCHAR(255),
    City VARCHAR(100),
    State VARCHAR(100),
    Country VARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Requests (
    RequestID INT PRIMARY KEY IDENTITY(1,1),
	UserID INT FOREIGN KEY REFERENCES Users(UserID),
    RequestType VARCHAR(10) CHECK (RequestType IN ('Organ', 'Blood')) DEFAULT 'Organ',
    OrganName VARCHAR(50),
    BloodGroup VARCHAR(3),
    Status VARCHAR(20) CHECK (Status IN ('pending', 'approved', 'in progress', 'cancelled')) DEFAULT 'pending',
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Logss (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(255) NOT NULL,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedAt DATETIME DEFAULT GETDATE()
);


--Stored Procedures

CREATE PROCEDURE RegisterUser
    @Username VARCHAR(50),
    @Password VARCHAR(100),
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Phone VARCHAR(15),
    @DateOfBirth DATE,
    @AddressLine1 VARCHAR(255),
    @City VARCHAR(100),
    @State VARCHAR(100),
    @Country VARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username OR Email = @Email)
    BEGIN
        THROW 50001, 'User already exists.', 1;
    END
    INSERT INTO Users (Username, Password, FirstName, LastName, Email, Phone, DateOfBirth, AddressLine1,City,State,Country , Role)
    VALUES (@Username, @Password, @FirstName, @LastName, @Email, @Phone, @DateOfBirth,@AddressLine1,@City,@State,@Country , 'user');
END

CREATE PROCEDURE GetAllUsers
AS
BEGIN
    SELECT * FROM Users;
END

CREATE PROCEDURE UpdateUser
    @UserID INT,
    @UserName VARCHAR(100),
    @Password VARCHAR(100),
    @Role VARCHAR(50)
AS
BEGIN
    UPDATE Users
    SET UserName = @UserName,
        Password = @Password,
        Role = @Role
    WHERE UserID = @UserID;
END

CREATE PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM Users WHERE UserID = @UserID;
END




CREATE PROCEDURE AddOrgan
    @DonorName VARCHAR(50),
    @OrganName VARCHAR(50),
	@BloodGroup VARCHAR(50),
    @DonorAge INT,
	@DonorHospital VARCHAR(100),
    @HospitalPhone VARCHAR(15)
AS
BEGIN
    INSERT INTO Organs(DonorName, OrganName,BloodGroup,DonorAge,DonorHospital ,HospitalPhone )
    VALUES (@DonorName, @OrganName,@BloodGroup,@DonorAge,@DonorHospital ,@HospitalPhone  );
END;

CREATE PROCEDURE UpdateOrgan
    @OrganID INT,  
    @DonorName NVARCHAR(100),
    @OrganName NVARCHAR(100),
    @BloodGroup NVARCHAR(10),
    @DonorAge INT,
    @DonorHospital NVARCHAR(100),
    @HospitalPhone NVARCHAR(20)
AS
BEGIN
    UPDATE Organs
    SET 
        DonorName = @DonorName,
        OrganName = @OrganName,
        BloodGroup = @BloodGroup,
        DonorAge = @DonorAge,
        DonorHospital = @DonorHospital,
        HospitalPhone = @HospitalPhone
    WHERE OrganID = @OrganID; 
END


CREATE PROCEDURE DeleteOrgan
    @OrganID INT 
AS
BEGIN
    DELETE FROM Organs
    WHERE OrganID = @OrganID; 
END

-- Add Blood Stored Prosedures

CREATE PROCEDURE AddBlood
    @DonorName VARCHAR(50),
	@BloodGroup VARCHAR(50),
    @DonorAge INT,
	@DonorHospital VARCHAR(100),
    @HospitalPhone VARCHAR(15)
AS
BEGIN
    INSERT INTO Blood(DonorName,BloodGroup,DonorAge,DonorHospital ,HospitalPhone )
    VALUES (@DonorName,@BloodGroup,@DonorAge,@DonorHospital ,@HospitalPhone  );
END

CREATE PROCEDURE UpdateBlood
    @BloodID INT,
    @DonorName VARCHAR(100),
    @BloodGroup VARCHAR(10),
    @DonorAge INT,
    @DonorHospital VARCHAR(100),
    @HospitalPhone VARCHAR(15)
AS
BEGIN
    UPDATE Blood
    SET DonorName = @DonorName,
        BloodGroup = @BloodGroup,
        DonorAge = @DonorAge,
        DonorHospital = @DonorHospital,
        HospitalPhone = @HospitalPhone
    WHERE BloodID = @BloodID
END

CREATE PROCEDURE DeleteBlood
    @BloodID INT
AS
BEGIN
    DELETE FROM Blood
    WHERE BloodID = @BloodID
END


-- Add hospitals Stored Prosedures


CREATE PROCEDURE AddHospital
    @HospitalName VARCHAR(100),
    @Phone VARCHAR(15),
    @Email VARCHAR(100),
	@AddressLine1 VARCHAR(255),
    @City VARCHAR(100),
    @State VARCHAR(100),
    @Country VARCHAR(100)
    
AS
BEGIN
    INSERT INTO Hospitals (HospitalName, Phone, Email,AddressLine1,City,State,Country )
    VALUES (@HospitalName, @Phone, @Email, @AddressLine1,@City,@State,@Country );
END;


CREATE PROCEDURE UpdateHospital
    @HospitalID INT,
    @HospitalName VARCHAR(100),
    @HospitalPhone VARCHAR(15),
    @HospitalEmail VARCHAR(100),
    @HospitalAL1 VARCHAR(200),
    @HospitalCity VARCHAR(100),
    @HospitalState VARCHAR(100),
    @HospitalCountry VARCHAR(100)
AS
BEGIN
    UPDATE Hospitals 
	SET 
		HospitalName = @HospitalName, 
		Phone = @HospitalPhone,
        Email = @HospitalEmail,
        AddressLine1 = @HospitalAL1,
        City = @HospitalCity,
        State = @HospitalState,
        Country = @HospitalCountry
    WHERE HospitalID = @HospitalID;
END;



CREATE PROCEDURE DeleteHospital
    @HospitalID INT
AS
BEGIN
    DELETE FROM Hospitals WHERE HospitalID = @HospitalID;
END;


CREATE PROCEDURE UpdateRequest
    @RequestID INT,
    @RequestType VARCHAR(50),
    @OrganName VARCHAR(50),
    @BloodGroup VARCHAR(10),
    @Status VARCHAR(20)
AS
BEGIN
    UPDATE Requests
    SET RequestType = @RequestType,
        OrganName = @OrganName,
        BloodGroup = @BloodGroup,
        Status = @Status
    WHERE RequestID = @RequestID;
END


CREATE PROCEDURE DeleteRequest
    @RequestID INT
AS
BEGIN
    DELETE FROM Requests WHERE RequestID = @RequestID;
END


create procedure GetAllRequests
as
begin
select * from Requests;
end





-- Triggers

CREATE TRIGGER trg_Log_Organs
ON Organs
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Action NVARCHAR(20), @UserID INT = NULL, @KeyValue INT;

    -- Determine the action
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
        SET @Action = 'INSERT';
    ELSE IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'UPDATE';
    ELSE IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'DELETE';

    -- Get primary key value (OrganID)
    IF @Action = 'DELETE'
        SELECT TOP 1 @KeyValue = OrganID FROM deleted;
    ELSE
        SELECT TOP 1 @KeyValue = OrganID FROM inserted;

    -- Log the action
    INSERT INTO Logss (Action, UserID, CreatedAt)
    VALUES (@Action + ' ON Organs (OrganID=' + CAST(@KeyValue AS NVARCHAR) + ')', @UserID, GETDATE());
END;


CREATE TRIGGER trg_Log_Blood
ON Blood
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Action NVARCHAR(20), @UserID INT = NULL, @KeyValue INT;

    -- Determine the action
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
        SET @Action = 'INSERT';
    ELSE IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'UPDATE';
    ELSE IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'DELETE';

    -- Get primary key value (BloodID)
    IF @Action = 'DELETE'
        SELECT TOP 1 @KeyValue = BloodID FROM deleted;
    ELSE
        SELECT TOP 1 @KeyValue = BloodID FROM inserted;

    -- Log the action
    INSERT INTO Logss (Action, UserID, CreatedAt)
    VALUES (@Action + ' ON Blood (BloodID=' + CAST(@KeyValue AS NVARCHAR) + ')', @UserID, GETDATE());
END;


CREATE TRIGGER trg_Log_Hospitals
ON Hospitals
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Action NVARCHAR(20), @UserID INT = NULL, @KeyValue INT;

    -- Determine the action
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
        SET @Action = 'INSERT';
    ELSE IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'UPDATE';
    ELSE IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'DELETE';

    -- Get primary key value (HospitalID)
    IF @Action = 'DELETE'
        SELECT TOP 1 @KeyValue = HospitalID FROM deleted;
    ELSE
        SELECT TOP 1 @KeyValue = HospitalID FROM inserted;

    -- Log the action
    INSERT INTO Logss (Action, UserID, CreatedAt)
    VALUES (@Action + ' ON Hospitals (HospitalID=' + CAST(@KeyValue AS NVARCHAR) + ')', @UserID, GETDATE());
END;


CREATE TRIGGER trg_Log_Requests
ON Requests
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Action NVARCHAR(20), @UserID INT = NULL, @KeyValue INT;

    -- Determine the action
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
        SET @Action = 'INSERT';
    ELSE IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'UPDATE';
    ELSE IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'DELETE';

    -- Get primary key value (RequestID)
    IF @Action = 'DELETE'
        SELECT TOP 1 @KeyValue = RequestID FROM deleted;
    ELSE
        SELECT TOP 1 @KeyValue = RequestID FROM inserted;

    -- Log the action
    INSERT INTO Logss (Action, UserID, CreatedAt)
    VALUES (@Action + ' ON Requests (RequestID=' + CAST(@KeyValue AS NVARCHAR) + ')', @UserID, GETDATE());
END;


CREATE TRIGGER trg_Log_Users
ON Users
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Action NVARCHAR(20), @UserID INT, @KeyValue INT;

    -- Determine the action
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
        SET @Action = 'INSERT';
    ELSE IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'UPDATE';
    ELSE IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Action = 'DELETE';

    -- Get primary key value (UserID)
    IF @Action = 'DELETE'
        SELECT TOP 1 @KeyValue = UserID FROM deleted;
    ELSE
        SELECT TOP 1 @KeyValue = UserID FROM inserted;

    -- Log the action
    INSERT INTO Logss (Action, UserID, CreatedAt)
    VALUES (@Action + ' ON Users (UserID=' + CAST(@KeyValue AS NVARCHAR) + ')', @KeyValue, GETDATE());
END;


-- Users Sample Data
EXEC RegisterUser 'john_doe', 'password123', 'John', 'Doe', 'johndoe@gmail.com', '9876543210', '1995-05-15', '123 Main Street', 'Karachi', 'Sindh', 'Pakistan';
EXEC RegisterUser 'jane_smith', 'securepass', 'Jane', 'Smith', 'janesmith@yahoo.com', '1234567890', '1990-10-22', '456 Elm Street', 'Karachi', 'Sindh', 'Pakistan';
EXEC RegisterUser 'ali_khan', 'ali_pass123', 'Ali', 'Khan', 'ali.khan@hotmail.com', '5544332211', '1998-08-08', '78 Street A', 'Lahore', 'Punjab', 'Pakistan';
EXEC RegisterUser 'fatima_riaz', 'fatima789', 'Fatima', 'Riaz', 'fatima.riaz@domain.com', '9988776655', '2000-12-12', '99 Greenway', 'Peshawar', 'KPK', 'Pakistan';

-- Organs Sample Data
EXEC AddOrgan 'Ahmed Khan', 'Kidney', 'B+', 28, 'Jinnah Hospital', '03001234567';
EXEC AddOrgan 'Sara Ali', 'Heart', 'O-', 34, 'Agha Khan Hospital', '03331234567';
EXEC AddOrgan 'Bilal Mustafa', 'Liver', 'A+', 45, 'Indus Hospital', '03451234567';
EXEC AddOrgan 'Maria Yusuf', 'Kidney', 'AB-', 22, 'Liaquat National Hospital', '03021234567';
EXEC AddOrgan 'Usman Tariq', 'Lungs', 'B-', 40, 'Civil Hospital', '03161234567';

-- Blood Sample Data
EXEC AddBlood 'Zara Qureshi', 'A+', 25, 'Jinnah Hospital', '03011234567';
EXEC AddBlood 'Hassan Javed', 'O+', 30, 'Indus Hospital', '03121234567';
EXEC AddBlood 'Farah Naeem', 'AB-', 27, 'Civil Hospital', '03231234567';
EXEC AddBlood 'Kamran Ali', 'B+', 35, 'Liaquat National Hospital', '03341234567';
EXEC AddBlood 'Ayesha Khan', 'O-', 29, 'Agha Khan Hospital', '03451234567';

-- Hospitals Sample Data
EXEC AddHospital 'Jinnah Hospital', '02112345678', 'jinnah@hospital.com', '123 Jinnah Road', 'Karachi', 'Sindh', 'Pakistan';
EXEC AddHospital 'Indus Hospital', '02123456789', 'indus@hospital.com', '456 Indus Avenue', 'Karachi', 'Sindh', 'Pakistan';
EXEC AddHospital 'Civil Hospital', '02134567890', 'civil@hospital.com', '789 Civil Street', 'Karachi', 'Sindh', 'Pakistan';
EXEC AddHospital 'Agha Khan Hospital', '02145678901', 'agha@hospital.com', '123 Clifton Road', 'Karachi', 'Sindh', 'Pakistan';
EXEC AddHospital 'Liaquat National Hospital', '02156789012', 'liaquat@hospital.com', '456 Stadium Road', 'Karachi', 'Sindh', 'Pakistan';

-- Requests Sample Data
INSERT INTO Requests (UserID, RequestType, OrganName, BloodGroup, Status)
VALUES 
(2, 'Organ', 'Kidney', 'O+', 'pending'),
(3, 'Blood', NULL, 'A+', 'approved'),
(2, 'Organ', 'Heart', 'AB-', 'in progress'),
(4, 'Blood', NULL, 'O-', 'cancelled'),
(5, 'Organ', 'Liver', 'B-', 'pending');


