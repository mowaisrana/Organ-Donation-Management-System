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
    public partial class ApAddOrgans : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public ApAddOrgans()
        {
            InitializeComponent();
            //To Display the data in the gridview
            displayOrganData();
        }

        public void clearFields()
        {
            apao_organid_txt.Text = "";
            apao_donorname_txt.Text = "";
            apao_organname_cb.SelectedIndex = -1;
            apao_bloodgroup_cb.SelectedIndex = -1;
            apao_age_txt.Text = "";
            apao_donorhospital_txt.Text = "";
            apao_hospitalphone_txt.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void panel2_Paint(object sender, PaintEventArgs e){}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e){}

        public void displayOrganData()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Organs";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apao_dataGridView.DataSource = dt;
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



        private void ApaoAddBtn_Click(object sender, EventArgs e)
        {
            //it showing error, the current state of sql is stilll open 
        }

        private void apao_update_btn_Click(object sender, EventArgs e)
        {
            if (apao_donorname_txt.Text == "" || apao_organname_cb.Text == "" || apao_bloodgroup_cb.Text == "" || apao_age_txt.Text == "" || apao_donorhospital_txt.Text == "" || apao_hospitalphone_txt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(apao_age_txt.Text, out int donorAge))
                {
                    MessageBox.Show("Please enter a valid age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                try
                {
                    // Call the UpdateOrgan stored procedure
                    SqlCommand cmd2 = new SqlCommand("UpdateOrgan", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
                    cmd2.Parameters.AddWithValue("@OrganID", Convert.ToInt32(apao_organid_txt.Text));
                    cmd2.Parameters.AddWithValue("@DonorName", apao_donorname_txt.Text);
                    cmd2.Parameters.AddWithValue("@OrganName", apao_organname_cb.Text);
                    cmd2.Parameters.AddWithValue("@BloodGroup", apao_bloodgroup_cb.Text);
                    cmd2.Parameters.AddWithValue("@DonorAge", donorAge);
                    cmd2.Parameters.AddWithValue("@DonorHospital", apao_donorhospital_txt.Text);
                    cmd2.Parameters.AddWithValue("@HospitalPhone", apao_hospitalphone_txt.Text);

                    // Execute the stored procedure
                    cmd2.ExecuteNonQuery();

                    // Refresh the grid and show success message
                    displayOrganData();
                    MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
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
        }


        private void apao_clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void apao_delete_btn_Click(object sender, EventArgs e)
        {
            // Ensure that a donor is selected to delete
            if (string.IsNullOrWhiteSpace(apao_organid_txt.Text) || !int.TryParse(apao_organid_txt.Text, out int organId) || organId <= 0)
            {
                MessageBox.Show("Please select a valid donor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion from the user
            var confirmResult = MessageBox.Show("Are you sure you want to delete this donor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                try
                {
                    // Call the DeleteOrgan stored procedure
                    SqlCommand cmd2 = new SqlCommand("DeleteOrgan", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    // Pass the selected donor's ID to the stored procedure
                    cmd2.Parameters.AddWithValue("@OrganID", organId);

                    // Execute the stored procedure
                    cmd2.ExecuteNonQuery();

                    // Refresh the grid and show success message
                    displayOrganData();
                    MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }


        private void apao_loaddata_btn_Click(object sender, EventArgs e)
        {

            displayOrganData();
           MessageBox.Show("Data Loaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayOrganData();
        }


        public void displaySearchData(int organid, string organname, string donorname, string bloodgroup,int donorage, string hospitalname)
        {
            try
            {
                connect.Open();
                string query = "select * from Organs where OrganID = @organid or OrganName = @organname or DonorName = @donorname or BloodGroup = @bloodgroup or DonorAge = @donorage or DonorHospital =@hospitalname;";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@hospitalname", hospitalname);
                cmd.Parameters.AddWithValue("@organid", organid);
                cmd.Parameters.AddWithValue("@organname", organname);
                cmd.Parameters.AddWithValue("@donorname", donorname);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                cmd.Parameters.AddWithValue("@donorage", donorage);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apao_dataGridView.DataSource = dt;
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


        private void apao_search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(apao_donorhospital_txt.Text) || string.IsNullOrEmpty(apao_organid_txt.Text) || string.IsNullOrEmpty(apao_organname_cb.Text) || string.IsNullOrEmpty(apao_donorname_txt.Text) || string.IsNullOrEmpty(apao_bloodgroup_cb.Text) || string.IsNullOrEmpty(apao_age_txt.Text))
            {
                MessageBox.Show("Please select Hospital Name or ID to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult chcheck = MessageBox.Show("Are you sure you want to search?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chcheck == DialogResult.Yes)
                {
                    displaySearchData(int.Parse(apao_organid_txt.Text), apao_organname_cb.Text, apao_donorname_txt.Text, apao_bloodgroup_cb.Text, int.Parse(apao_age_txt.Text), apao_donorhospital_txt.Text);
                    MessageBox.Show("Data searched successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}




