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
    class LogsData
    {
        public int LogID { get; set; }
        public string Action { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedAt { get; set; }


        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public List<LogsData> LogsListData()
        {
            List<LogsData> listdata = new List<LogsData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectdata = "SELECT * FROM Logss";

                    using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            LogsData ld = new LogsData
                            {
                                LogID = (int)reader["LogID"],
                                Action = reader["Action"].ToString(),
                                UserID = (int)reader["UserID"],
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };
                            listdata.Add(ld);

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
