using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class ApLogs : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public ApLogs()
        {
            InitializeComponent();
            displayLogsData();
        }

        private void displayLogsData()
        {
            try
            {
                connect.Open();
                string query = "SELECT LogID, Action, UserID, CreatedAt FROM Logss ORDER BY CreatedAt DESC";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apl_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void apl_loaddata_btn_Click(object sender, EventArgs e)
        { 
                    displayLogsData();
                    MessageBox.Show("Data Loaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayLogsData();
        }
     }
}

