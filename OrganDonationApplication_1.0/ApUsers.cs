using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class ApUsers : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public ApUsers()
        {
            InitializeComponent();
            displayUsersData();
        }

        public void clearfields()
        {
            apu_userid_txt.Text = "";
            apu_username_txt.Text = "";
            apu_password_txt.Text = "";
            apu_role_cb.Text = "";
        }

        public void displayUsersData()
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("GetAllUsers", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                apu_dataGridView.DataSource = dt;
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

        private void apu_update_btn_Click(object sender, EventArgs e)
        {
            if (apu_userid_txt.Text == "" || apu_username_txt.Text == "" || apu_password_txt.Text == "" || apu_role_cb.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("UpdateUser", connect);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", apu_userid_txt.Text);
                    cmd.Parameters.AddWithValue("@UserName", apu_username_txt.Text);
                    cmd.Parameters.AddWithValue("@Password", apu_password_txt.Text);
                    cmd.Parameters.AddWithValue("@Role", apu_role_cb.Text);

                    cmd.ExecuteNonQuery();

                    DialogResult chcheck = MessageBox.Show("Are you sure you want to update this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (chcheck == DialogResult.Yes)
                    {
                        displayUsersData();
                        MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfields();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void apu_delete_btn_Click(object sender, EventArgs e)
        {
            if (apu_userid_txt.Text == "" || apu_username_txt.Text == "")
            {
                MessageBox.Show("Please fill the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DeleteUser", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", apu_userid_txt.Text);
                    cmd.ExecuteNonQuery();

                    DialogResult chcheck = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (chcheck == DialogResult.Yes)
                    {
                        displayUsersData();
                        MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfields();
                    }
                    else
                    {
                        MessageBox.Show("Cancelled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void apu_clear_btn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void apu_loaddata_btn_Click(object sender, EventArgs e)
        {
            displayUsersData();
        }
    }
}
