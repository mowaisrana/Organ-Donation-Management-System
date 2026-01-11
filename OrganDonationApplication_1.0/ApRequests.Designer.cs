namespace OrganDonationApplication_1._0
{
    partial class ApRequests
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
            this.apr_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.apr_loaddata_btn = new System.Windows.Forms.Button();
            this.apr_userid_txt = new System.Windows.Forms.TextBox();
            this.apr_requestid_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apr_status_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apr_requesttype_cb = new System.Windows.Forms.ComboBox();
            this.apr_organname_cb = new System.Windows.Forms.ComboBox();
            this.apr_bloodgroup_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apr_clear_btn = new System.Windows.Forms.Button();
            this.apr_delete_btn = new System.Windows.Forms.Button();
            this.apr_update_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apr_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.apr_dataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 452);
            this.panel1.TabIndex = 4;
            // 
            // apr_dataGridView
            // 
            this.apr_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.apr_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apr_dataGridView.Location = new System.Drawing.Point(4, 26);
            this.apr_dataGridView.Name = "apr_dataGridView";
            this.apr_dataGridView.Size = new System.Drawing.Size(700, 422);
            this.apr_dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requests Data:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.apr_loaddata_btn);
            this.panel2.Controls.Add(this.apr_userid_txt);
            this.panel2.Controls.Add(this.apr_requestid_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.apr_status_txt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.apr_requesttype_cb);
            this.panel2.Controls.Add(this.apr_organname_cb);
            this.panel2.Controls.Add(this.apr_bloodgroup_cb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.apr_clear_btn);
            this.panel2.Controls.Add(this.apr_delete_btn);
            this.panel2.Controls.Add(this.apr_update_btn);
            this.panel2.Location = new System.Drawing.Point(20, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 156);
            this.panel2.TabIndex = 2;
            // 
            // apr_loaddata_btn
            // 
            this.apr_loaddata_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apr_loaddata_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apr_loaddata_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apr_loaddata_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_loaddata_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apr_loaddata_btn.Location = new System.Drawing.Point(13, 113);
            this.apr_loaddata_btn.Name = "apr_loaddata_btn";
            this.apr_loaddata_btn.Size = new System.Drawing.Size(126, 28);
            this.apr_loaddata_btn.TabIndex = 26;
            this.apr_loaddata_btn.Text = "Load Data";
            this.apr_loaddata_btn.UseVisualStyleBackColor = false;
            this.apr_loaddata_btn.Click += new System.EventHandler(this.apr_loaddata_btn_Click);
            // 
            // apr_userid_txt
            // 
            this.apr_userid_txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_userid_txt.Location = new System.Drawing.Point(459, 12);
            this.apr_userid_txt.Name = "apr_userid_txt";
            this.apr_userid_txt.Size = new System.Drawing.Size(223, 23);
            this.apr_userid_txt.TabIndex = 25;
            // 
            // apr_requestid_txt
            // 
            this.apr_requestid_txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_requestid_txt.Location = new System.Drawing.Point(130, 12);
            this.apr_requestid_txt.Name = "apr_requestid_txt";
            this.apr_requestid_txt.Size = new System.Drawing.Size(209, 23);
            this.apr_requestid_txt.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(359, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "User id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Request id:";
            // 
            // apr_status_txt
            // 
            this.apr_status_txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_status_txt.FormattingEnabled = true;
            this.apr_status_txt.Items.AddRange(new object[] {
            "pending",
            "approved",
            "in-progress",
            "cancelled"});
            this.apr_status_txt.Location = new System.Drawing.Point(459, 76);
            this.apr_status_txt.Name = "apr_status_txt";
            this.apr_status_txt.Size = new System.Drawing.Size(223, 24);
            this.apr_status_txt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(359, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Status:";
            // 
            // apr_requesttype_cb
            // 
            this.apr_requesttype_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_requesttype_cb.FormattingEnabled = true;
            this.apr_requesttype_cb.Items.AddRange(new object[] {
            "Organ",
            "Blood"});
            this.apr_requesttype_cb.Location = new System.Drawing.Point(130, 45);
            this.apr_requesttype_cb.Name = "apr_requesttype_cb";
            this.apr_requesttype_cb.Size = new System.Drawing.Size(209, 24);
            this.apr_requesttype_cb.TabIndex = 19;
            // 
            // apr_organname_cb
            // 
            this.apr_organname_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_organname_cb.FormattingEnabled = true;
            this.apr_organname_cb.Items.AddRange(new object[] {
            "Heart",
            "Liver",
            "Lungs",
            "Kidneys",
            "Pancreas",
            "Small Bowel"});
            this.apr_organname_cb.Location = new System.Drawing.Point(459, 45);
            this.apr_organname_cb.Name = "apr_organname_cb";
            this.apr_organname_cb.Size = new System.Drawing.Size(224, 24);
            this.apr_organname_cb.TabIndex = 18;
            // 
            // apr_bloodgroup_cb
            // 
            this.apr_bloodgroup_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_bloodgroup_cb.FormattingEnabled = true;
            this.apr_bloodgroup_cb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.apr_bloodgroup_cb.Location = new System.Drawing.Point(130, 76);
            this.apr_bloodgroup_cb.Name = "apr_bloodgroup_cb";
            this.apr_bloodgroup_cb.Size = new System.Drawing.Size(209, 24);
            this.apr_bloodgroup_cb.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 80);
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
            this.label3.Location = new System.Drawing.Point(359, 49);
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
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Request Type:";
            // 
            // apr_clear_btn
            // 
            this.apr_clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apr_clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apr_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apr_clear_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_clear_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apr_clear_btn.Location = new System.Drawing.Point(535, 113);
            this.apr_clear_btn.Name = "apr_clear_btn";
            this.apr_clear_btn.Size = new System.Drawing.Size(148, 28);
            this.apr_clear_btn.TabIndex = 3;
            this.apr_clear_btn.Text = "Clear";
            this.apr_clear_btn.UseVisualStyleBackColor = false;
            this.apr_clear_btn.Click += new System.EventHandler(this.apr_clear_btn_Click);
            // 
            // apr_delete_btn
            // 
            this.apr_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apr_delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apr_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apr_delete_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apr_delete_btn.Location = new System.Drawing.Point(362, 113);
            this.apr_delete_btn.Name = "apr_delete_btn";
            this.apr_delete_btn.Size = new System.Drawing.Size(127, 28);
            this.apr_delete_btn.TabIndex = 2;
            this.apr_delete_btn.Text = "Delete";
            this.apr_delete_btn.UseVisualStyleBackColor = false;
            this.apr_delete_btn.Click += new System.EventHandler(this.apr_delete_btn_Click);
            // 
            // apr_update_btn
            // 
            this.apr_update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apr_update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apr_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apr_update_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apr_update_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.apr_update_btn.Location = new System.Drawing.Point(188, 113);
            this.apr_update_btn.Name = "apr_update_btn";
            this.apr_update_btn.Size = new System.Drawing.Size(126, 28);
            this.apr_update_btn.TabIndex = 1;
            this.apr_update_btn.Text = "Update";
            this.apr_update_btn.UseVisualStyleBackColor = false;
            this.apr_update_btn.Click += new System.EventHandler(this.apr_update_btn_Click);
            // 
            // ApRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ApRequests";
            this.Size = new System.Drawing.Size(750, 668);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apr_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView apr_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox apr_organname_cb;
        private System.Windows.Forms.ComboBox apr_bloodgroup_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button apr_clear_btn;
        private System.Windows.Forms.Button apr_delete_btn;
        private System.Windows.Forms.Button apr_update_btn;
        private System.Windows.Forms.ComboBox apr_requesttype_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox apr_status_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox apr_requestid_txt;
        private System.Windows.Forms.TextBox apr_userid_txt;
        private System.Windows.Forms.Button apr_loaddata_btn;
    }
}
