namespace OrganDonationApplication_1._0
{
    partial class UpOrgans
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
            this.upo_organname_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upo_bloodgroup_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.upo_search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upo_dataGridView = new System.Windows.Forms.DataGridView();
            this.upo_load_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upo_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upo_load_btn);
            this.panel1.Controls.Add(this.upo_organname_cb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.upo_bloodgroup_cb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.upo_search_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.upo_dataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 418);
            this.panel1.TabIndex = 0;
            // 
            // upo_organname_cb
            // 
            this.upo_organname_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upo_organname_cb.FormattingEnabled = true;
            this.upo_organname_cb.Items.AddRange(new object[] {
            "Heart",
            "Liver",
            "Lungs",
            "Kidneys",
            "Pancreas",
            "Small Bowel"});
            this.upo_organname_cb.Location = new System.Drawing.Point(277, 341);
            this.upo_organname_cb.Name = "upo_organname_cb";
            this.upo_organname_cb.Size = new System.Drawing.Size(64, 23);
            this.upo_organname_cb.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(181, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Organ Name:";
            // 
            // upo_bloodgroup_cb
            // 
            this.upo_bloodgroup_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upo_bloodgroup_cb.FormattingEnabled = true;
            this.upo_bloodgroup_cb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.upo_bloodgroup_cb.Location = new System.Drawing.Point(101, 341);
            this.upo_bloodgroup_cb.Name = "upo_bloodgroup_cb";
            this.upo_bloodgroup_cb.Size = new System.Drawing.Size(64, 23);
            this.upo_bloodgroup_cb.TabIndex = 23;
            this.upo_bloodgroup_cb.SelectedIndexChanged += new System.EventHandler(this.up_bloodgroup_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Blood Group:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // upo_search_btn
            // 
            this.upo_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.upo_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upo_search_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upo_search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.upo_search_btn.Location = new System.Drawing.Point(382, 339);
            this.upo_search_btn.Name = "upo_search_btn";
            this.upo_search_btn.Size = new System.Drawing.Size(90, 28);
            this.upo_search_btn.TabIndex = 2;
            this.upo_search_btn.Text = "Search";
            this.upo_search_btn.UseVisualStyleBackColor = false;
            this.upo_search_btn.Click += new System.EventHandler(this.upo_search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organs:";
            // 
            // upo_dataGridView
            // 
            this.upo_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.upo_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upo_dataGridView.Location = new System.Drawing.Point(9, 24);
            this.upo_dataGridView.Name = "upo_dataGridView";
            this.upo_dataGridView.Size = new System.Drawing.Size(463, 309);
            this.upo_dataGridView.TabIndex = 0;
            // 
            // upo_load_btn
            // 
            this.upo_load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.upo_load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upo_load_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upo_load_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.upo_load_btn.Location = new System.Drawing.Point(9, 375);
            this.upo_load_btn.Name = "upo_load_btn";
            this.upo_load_btn.Size = new System.Drawing.Size(463, 28);
            this.upo_load_btn.TabIndex = 26;
            this.upo_load_btn.Text = "Reload";
            this.upo_load_btn.UseVisualStyleBackColor = false;
            this.upo_load_btn.Click += new System.EventHandler(this.upo_load_btn_Click);
            // 
            // UpOrgans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Name = "UpOrgans";
            this.Size = new System.Drawing.Size(541, 521);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upo_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView upo_dataGridView;
        private System.Windows.Forms.Button upo_search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox upo_organname_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox upo_bloodgroup_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upo_load_btn;
    }
}
