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
    
    public partial class UpHospitals : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");
        public UpHospitals()
        {
            InitializeComponent();
            displayHospitalsData();
        }

        public void displayHospitalsData()
        {
            try
            {
                connect.Open();
                string query = "select HospitalID,HospitalName,Phone,Email,AddressLine1,City,State,Country from Hospitals;";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                uph_dataGridView.DataSource = dt;
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

        public void displaySearchData(string hospitalName)
        {
            try
            {
                connect.Open();
                string query = "select HospitalID,HospitalName,Phone,Email,AddressLine1,City,State,Country from Hospitals where HospitalName = @hospitalname;";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@hospitalname", hospitalName);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                uph_dataGridView.DataSource = dt;
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

        private void uph_search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uph_name_txt.Text))
            {
                MessageBox.Show("Please select all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult chcheck = MessageBox.Show("Are you sure you want to search?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chcheck == DialogResult.Yes)
                {
                    displaySearchData(uph_name_txt.Text);
                    MessageBox.Show("Data searched successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void uph_load_btn_Click(object sender, EventArgs e)
        {
            displayHospitalsData();
            MessageBox.Show("Data Reloaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayHospitalsData(); // Refresh the grid view with the latest data
        }
    }
}
