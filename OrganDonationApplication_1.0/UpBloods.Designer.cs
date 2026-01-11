namespace OrganDonationApplication_1._0
{
    partial class UpBloods
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
            this.upb_load_btn = new System.Windows.Forms.Button();
            this.upb_bloodgroup_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.upb_search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upb_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upb_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upb_load_btn);
            this.panel1.Controls.Add(this.upb_bloodgroup_cb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.upb_search_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.upb_dataGridView);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 405);
            this.panel1.TabIndex = 1;
            // 
            // upb_load_btn
            // 
            this.upb_load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.upb_load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upb_load_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upb_load_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.upb_load_btn.Location = new System.Drawing.Point(382, 347);
            this.upb_load_btn.Name = "upb_load_btn";
            this.upb_load_btn.Size = new System.Drawing.Size(90, 28);
            this.upb_load_btn.TabIndex = 26;
            this.upb_load_btn.Text = "Reload";
            this.upb_load_btn.UseVisualStyleBackColor = false;
            this.upb_load_btn.Click += new System.EventHandler(this.upb_load_btn_Click_1);
            // 
            // upb_bloodgroup_cb
            // 
            this.upb_bloodgroup_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upb_bloodgroup_cb.FormattingEnabled = true;
            this.upb_bloodgroup_cb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.upb_bloodgroup_cb.Location = new System.Drawing.Point(101, 351);
            this.upb_bloodgroup_cb.Name = "upb_bloodgroup_cb";
            this.upb_bloodgroup_cb.Size = new System.Drawing.Size(135, 24);
            this.upb_bloodgroup_cb.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Blood Group:";
            // 
            // upb_search_btn
            // 
            this.upb_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.upb_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upb_search_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upb_search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.upb_search_btn.Location = new System.Drawing.Point(255, 348);
            this.upb_search_btn.Name = "upb_search_btn";
            this.upb_search_btn.Size = new System.Drawing.Size(90, 28);
            this.upb_search_btn.TabIndex = 2;
            this.upb_search_btn.Text = "Search";
            this.upb_search_btn.UseVisualStyleBackColor = false;
            this.upb_search_btn.Click += new System.EventHandler(this.upb_search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood:";
            // 
            // upb_dataGridView
            // 
            this.upb_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upb_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upb_dataGridView.Location = new System.Drawing.Point(9, 24);
            this.upb_dataGridView.Name = "upb_dataGridView";
            this.upb_dataGridView.Size = new System.Drawing.Size(463, 309);
            this.upb_dataGridView.TabIndex = 0;
            // 
            // UpBloods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Name = "UpBloods";
            this.Size = new System.Drawing.Size(541, 521);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upb_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button upb_load_btn;
        private System.Windows.Forms.ComboBox upb_bloodgroup_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upb_search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView upb_dataGridView;
    }
}
