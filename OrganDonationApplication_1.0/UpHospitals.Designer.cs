namespace OrganDonationApplication_1._0
{
    partial class UpHospitals
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
            this.uph_load_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uph_search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uph_dataGridView = new System.Windows.Forms.DataGridView();
            this.uph_name_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uph_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uph_name_txt);
            this.panel1.Controls.Add(this.uph_load_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uph_search_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uph_dataGridView);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 405);
            this.panel1.TabIndex = 2;
            // 
            // uph_load_btn
            // 
            this.uph_load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uph_load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uph_load_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uph_load_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uph_load_btn.Location = new System.Drawing.Point(400, 351);
            this.uph_load_btn.Name = "uph_load_btn";
            this.uph_load_btn.Size = new System.Drawing.Size(74, 28);
            this.uph_load_btn.TabIndex = 26;
            this.uph_load_btn.Text = "Reload";
            this.uph_load_btn.UseVisualStyleBackColor = false;
            this.uph_load_btn.Click += new System.EventHandler(this.uph_load_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hospital \r\nName:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uph_search_btn
            // 
            this.uph_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uph_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uph_search_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uph_search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uph_search_btn.Location = new System.Drawing.Point(320, 351);
            this.uph_search_btn.Name = "uph_search_btn";
            this.uph_search_btn.Size = new System.Drawing.Size(74, 28);
            this.uph_search_btn.TabIndex = 2;
            this.uph_search_btn.Text = "Search";
            this.uph_search_btn.UseVisualStyleBackColor = false;
            this.uph_search_btn.Click += new System.EventHandler(this.uph_search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospitals:";
            // 
            // uph_dataGridView
            // 
            this.uph_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.uph_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uph_dataGridView.Location = new System.Drawing.Point(9, 24);
            this.uph_dataGridView.Name = "uph_dataGridView";
            this.uph_dataGridView.Size = new System.Drawing.Size(465, 309);
            this.uph_dataGridView.TabIndex = 0;
            // 
            // uph_name_txt
            // 
            this.uph_name_txt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uph_name_txt.Location = new System.Drawing.Point(67, 351);
            this.uph_name_txt.Name = "uph_name_txt";
            this.uph_name_txt.Size = new System.Drawing.Size(247, 26);
            this.uph_name_txt.TabIndex = 27;
            // 
            // UpHospitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Name = "UpHospitals";
            this.Size = new System.Drawing.Size(541, 521);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uph_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uph_load_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uph_search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uph_dataGridView;
        private System.Windows.Forms.TextBox uph_name_txt;
    }
}
