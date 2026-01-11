using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class ApAddHospitals : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public ApAddHospitals()
        {
            InitializeComponent();
            displayHospitalsData();
        }

        public void clearFields()
        {
            apah_hospitalid_txt.Text = "";
            apah_hospitalname_txt.Text = "";
            apah_phone_txt.Text = "";
            apah_email_txt.Text = "";
            apah_address_txt.Text = "";
            apah_city_txt.Text = "";
            apah_state_txt.Text = "";
            apah_country_txt.Text = "";
        }

        public void displayHospitalsData()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Hospitals";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apah_dataGridView.DataSource = dt;
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

        private void apah_add_btn_Click(object sender, EventArgs e)
        {
            if (apah_hospitalname_txt.Text == "" || apah_phone_txt.Text == "" || apah_email_txt.Text == "" || apah_address_txt.Text == "" || apah_city_txt.Text == "" || apah_state_txt.Text == "" || apah_country_txt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (apah_phone_txt.Text.Length > 15)
                {
                    MessageBox.Show("Phone number cannot exceed 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(apah_phone_txt.Text, out long hospitalPhone))
                {
                    MessageBox.Show("Please enter a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                try
                {
                    using (SqlCommand cmd = new SqlCommand("AddHospital", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@HospitalName", apah_hospitalname_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalPhone", hospitalPhone);
                        cmd.Parameters.AddWithValue("@HospitalEmail", apah_email_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalAL1", apah_address_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalCity", apah_city_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalState", apah_state_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalCountry", apah_country_txt.Text);

                        cmd.ExecuteNonQuery();

                        displayHospitalsData();
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
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

        private void apah_update_btn_Click(object sender, EventArgs e)
        {
            if (apah_hospitalname_txt.Text == "" || apah_phone_txt.Text == "" || apah_email_txt.Text == "" || apah_address_txt.Text == "" || apah_city_txt.Text == "" || apah_state_txt.Text == "" || apah_country_txt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (apah_phone_txt.Text.Length > 15)
                {
                    MessageBox.Show("Phone number cannot exceed 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(apah_phone_txt.Text, out long hospitalPhone))
                {
                    MessageBox.Show("Please enter a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                try
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateHospital", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@HospitalID", apah_hospitalid_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalName", apah_hospitalname_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalPhone", hospitalPhone);
                        cmd.Parameters.AddWithValue("@HospitalEmail", apah_email_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalAL1", apah_address_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalCity", apah_city_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalState", apah_state_txt.Text);
                        cmd.Parameters.AddWithValue("@HospitalCountry", apah_country_txt.Text);

                        cmd.ExecuteNonQuery();

                        displayHospitalsData();
                        MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
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

        private void apah_clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void apah_delete_btn_Click(object sender, EventArgs e)
        {
            if (apah_hospitalid_txt.Text == "")
            {
                MessageBox.Show("Please fill the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("DeleteHospital", connect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HospitalID", apah_hospitalid_txt.Text);
                    cmd.ExecuteNonQuery();

                    displayHospitalsData();
                    MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
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

        private void apah_loaddata_btn_Click(object sender, EventArgs e)
        {
            displayHospitalsData();
        }



        public void displaySearchData(int hospitalid,string hospitalname)
        {
            try
            {
                connect.Open();
                string query = "select * from Hospitals where HospitalID = @hospitalid or HospitalName = @hospitalname;";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@hospitalname", hospitalname);
                cmd.Parameters.AddWithValue("@hospitalid", hospitalid);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apah_dataGridView.DataSource = dt;
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
        private void apah_search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(apah_hospitalname_txt.Text) || string.IsNullOrEmpty(apah_hospitalid_txt.Text))
            {
                MessageBox.Show("Please select Hospital Name or ID to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult chcheck = MessageBox.Show("Are you sure you want to search?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chcheck == DialogResult.Yes)
                {
                    displaySearchData(int.Parse(apah_hospitalid_txt.Text), apah_hospitalname_txt.Text);
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
