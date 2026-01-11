using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class ApAddBlood : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public ApAddBlood()
        {
            InitializeComponent();
            displayBloodData();
        }

        public void clearFields()
        {
            apab_bloodid_txt.Text = "";
            apab_donorname_txt.Text = "";
            apab_bloodgroup_cb.SelectedIndex = -1;
            apab_age_txt.Text = "";
            apab_donorhospital_txt.Text = "";
            apab_hospitalphone_txt.Text = "";
        }

        public void displayBloodData()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Blood";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apab_dataGridView.DataSource = dt;
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

        private void apab_add_btn_Click(object sender, EventArgs e)
        {
            if (apab_donorname_txt.Text == "" || apab_bloodgroup_cb.Text == "" || apab_age_txt.Text == "" || apab_donorhospital_txt.Text == "" || apab_hospitalphone_txt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (apab_hospitalphone_txt.Text.Length > 15)
                {
                    MessageBox.Show("Phone number cannot exceed 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(apab_hospitalphone_txt.Text, out long hospitalPhone))
                {
                    MessageBox.Show("Please enter a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(apab_age_txt.Text, out int donorAge))
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
                    SqlCommand cmd = new SqlCommand("InsertBlood", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DonorName", apab_donorname_txt.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", apab_bloodgroup_cb.Text);
                    cmd.Parameters.AddWithValue("@DonorAge", donorAge);
                    cmd.Parameters.AddWithValue("@DonorHospital", apab_donorhospital_txt.Text);
                    cmd.Parameters.AddWithValue("@HospitalPhone", hospitalPhone);

                    cmd.ExecuteNonQuery();

                    displayBloodData();
                    MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void apab_clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void apab_update_btn_Click(object sender, EventArgs e)
        {
            if (apab_donorname_txt.Text == "" || apab_bloodgroup_cb.Text == "" || apab_age_txt.Text == "" || apab_donorhospital_txt.Text == "" || apab_hospitalphone_txt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (apab_hospitalphone_txt.Text.Length > 15)
                {
                    MessageBox.Show("Phone number cannot exceed 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(apab_hospitalphone_txt.Text, out long hospitalPhone))
                {
                    MessageBox.Show("Please enter a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(apab_age_txt.Text, out int donorAge))
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
                    SqlCommand cmd = new SqlCommand("UpdateBlood", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BloodID", apab_bloodid_txt.Text);
                    cmd.Parameters.AddWithValue("@DonorName", apab_donorname_txt.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", apab_bloodgroup_cb.Text);
                    cmd.Parameters.AddWithValue("@DonorAge", donorAge);
                    cmd.Parameters.AddWithValue("@DonorHospital", apab_donorhospital_txt.Text);
                    cmd.Parameters.AddWithValue("@HospitalPhone", hospitalPhone);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayBloodData();
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


        private void apab_delete_btn_Click(object sender, EventArgs e)
        {
            if (apab_bloodid_txt.Text == "")
            {
                MessageBox.Show("Please fill the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult chcheck = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chcheck == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteBlood", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BloodID", apab_bloodid_txt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayBloodData();
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


        private void apab_loaddata_btn_Click(object sender, EventArgs e)
        {
            displayBloodData();
            MessageBox.Show("Data Loaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayBloodData();
        }


        public void displaySearchData(string bloodGroup)
        {
            try
            {
                connect.Open();
                string query = "select * from Blood where BloodGroup = @bloodgroup;";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apab_dataGridView.DataSource = dt;
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


        private void apab_search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(apab_bloodgroup_cb.Text))
            {
                MessageBox.Show("Please select Blood Group to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult chcheck = MessageBox.Show("Are you sure you want to search?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chcheck == DialogResult.Yes)
                {
                    displaySearchData(apab_bloodgroup_cb.Text);
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

