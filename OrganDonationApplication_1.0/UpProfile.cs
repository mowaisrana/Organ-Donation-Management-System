using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class UpProfile : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        // Variable to store the logged-in user's username
        public string LoggedInUsername { get; set; }

        public UpProfile()
        {
            InitializeComponent();
        }

        // This method will be called after login to set the username for the logged-in user
        public void SetLoggedInUser(string username)
        {
            LoggedInUsername = username;
            up_username_txt.Text = LoggedInUsername; // Display username (optional, can be hidden)
        }

        private void up_update_btn_Click(object sender, EventArgs e)
        {
            if (up_profile_password_txt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                    // Modify the SQL query to use the logged-in username
                    string updatedata = "UPDATE Users SET Password = @Password, FirstName = @Firstname, LastName = @Lastname, Email = @Email, DateOfBirth = @dob, Address = @address, Phone = @phone, City = @city, State = @state, Country = @country WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                    {
                        cmd.Parameters.AddWithValue("@Password", up_profile_password_txt.Text);
                        cmd.Parameters.AddWithValue("@Firstname", up_profile_firstname_txt.Text);
                        cmd.Parameters.AddWithValue("@Lastname", up_profile_lastname_txt.Text);
                        cmd.Parameters.AddWithValue("@Email", upprofile_email_txt.Text);
                        cmd.Parameters.AddWithValue("@phone", up_phone_txt.Text);
                        cmd.Parameters.AddWithValue("@dob", up_profile__dateTimePicker.Value); // Changed to Value to get DateTime
                        cmd.Parameters.AddWithValue("@address", up_profile_add_txt.Text);
                        cmd.Parameters.AddWithValue("@city", up_profile_city_txt.Text);
                        cmd.Parameters.AddWithValue("@state", up_profile_state_txt.Text);
                        cmd.Parameters.AddWithValue("@country", up_profile_country_txt.Text);
                        cmd.Parameters.AddWithValue("@Username", LoggedInUsername); // Use the logged-in username

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        DialogResult chcheck = MessageBox.Show("Are you sure you want to update this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (chcheck == DialogResult.Yes)
                        {
                            MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // Close the connection
                    connect.Close();
                }
            }
        }

        private void up_phone_txt_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle phone text change if needed
        }
    }
}
