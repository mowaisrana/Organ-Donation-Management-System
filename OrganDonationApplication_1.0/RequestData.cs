using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    class RequestData
    {
        public int RequestID { get; set; }
        public int UserID { get; set; }
        public string RequestType { get; set; }
        public string OrganName { get; set; }
        public string BloodGroup { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }


        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public List<RequestData> RequestListData()
        {
            List<RequestData> listdata = new List<RequestData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectdata = "SELECT * FROM Requests";

                    using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            RequestData rd = new RequestData
                            {
                                RequestID = (int)reader["RequestID"],
                                UserID = (int)reader["UserID"],
                                RequestType = reader["RequestType"].ToString(),
                                OrganName = reader["OrganName"].ToString(),
                                BloodGroup = reader["BloodGroup"].ToString(),
                                Status = reader["Status"].ToString(),
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };
                            listdata.Add(rd);

                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);

                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return listdata;
        }


    }

}
