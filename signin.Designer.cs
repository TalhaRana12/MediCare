namespace HMS_SE_project
{
    partial class signin
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
            this.signup = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signinemailtextbox = new System.Windows.Forms.TextBox();
            this.signinpasswordtextbox = new System.Windows.Forms.TextBox();
            this.admincheckbox = new System.Windows.Forms.CheckBox();
            this.doctorcheckbox = new System.Windows.Forms.CheckBox();
            this.patientcheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.singin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signup.Location = new System.Drawing.Point(480, 356);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(51, 13);
            this.signup.TabIndex = 9;
            this.signup.TabStop = true;
            this.signup.Text = "SIGN UP";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(352, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(239, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter your email id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter your password:";
            // 
            // signinemailtextbox
            // 
            this.signinemailtextbox.Location = new System.Drawing.Point(427, 102);
            this.signinemailtextbox.Name = "signinemailtextbox";
            this.signinemailtextbox.Size = new System.Drawing.Size(178, 20);
            this.signinemailtextbox.TabIndex = 13;
            this.signinemailtextbox.TextChanged += new System.EventHandler(this.signinemailtextbox_TextChanged);
            // 
            // signinpasswordtextbox
            // 
            this.signinpasswordtextbox.Location = new System.Drawing.Point(427, 168);
            this.signinpasswordtextbox.Name = "signinpasswordtextbox";
            this.signinpasswordtextbox.Size = new System.Drawing.Size(178, 20);
            this.signinpasswordtextbox.TabIndex = 14;
            this.signinpasswordtextbox.UseSystemPasswordChar = true;
            // 
            // admincheckbox
            // 
            this.admincheckbox.AutoSize = true;
            this.admincheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.admincheckbox.Location = new System.Drawing.Point(327, 250);
            this.admincheckbox.Name = "admincheckbox";
            this.admincheckbox.Size = new System.Drawing.Size(55, 17);
            this.admincheckbox.TabIndex = 15;
            this.admincheckbox.Text = "Admin";
            this.admincheckbox.UseVisualStyleBackColor = true;
            // 
            // doctorcheckbox
            // 
            this.doctorcheckbox.AutoSize = true;
            this.doctorcheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.doctorcheckbox.Location = new System.Drawing.Point(445, 250);
            this.doctorcheckbox.Name = "doctorcheckbox";
            this.doctorcheckbox.Size = new System.Drawing.Size(58, 17);
            this.doctorcheckbox.TabIndex = 16;
            this.doctorcheckbox.Text = "Doctor";
            this.doctorcheckbox.UseVisualStyleBackColor = true;
            // 
            // patientcheckbox
            // 
            this.patientcheckbox.AutoSize = true;
            this.patientcheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.patientcheckbox.Location = new System.Drawing.Point(546, 250);
            this.patientcheckbox.Name = "patientcheckbox";
            this.patientcheckbox.Size = new System.Drawing.Size(59, 17);
            this.patientcheckbox.TabIndex = 17;
            this.patientcheckbox.Text = "Patient";
            this.patientcheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(383, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox2.Location = new System.Drawing.Point(40, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // singin
            // 
            this.singin.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.singin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singin.ForeColor = System.Drawing.Color.Transparent;
            this.singin.Location = new System.Drawing.Point(406, 294);
            this.singin.Name = "singin";
            this.singin.Size = new System.Drawing.Size(125, 44);
            this.singin.TabIndex = 7;
            this.singin.Text = "LOG IN";
            this.singin.UseVisualStyleBackColor = true;
            this.singin.Click += new System.EventHandler(this.singin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientcheckbox);
            this.Controls.Add(this.doctorcheckbox);
            this.Controls.Add(this.admincheckbox);
            this.Controls.Add(this.signinpasswordtextbox);
            this.Controls.Add(this.signinemailtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.singin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "signin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button singin;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signinemailtextbox;
        private System.Windows.Forms.TextBox signinpasswordtextbox;
        private System.Windows.Forms.CheckBox admincheckbox;
        private System.Windows.Forms.CheckBox doctorcheckbox;
        private System.Windows.Forms.CheckBox patientcheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

