namespace HMS_SE_project
{
    partial class addpatient
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.male_btt = new System.Windows.Forms.RadioButton();
            this.female_btt = new System.Windows.Forms.RadioButton();
            this.Addpatient_btt = new System.Windows.Forms.Button();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.datagird = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagird)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox2.Location = new System.Drawing.Point(46, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 514);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(25, 422);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 44);
            this.logout.TabIndex = 31;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.Location = new System.Drawing.Point(25, 358);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(125, 44);
            this.backbutton.TabIndex = 32;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(378, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Add Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(216, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Enter your username id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(216, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Enter your email id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(216, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Enter your password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(216, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Enter your age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(216, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Enter your phone number:";
            // 
            // male_btt
            // 
            this.male_btt.AutoSize = true;
            this.male_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.male_btt.Location = new System.Drawing.Point(331, 269);
            this.male_btt.Name = "male_btt";
            this.male_btt.Size = new System.Drawing.Size(47, 17);
            this.male_btt.TabIndex = 40;
            this.male_btt.TabStop = true;
            this.male_btt.Text = "male";
            this.male_btt.UseVisualStyleBackColor = true;
            // 
            // female_btt
            // 
            this.female_btt.AutoSize = true;
            this.female_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.female_btt.Location = new System.Drawing.Point(514, 269);
            this.female_btt.Name = "female_btt";
            this.female_btt.Size = new System.Drawing.Size(59, 17);
            this.female_btt.TabIndex = 41;
            this.female_btt.TabStop = true;
            this.female_btt.Text = "Female";
            this.female_btt.UseVisualStyleBackColor = true;
            // 
            // Addpatient_btt
            // 
            this.Addpatient_btt.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.Addpatient_btt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addpatient_btt.ForeColor = System.Drawing.Color.Transparent;
            this.Addpatient_btt.Location = new System.Drawing.Point(397, 308);
            this.Addpatient_btt.Name = "Addpatient_btt";
            this.Addpatient_btt.Size = new System.Drawing.Size(125, 44);
            this.Addpatient_btt.TabIndex = 42;
            this.Addpatient_btt.Text = "ADD";
            this.Addpatient_btt.UseVisualStyleBackColor = true;
            this.Addpatient_btt.Click += new System.EventHandler(this.Addpatient_btt_Click);
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(445, 92);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(214, 20);
            this.usernametextBox.TabIndex = 43;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(445, 165);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(214, 20);
            this.passwordtextBox.TabIndex = 44;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(445, 127);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(214, 20);
            this.emailtextBox.TabIndex = 45;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(445, 202);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(214, 20);
            this.agetextBox.TabIndex = 47;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(445, 234);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(214, 20);
            this.phonetextBox.TabIndex = 48;
            // 
            // datagird
            // 
            this.datagird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagird.Location = new System.Drawing.Point(171, 358);
            this.datagird.Name = "datagird";
            this.datagird.Size = new System.Drawing.Size(628, 137);
            this.datagird.TabIndex = 49;
            // 
            // addpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.datagird);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.agetextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.Addpatient_btt);
            this.Controls.Add(this.female_btt);
            this.Controls.Add(this.male_btt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addpatient";
            this.Text = "addpatient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton male_btt;
        private System.Windows.Forms.RadioButton female_btt;
        private System.Windows.Forms.Button Addpatient_btt;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.DataGridView datagird;
    }
}