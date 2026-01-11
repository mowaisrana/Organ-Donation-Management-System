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
    public partial class UpBloods : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");
        public UpBloods()
        {
            InitializeComponent();
            displayBloodsData();
        }

        public void displayBloodsData()
        {
            try
            {
                connect.Open();
                string query = "select BloodID,DonorName,BloodGroup,DonorAge,DonorHospital,HospitalPhone from Blood;";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                upb_dataGridView.DataSource = dt;
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

        public void displaySearchData(string bloodGroup)
        {
            try
            {
                connect.Open();
                string query = "select BloodID,DonorName,BloodGroup,DonorAge,DonorHospital,HospitalPhone from Blood where BloodGroup = @bloodgroup;";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                upb_dataGridView.DataSource = dt;
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

        private void upb_search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(upb_bloodgroup_cb.Text) )
            {
                MessageBox.Show("Please select all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult chcheck = MessageBox.Show("Are you sure you want to search?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chcheck == DialogResult.Yes)
                {
                    displaySearchData(upb_bloodgroup_cb.Text);
                    MessageBox.Show("Data searched successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void upb_load_btn_Click(object sender, EventArgs e)
        {


        }

        private void upb_load_btn_Click_1(object sender, EventArgs e)
        {
            displayBloodsData();
            MessageBox.Show("Data Reloaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayBloodsData(); // Refresh the grid view with the latest data
        }
    }
}
