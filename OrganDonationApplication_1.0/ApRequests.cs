using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class ApRequests : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public ApRequests()
        {
            InitializeComponent();
            displayRequestData();
        }

        public void clearFields()
        {
            apr_requestid_txt.Text = "";
            apr_userid_txt.Text = "";
            apr_requesttype_cb.Text = "";
            apr_organname_cb.Text = "";
            apr_bloodgroup_cb.Text = "";
            apr_status_txt.Text = "";
        }

        public void displayRequestData()
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("GetAllRequests", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apr_dataGridView.DataSource = dt;
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

        private void apr_update_btn_Click(object sender, EventArgs e)
        {
            if (apr_requestid_txt.Text == "" || apr_status_txt.Text == "")
            {
                MessageBox.Show("Please fill the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("UpdateRequest", connect);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RequestID", apr_requestid_txt.Text);
                    cmd.Parameters.AddWithValue("@RequestType", apr_requesttype_cb.Text);
                    cmd.Parameters.AddWithValue("@OrganName", apr_organname_cb.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", apr_bloodgroup_cb.Text);
                    cmd.Parameters.AddWithValue("@Status", apr_status_txt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayRequestData();
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

        private void apr_clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void apr_delete_btn_Click(object sender, EventArgs e)
        {
            if (apr_requestid_txt.Text == "")
            {
                MessageBox.Show("Please fill the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DeleteRequest", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequestID", apr_requestid_txt.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayRequestData();
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

        private void apr_loaddata_btn_Click(object sender, EventArgs e)
        {
            displayRequestData();
            MessageBox.Show("Data Loaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayRequestData();
        }
     }
}

