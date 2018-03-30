namespace studnt_pro
{
    partial class CreateStudentProfile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eno = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.TextBox();
            this.smstr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eno
            // 
            this.eno.Location = new System.Drawing.Point(213, 95);
            this.eno.Name = "eno";
            this.eno.Size = new System.Drawing.Size(100, 20);
            this.eno.TabIndex = 0;
            this.eno.TextChanged += new System.EventHandler(this.eno_TextChanged);
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(213, 183);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(100, 20);
            this.nam.TabIndex = 1;
            this.nam.TextChanged += new System.EventHandler(this.nam_TextChanged);
            // 
            // smstr
            // 
            this.smstr.Location = new System.Drawing.Point(213, 259);
            this.smstr.Name = "smstr";
            this.smstr.Size = new System.Drawing.Size(100, 20);
            this.smstr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "enrollment no";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "semester";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(408, 296);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 6;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // CreateStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 331);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smstr);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.eno);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "CreateStudentProfile";
            this.Text = "Create Student Profile";
            this.Load += new System.EventHandler(this.CreateStudentProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eno;
        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.TextBox smstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update;
    }
}