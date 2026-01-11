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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public Form1() { InitializeComponent(); }

        private void Login_cross_lbl_Click(object sender, EventArgs e) { Application.Exit(); }

        private void Login_register_btn_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            regform.Show();
            this.Hide();
        }

        private void Login_clickhere_btn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string query = " SELECT * FROM Users WHERE Username='" + Login_username_txt.Text + "'and Password='" + Login_password_txt.Text + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.ExecuteNonQuery(); insert
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UserPortal home = new UserPortal();
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}