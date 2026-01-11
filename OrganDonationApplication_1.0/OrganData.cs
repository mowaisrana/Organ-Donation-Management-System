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
    class OrganData
    {
        public int OrganID { get; set; }
        public string DonorName { get; set; }
        public string OrganName { get; set; }
        public string BloodGroup { get; set; }
        public int DonorAge { get; set; }
        public string DonorHospital { get; set; }
        public string HospitalPhone { get; set; }
        public DateTime CreatedAt { get; set; }


        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public List<OrganData> organListData()
        {
            List<OrganData> listdata = new List<OrganData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectdata = "SELECT * FROM Organs";

                    using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OrganData od = new OrganData
                            {
                                OrganID = (int)reader["OrganID"],
                                DonorName = reader["DonorName"].ToString(),
                                OrganName = reader["OrganName"].ToString(),
                                BloodGroup = reader["BloodGroup"].ToString(),
                                DonorAge = (int)reader["DonorAge"],
                                DonorHospital = reader["DonorHospital"].ToString(),
                                HospitalPhone = reader["HospitalPhone"].ToString(),
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };
                            listdata.Add(od);

                        }
                    }

                }
                catch(Exception ex)
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
