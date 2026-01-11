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
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void up_cross_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ap_logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout ?", "Confirmation Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes) 
            { 
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
        }

        private void ap_addorgans_btn_Click(object sender, EventArgs e)
        {
            apAddOrgans1.Visible = true;
            apAddHospitals1.Visible = false;
            apAddBlood1.Visible = false;
            apRequests1.Visible = false;
            apUsers1.Visible = false;
            apLogs1.Visible = false;
        }

        private void ap_addhospitals_btn_Click(object sender, EventArgs e)
        {
            apAddOrgans1.Visible = false;
            apAddHospitals1.Visible = true;
            apAddBlood1.Visible = false;
            apRequests1.Visible = false;
            apUsers1.Visible = false;
            apLogs1.Visible = false;
        }

        private void ap_addblood_btn_Click(object sender, EventArgs e)
        {
            apAddOrgans1.Visible = false;
            apAddHospitals1.Visible = false;
            apAddBlood1.Visible = true;
            apRequests1.Visible = false;
            apUsers1.Visible = false;
            apLogs1.Visible = false;
        }

        private void ap_request_btn_Click(object sender, EventArgs e)
        {
            apAddOrgans1.Visible = false;
            apAddHospitals1.Visible = false;
            apAddBlood1.Visible = false;
            apRequests1.Visible = true;
            apUsers1.Visible = false;
            apLogs1.Visible = false;
        }

        private void ap_users_btn_Click(object sender, EventArgs e)
        {
            apAddOrgans1.Visible = false;
            apAddHospitals1.Visible = false;
            apAddBlood1.Visible = false;
            apRequests1.Visible = false;
            apUsers1.Visible = true;
            apLogs1.Visible = false;
        }

        private void ap_logs_btn_Click(object sender, EventArgs e)
        {
            apAddOrgans1.Visible = false;
            apAddHospitals1.Visible = false;
            apAddBlood1.Visible = false;
            apRequests1.Visible = false;
            apUsers1.Visible = false;
            apLogs1.Visible = true;
        }

        private void apaof_cross_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apAddOrgans1_Load(object sender, EventArgs e)
        {

        }
    }
}
