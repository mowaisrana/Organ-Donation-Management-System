using System;

namespace OrganDonationApplication_1._0
{
    partial class UpDonate
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
            this.up_type_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.up_organname_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.up_bloodgroup_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.up_press_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.up_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.up_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.up_type_cb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.up_organname_cb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.up_bloodgroup_cb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.up_press_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.up_dataGridView);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 405);
            this.panel1.TabIndex = 1;
            // 
            // up_type_cb
            // 
            this.up_type_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_type_cb.FormattingEnabled = true;
            this.up_type_cb.Items.AddRange(new object[] {
            "Organ",
            "Blood"});
            this.up_type_cb.Location = new System.Drawing.Point(393, 300);
            this.up_type_cb.Name = "up_type_cb";
            this.up_type_cb.Size = new System.Drawing.Size(80, 24);
            this.up_type_cb.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(344, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // up_organname_cb
            // 
            this.up_organname_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_organname_cb.FormattingEnabled = true;
            this.up_organname_cb.Items.AddRange(new object[] {
            "Heart",
            "Liver",
            "Lungs",
            "Kidneys",
            "Pancreas",
            "Small Bowel"});
            this.up_organname_cb.Location = new System.Drawing.Point(104, 316);
            this.up_organname_cb.Name = "up_organname_cb";
            this.up_organname_cb.Size = new System.Drawing.Size(79, 23);
            this.up_organname_cb.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Organ Name:";
            // 
            // up_bloodgroup_cb
            // 
            this.up_bloodgroup_cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_bloodgroup_cb.FormattingEnabled = true;
            this.up_bloodgroup_cb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.up_bloodgroup_cb.Location = new System.Drawing.Point(103, 286);
            this.up_bloodgroup_cb.Name = "up_bloodgroup_cb";
            this.up_bloodgroup_cb.Size = new System.Drawing.Size(80, 24);
            this.up_bloodgroup_cb.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Blood Group:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // up_press_btn
            // 
            this.up_press_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.up_press_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_press_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_press_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.up_press_btn.Location = new System.Drawing.Point(7, 361);
            this.up_press_btn.Name = "up_press_btn";
            this.up_press_btn.Size = new System.Drawing.Size(472, 28);
            this.up_press_btn.TabIndex = 2;
            this.up_press_btn.Text = "Press Btton";
            this.up_press_btn.UseVisualStyleBackColor = false;
            this.up_press_btn.Click += new System.EventHandler(this.up_press_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Donate / Request:";
            // 
            // up_dataGridView
            // 
            this.up_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.up_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.up_dataGridView.Location = new System.Drawing.Point(7, 24);
            this.up_dataGridView.Name = "up_dataGridView";
            this.up_dataGridView.Size = new System.Drawing.Size(472, 237);
            this.up_dataGridView.TabIndex = 0;
            // 
            // UpDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Name = "UpDonate";
            this.Size = new System.Drawing.Size(541, 521);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.up_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button up_press_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView up_dataGridView;
        private System.Windows.Forms.ComboBox up_bloodgroup_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox up_organname_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox up_type_cb;
    }
}
