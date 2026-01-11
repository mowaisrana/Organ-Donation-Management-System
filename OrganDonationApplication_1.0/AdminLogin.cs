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
    public partial class AdminLogin : Form
    {

        SqlConnection con = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void admin_cross_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_clickhere__btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Admin_login_btn_Click(object sender, EventArgs e)
        {
            string query = " SELECT * FROM Users WHERE Role='admin' AND Username='" + Admin_login_username_txt.Text + "'and Password='" + Admin_login_password_txt.Text + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.ExecuteNonQuery(); insert
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AdminPortal dashboard = new AdminPortal();
                dashboard.Show();
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
