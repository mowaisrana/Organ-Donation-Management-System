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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_cross_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_login_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Register_clickhere_btn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        void clear() { Register_username_txt.Text = Register_password_txt.Text = Register_email_txt.Text = register_firstname_txt.Text = register_lastname_txt.Text = Register_dateTimePicker.Text = ""; }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (Register_username_txt.Text == "" || Register_password_txt.Text == "" || Register_email_txt.Text == "" || Register_dateTimePicker.Text == "" || register_firstname_txt.Text == "" || register_lastname_txt.Text == "")
            {
                MessageBox.Show("Please Fill all Mandatory Fields", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    // Use the stored procedure RegisterUser
                    SqlCommand cmd = new SqlCommand("RegisterUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
                    cmd.Parameters.AddWithValue("@Username", Register_username_txt.Text);
                    cmd.Parameters.AddWithValue("@Password", Register_password_txt.Text);
                    cmd.Parameters.AddWithValue("@FirstName", register_firstname_txt.Text);
                    cmd.Parameters.AddWithValue("@LastName", register_lastname_txt.Text);
                    cmd.Parameters.AddWithValue("@Email", Register_email_txt.Text);
                    cmd.Parameters.AddWithValue("@Phone", register_phone_txt);  
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(Register_dateTimePicker.Text));
                    cmd.Parameters.AddWithValue("@AddressLine1", register_adl_txt); 
                    cmd.Parameters.AddWithValue("@City", register_city_txt);  
                    cmd.Parameters.AddWithValue("@State", register_state_txt); 
                    cmd.Parameters.AddWithValue("@Country", register_country_txt); 

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }


    }
}

