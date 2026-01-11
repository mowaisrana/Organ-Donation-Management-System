using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    partial class ApAddOrgans
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.apao_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.apao_age_txt = new System.Windows.Forms.TextBox();
            this.apao_organid_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apao_loaddata_btn = new System.Windows.Forms.Button();
            this.apao_add_btn = new System.Windows.Forms.Button();
            this.apao_clear_btn = new System.Windows.Forms.Button();
            this.apao_delete_btn = new System.Windows.Forms.Button();
            this.apao_update_btn = new System.Windows.Forms.Button();
            this.apao_organname_cb = new System.Windows.Forms.ComboBox();
            this.apao_bloodgroup_cb = new System.Windows.Forms.ComboBox();
            this.apao_hospitalphone_txt = new System.Windows.Forms.TextBox();
            this.apao_donorhospital_txt = new System.Windows.Forms.TextBox();
            this.apao_donorname_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apao_search_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apao_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.apao_dataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 387);
            this.panel1.TabIndex = 0;
            // 
            // apao_dataGridView
            // 
            this.apao_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.apao_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apao_dataGridView.Location = new System.Drawing.Point(4, 26);
            this.apao_dataGridView.Name = "apao_dataGridView";
            this.apao_dataGridView.Size = new System.Drawing.Size(700, 348);
            this.apao_dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organs Data:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.apao_search_btn);
            this.panel2.Controls.Add(this.apao_age_txt);
            this.panel2.Controls.Add(this.apao_organid_txt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.apao_loaddata_btn);
            this.panel2.Controls.Add(this.apao_add_btn);
            this.panel2.Controls.Add(this.apao_clear_btn);
            this.panel2.Controls.Add(this.apao_delete_btn);
            this.panel2.Controls.Add(this.apao_update_btn);
            this.panel2.Controls.Add(this.apao_organname_cb);
            this.panel2.Controls.Add(this.apao_bloodgroup_cb);
            this.panel2.Controls.Add(this.apao_hospitalphone_txt);
            this.panel2.Controls.Add(this.apao_donorhospital_txt);
            this.panel2.Controls.Add(this.apao_donorname_txt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 214);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // apao_age_txt
            // 
            this.apao_age_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_age_txt.Location = new System.Drawing.Point(141, 108);
            this.apao_age_txt.Name = "apao_age_txt";
            this.apao_age_txt.Size = new System.Drawing.Size(135, 22);
            this.apao_age_txt.TabIndex = 2;
            // 
            // apao_organid_txt
            // 
            this.apao_organid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_organid_txt.Location = new System.Drawing.Point(141, 15);
            this.apao_organid_txt.Name = "apao_organid_txt";
            this.apao_organid_txt.Size = new System.Drawing.Size(135, 21);
            this.apao_organid_txt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Organ ID:";
            // 
            // apao_loaddata_btn
            // 
            this.apao_loaddata_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apao_loaddata_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apao_loaddata_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apao_loaddata_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_loaddata_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apao_loaddata_btn.Location = new System.Drawing.Point(19, 167);
            this.apao_loaddata_btn.Name = "apao_loaddata_btn";
            this.apao_loaddata_btn.Size = new System.Drawing.Size(114, 31);
            this.apao_loaddata_btn.TabIndex = 23;
            this.apao_loaddata_btn.Text = "Load Data";
            this.apao_loaddata_btn.UseVisualStyleBackColor = false;
            this.apao_loaddata_btn.Click += new System.EventHandler(this.apao_loaddata_btn_Click);
            // 
            // apao_add_btn
            // 
            this.apao_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apao_add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apao_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apao_add_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apao_add_btn.Location = new System.Drawing.Point(162, 167);
            this.apao_add_btn.Name = "apao_add_btn";
            this.apao_add_btn.Size = new System.Drawing.Size(114, 31);
            this.apao_add_btn.TabIndex = 19;
            this.apao_add_btn.Text = "Add";
            this.apao_add_btn.UseVisualStyleBackColor = false;
            this.apao_add_btn.Click += new System.EventHandler(this.apao_add_btn_Click);
            // 
            // apao_clear_btn
            // 
            this.apao_clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apao_clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apao_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apao_clear_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_clear_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apao_clear_btn.Location = new System.Drawing.Point(564, 167);
            this.apao_clear_btn.Name = "apao_clear_btn";
            this.apao_clear_btn.Size = new System.Drawing.Size(114, 31);
            this.apao_clear_btn.TabIndex = 22;
            this.apao_clear_btn.Text = "Clear";
            this.apao_clear_btn.UseVisualStyleBackColor = false;
            this.apao_clear_btn.Click += new System.EventHandler(this.apao_clear_btn_Click);
            // 
            // apao_delete_btn
            // 
            this.apao_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apao_delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apao_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apao_delete_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apao_delete_btn.Location = new System.Drawing.Point(429, 167);
            this.apao_delete_btn.Name = "apao_delete_btn";
            this.apao_delete_btn.Size = new System.Drawing.Size(114, 31);
            this.apao_delete_btn.TabIndex = 21;
            this.apao_delete_btn.Text = "Delete";
            this.apao_delete_btn.UseVisualStyleBackColor = false;
            this.apao_delete_btn.Click += new System.EventHandler(this.apao_delete_btn_Click);
            // 
            // apao_update_btn
            // 
            this.apao_update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apao_update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apao_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apao_update_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_update_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apao_update_btn.Location = new System.Drawing.Point(295, 167);
            this.apao_update_btn.Name = "apao_update_btn";
            this.apao_update_btn.Size = new System.Drawing.Size(114, 31);
            this.apao_update_btn.TabIndex = 20;
            this.apao_update_btn.Text = "Update";
            this.apao_update_btn.UseVisualStyleBackColor = false;
            this.apao_update_btn.Click += new System.EventHandler(this.apao_update_btn_Click);
            // 
            // apao_organname_cb
            // 
            this.apao_organname_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_organname_cb.FormattingEnabled = true;
            this.apao_organname_cb.Items.AddRange(new object[] {
            "Heart",
            "Liver",
            "Lungs",
            "Kidneys",
            "Pancreas",
            "Small Bowel"});
            this.apao_organname_cb.Location = new System.Drawing.Point(141, 73);
            this.apao_organname_cb.Name = "apao_organname_cb";
            this.apao_organname_cb.Size = new System.Drawing.Size(194, 23);
            this.apao_organname_cb.TabIndex = 18;
            // 
            // apao_bloodgroup_cb
            // 
            this.apao_bloodgroup_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_bloodgroup_cb.FormattingEnabled = true;
            this.apao_bloodgroup_cb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.apao_bloodgroup_cb.Location = new System.Drawing.Point(445, 73);
            this.apao_bloodgroup_cb.Name = "apao_bloodgroup_cb";
            this.apao_bloodgroup_cb.Size = new System.Drawing.Size(233, 23);
            this.apao_bloodgroup_cb.TabIndex = 17;
            // 
            // apao_hospitalphone_txt
            // 
            this.apao_hospitalphone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_hospitalphone_txt.Location = new System.Drawing.Point(445, 108);
            this.apao_hospitalphone_txt.Name = "apao_hospitalphone_txt";
            this.apao_hospitalphone_txt.Size = new System.Drawing.Size(233, 21);
            this.apao_hospitalphone_txt.TabIndex = 14;
            // 
            // apao_donorhospital_txt
            // 
            this.apao_donorhospital_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_donorhospital_txt.Location = new System.Drawing.Point(141, 139);
            this.apao_donorhospital_txt.Name = "apao_donorhospital_txt";
            this.apao_donorhospital_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.apao_donorhospital_txt.Size = new System.Drawing.Size(537, 21);
            this.apao_donorhospital_txt.TabIndex = 12;
            // 
            // apao_donorname_txt
            // 
            this.apao_donorname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_donorname_txt.Location = new System.Drawing.Point(141, 44);
            this.apao_donorname_txt.Name = "apao_donorname_txt";
            this.apao_donorname_txt.Size = new System.Drawing.Size(537, 21);
            this.apao_donorname_txt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(16, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Donor Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(331, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hospital Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Donor Hospital:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(350, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blood Group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Organ Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Donor Name:";
            // 
            // apao_search_btn
            // 
            this.apao_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apao_search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apao_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apao_search_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apao_search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apao_search_btn.Location = new System.Drawing.Point(564, 7);
            this.apao_search_btn.Name = "apao_search_btn";
            this.apao_search_btn.Size = new System.Drawing.Size(114, 31);
            this.apao_search_btn.TabIndex = 26;
            this.apao_search_btn.Text = "Search";
            this.apao_search_btn.UseVisualStyleBackColor = false;
            this.apao_search_btn.Click += new System.EventHandler(this.apao_search_btn_Click);
            // 
            // ApAddOrgans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ApAddOrgans";
            this.Size = new System.Drawing.Size(750, 668);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apao_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        private void apao_add_btn_Click(object sender, EventArgs e)
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
                    // Call the stored procedure instead of direct SQL insert
                    SqlCommand cmd2 = new SqlCommand("AddOrgan", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
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

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView apao_dataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apao_donorhospital_txt;
        private System.Windows.Forms.TextBox apao_donorname_txt;
        private System.Windows.Forms.TextBox apao_hospitalphone_txt;
        private System.Windows.Forms.ComboBox apao_organname_cb;
        private System.Windows.Forms.ComboBox apao_bloodgroup_cb;
        private System.Windows.Forms.Button apao_loaddata_btn;
        private System.Windows.Forms.Button apao_add_btn;
        private System.Windows.Forms.Button apao_clear_btn;
        private System.Windows.Forms.Button apao_delete_btn;
        private System.Windows.Forms.Button apao_update_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apao_organid_txt;
        private TextBox apao_age_txt;
        private Button apao_search_btn;
    }
}
