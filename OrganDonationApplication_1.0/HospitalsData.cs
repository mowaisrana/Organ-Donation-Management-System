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
    class HospitalsData
    {
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string HospitalPhone { get; set; }
        public string HospitalEmail { get; set; }
        public string HospitalAL1 { get; set; }
        public string HospitalCity { get; set; }
        public string HospitalState { get; set; }
        public string HospitalCountry { get; set; }
        public DateTime CreatedAt { get; set; }


        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public List<HospitalsData> hospitalListData()
        {
            List<HospitalsData> listdata = new List<HospitalsData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectdata = "SELECT * FROM Hospitals";

                    using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            HospitalsData hd = new HospitalsData
                            {
                                HospitalID = (int)reader["HospitalID"],
                                HospitalName = reader["HospitalName"].ToString(),
                                HospitalPhone = reader["HospitalPhone"].ToString(),
                                HospitalEmail = reader["HospitalEmail"].ToString(),
                                HospitalAL1 = reader["HospitalAL1"].ToString(),
                                HospitalCity = reader["HospitalCity"].ToString(),
                                HospitalState = reader["HospitalState"].ToString(),
                                HospitalCountry = reader["HospitalCountry"].ToString(),
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };
                            listdata.Add(hd);

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
