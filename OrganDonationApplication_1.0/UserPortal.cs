using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class UserPortal : Form
    {

        public UserPortal()
        {
            InitializeComponent();
            upProfile1 = new UpProfile();
        }


        private void InitializeComponent()
        {
            this.up_cross_lbl = new System.Windows.Forms.Label();
            this.up_donate_btn = new System.Windows.Forms.Button();
            this.up_profile_btn = new System.Windows.Forms.Button();
            this.up_logout_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.up_hospitals_btn = new System.Windows.Forms.Button();
            this.up_blood_btn = new System.Windows.Forms.Button();
            this.up_organ_btn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upProfile2 = new OrganDonationApplication_1._0.UpProfile();
            this.upDonate1 = new OrganDonationApplication_1._0.UpDonate();
            this.upHospitals1 = new OrganDonationApplication_1._0.UpHospitals();
            this.upBloods1 = new OrganDonationApplication_1._0.UpBloods();
            this.upOrgans1 = new OrganDonationApplication_1._0.UpOrgans();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // up_cross_lbl
            // 
            this.up_cross_lbl.AutoSize = true;
            this.up_cross_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_cross_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_cross_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.up_cross_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_cross_lbl.Location = new System.Drawing.Point(775, 0);
            this.up_cross_lbl.Name = "up_cross_lbl";
            this.up_cross_lbl.Size = new System.Drawing.Size(25, 26);
            this.up_cross_lbl.TabIndex = 13;
            this.up_cross_lbl.Text = "X";
            this.up_cross_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.up_cross_lbl.Click += new System.EventHandler(this.up_cross_lbl_Click);
            // 
            // up_donate_btn
            // 
            this.up_donate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_donate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_donate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_donate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_donate_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_donate_btn.Location = new System.Drawing.Point(65, 302);
            this.up_donate_btn.Name = "up_donate_btn";
            this.up_donate_btn.Size = new System.Drawing.Size(88, 35);
            this.up_donate_btn.TabIndex = 22;
            this.up_donate_btn.Text = "Donate";
            this.up_donate_btn.UseVisualStyleBackColor = false;
            this.up_donate_btn.Click += new System.EventHandler(this.up_donate_btn_Click);
            // 
            // up_profile_btn
            // 
            this.up_profile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_profile_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_profile_btn.Location = new System.Drawing.Point(65, 343);
            this.up_profile_btn.Name = "up_profile_btn";
            this.up_profile_btn.Size = new System.Drawing.Size(88, 35);
            this.up_profile_btn.TabIndex = 24;
            this.up_profile_btn.Text = "Profile";
            this.up_profile_btn.UseVisualStyleBackColor = false;
            this.up_profile_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // up_logout_btn
            // 
            this.up_logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_logout_btn.Location = new System.Drawing.Point(65, 384);
            this.up_logout_btn.Name = "up_logout_btn";
            this.up_logout_btn.Size = new System.Drawing.Size(88, 35);
            this.up_logout_btn.TabIndex = 25;
            this.up_logout_btn.Text = "Log Out";
            this.up_logout_btn.UseVisualStyleBackColor = false;
            this.up_logout_btn.Click += new System.EventHandler(this.up_logout_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(130, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 39);
            this.label6.TabIndex = 37;
            this.label6.Text = "Organ Donation";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(397, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "A Platform for Hope and Healing";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // up_hospitals_btn
            // 
            this.up_hospitals_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_hospitals_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_hospitals_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_hospitals_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_hospitals_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_hospitals_btn.Location = new System.Drawing.Point(65, 261);
            this.up_hospitals_btn.Name = "up_hospitals_btn";
            this.up_hospitals_btn.Size = new System.Drawing.Size(88, 35);
            this.up_hospitals_btn.TabIndex = 40;
            this.up_hospitals_btn.Text = "Hospitals";
            this.up_hospitals_btn.UseVisualStyleBackColor = false;
            this.up_hospitals_btn.Click += new System.EventHandler(this.up_hospitals_btn_Click_1);
            // 
            // up_blood_btn
            // 
            this.up_blood_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_blood_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_blood_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_blood_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_blood_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_blood_btn.Location = new System.Drawing.Point(65, 220);
            this.up_blood_btn.Name = "up_blood_btn";
            this.up_blood_btn.Size = new System.Drawing.Size(88, 35);
            this.up_blood_btn.TabIndex = 42;
            this.up_blood_btn.Text = "Blood";
            this.up_blood_btn.UseVisualStyleBackColor = false;
            this.up_blood_btn.Click += new System.EventHandler(this.up_blood_btn_Click_1);
            // 
            // up_organ_btn
            // 
            this.up_organ_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_organ_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up_organ_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_organ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_organ_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_organ_btn.Location = new System.Drawing.Point(65, 179);
            this.up_organ_btn.Name = "up_organ_btn";
            this.up_organ_btn.Size = new System.Drawing.Size(88, 35);
            this.up_organ_btn.TabIndex = 44;
            this.up_organ_btn.Text = "Organs";
            this.up_organ_btn.UseVisualStyleBackColor = false;
            this.up_organ_btn.Click += new System.EventHandler(this.up_organ_btn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OrganDonationApplication_1._0.Properties.Resources.pulmonology_80x80;
            this.pictureBox4.Location = new System.Drawing.Point(9, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OrganDonationApplication_1._0.Properties.Resources.bloodtype_80x80;
            this.pictureBox3.Location = new System.Drawing.Point(9, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OrganDonationApplication_1._0.Properties.Resources.home_health_80x80;
            this.pictureBox2.Location = new System.Drawing.Point(9, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureBox1.Image = global::OrganDonationApplication_1._0.Properties.Resources.logo_png_120;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::OrganDonationApplication_1._0.Properties.Resources.logout_80x80;
            this.pictureBox8.Location = new System.Drawing.Point(9, 384);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(42, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OrganDonationApplication_1._0.Properties.Resources.person_80x80;
            this.pictureBox5.Location = new System.Drawing.Point(9, 343);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::OrganDonationApplication_1._0.Properties.Resources.volunteer_activism_80x80;
            this.pictureBox6.Location = new System.Drawing.Point(9, 302);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upOrgans1);
            this.panel1.Controls.Add(this.upBloods1);
            this.panel1.Controls.Add(this.upHospitals1);
            this.panel1.Controls.Add(this.upDonate1);
            this.panel1.Controls.Add(this.upProfile2);
            this.panel1.Location = new System.Drawing.Point(159, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 517);
            this.panel1.TabIndex = 39;
            // 
            // upProfile2
            // 
            this.upProfile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upProfile2.Location = new System.Drawing.Point(3, 0);
            this.upProfile2.LoggedInUsername = null;
            this.upProfile2.Name = "upProfile2";
            this.upProfile2.Size = new System.Drawing.Size(635, 508);
            this.upProfile2.TabIndex = 0;
            // 
            // upDonate1
            // 
            this.upDonate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upDonate1.Location = new System.Drawing.Point(3, 0);
            this.upDonate1.Name = "upDonate1";
            this.upDonate1.Size = new System.Drawing.Size(635, 514);
            this.upDonate1.TabIndex = 1;
            // 
            // upHospitals1
            // 
            this.upHospitals1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upHospitals1.Location = new System.Drawing.Point(3, 0);
            this.upHospitals1.Name = "upHospitals1";
            this.upHospitals1.Size = new System.Drawing.Size(635, 514);
            this.upHospitals1.TabIndex = 2;
            // 
            // upBloods1
            // 
            this.upBloods1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upBloods1.Location = new System.Drawing.Point(3, 0);
            this.upBloods1.Name = "upBloods1";
            this.upBloods1.Size = new System.Drawing.Size(638, 517);
            this.upBloods1.TabIndex = 3;
            // 
            // upOrgans1
            // 
            this.upOrgans1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upOrgans1.Location = new System.Drawing.Point(3, 3);
            this.upOrgans1.Name = "upOrgans1";
            this.upOrgans1.Size = new System.Drawing.Size(638, 511);
            this.upOrgans1.TabIndex = 4;
            // 
            // UserPortal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.up_organ_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.up_blood_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.up_hospitals_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.up_logout_btn);
            this.Controls.Add(this.up_profile_btn);
            this.Controls.Add(this.up_donate_btn);
            this.Controls.Add(this.up_cross_lbl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPortal";
            this.Load += new System.EventHandler(this.UserPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void up_cross_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            upOrgans1.Visible = false;
            upBloods1.Visible = false;
            upHospitals1.Visible = false;
            upDonate1.Visible = false;
            upProfile2.Visible = true;
        }

        
        private void up_profile_btn_Click(object sender, EventArgs e)
        {
            upOrgans1.Visible = false;
            upBloods1.Visible = false;
            upHospitals1.Visible = false;
            upDonate1.Visible = false;
            upProfile2.Visible = true;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserPortal_Load(object sender, EventArgs e)
        {

        }

        private void up_hospitals_btn_Click(object sender, EventArgs e)
        {

        }

        private void up_organs_btn_Click(object sender, EventArgs e)
        {

        }

        private void up_logout_btn_Click(object sender, EventArgs e)
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

        private void up_donate_btn_Click(object sender, EventArgs e)
        {
            upOrgans1.Visible = false;
            upBloods1.Visible = false;
            upHospitals1.Visible = false;
            upDonate1.Visible = true;
            upProfile2.Visible = false;
        }

        private void up_blood_btn_Click(object sender, EventArgs e)
        {
            upOrgans1.Visible = false;
            upBloods1.Visible = true;
            upHospitals1.Visible = false;
            upDonate1.Visible = false;
            upProfile2.Visible = false;
        }

        private void up_hospitals_btn_Click_1(object sender, EventArgs e)
        {
            upOrgans1.Visible = false;
            upBloods1.Visible = false;
            upHospitals1.Visible = true;
            upDonate1.Visible = false;
            upProfile2.Visible = false;
            
        }


        private void up_blood_btn_Click_1(object sender, EventArgs e)
        {
            upOrgans1.Visible = false;
            upBloods1.Visible = true;
            upHospitals1.Visible = false;
            upDonate1.Visible = false;
            upProfile2.Visible = false;
        }

        private void up_organ_btn_Click(object sender, EventArgs e)
        {
            upOrgans1.Visible = true;
            upBloods1.Visible = false;
            upHospitals1.Visible = false;
            upDonate1.Visible = false;
            upProfile2.Visible = false;
            
        }
    }
}
