using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace OrganDonationApplication_1._0
{
    
    public partial class UpOrgans : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public UpOrgans()
        {
            InitializeComponent();
            displayOrganData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void up_bloodgroup_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void displayOrganData()
        {
            try
            {
                connect.Open();
                string query = "select OrganID,OrganName,DonorName,BloodGroup,DonorAge,DonorHospital,HospitalPhone from Organs;";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                upo_dataGridView.DataSource = dt;
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

        public void displaySearchData(string organName, string bloodGroup)
        {
            try
            {
                connect.Open();
                string query = "select OrganID,OrganName,DonorName,BloodGroup,DonorAge,DonorHospital,HospitalPhone from Organs where OrganName = @organname and BloodGroup = @bloodgroup;";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@organname", organName);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                upo_dataGridView.DataSource = dt;
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


        private void upo_search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(upo_bloodgroup_cb.Text) || string.IsNullOrEmpty(upo_organname_cb.Text))
            {
                MessageBox.Show("Please select all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult chcheck = MessageBox.Show("Are you sure you want to search?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chcheck == DialogResult.Yes)
                {
                    displaySearchData(upo_organname_cb.Text, upo_bloodgroup_cb.Text);
                    MessageBox.Show("Data searched successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void upo_load_btn_Click(object sender, EventArgs e)
        {
            displayOrganData();
            MessageBox.Show("Data Reloaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayOrganData(); // Refresh the grid view with the latest data
        
        }
    }
}

