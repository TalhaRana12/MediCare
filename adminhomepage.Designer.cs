namespace HMS_SE_project
{
    partial class adminhomepage
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
            this.doctor_label = new System.Windows.Forms.Label();
            this.patient_label = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Location = new System.Drawing.Point(315, 312);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(39, 13);
            this.doctor_label.TabIndex = 32;
            this.doctor_label.Text = "Doctor";
            this.doctor_label.Click += new System.EventHandler(this.doctor_label_Click);
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Location = new System.Drawing.Point(642, 312);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(40, 13);
            this.patient_label.TabIndex = 33;
            this.patient_label.Text = "Patient";
            this.patient_label.Click += new System.EventHandler(this.patient_label_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HMS_SE_project.Properties.Resources.Patient1;
            this.pictureBox4.Location = new System.Drawing.Point(545, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(232, 219);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HMS_SE_project.Properties.Resources.doctor_1;
            this.pictureBox3.Location = new System.Drawing.Point(225, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 219);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(25, 377);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 44);
            this.logout.TabIndex = 29;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox2.Location = new System.Drawing.Point(46, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patient_label);
            this.Controls.Add(this.doctor_label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminhomepage";
            this.Text = "adminhomepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label doctor_label;
        private System.Windows.Forms.Label patient_label;
    }
}