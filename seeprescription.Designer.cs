namespace HMS_SE_project
{
    partial class seeprescription
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.diseasetextBox = new System.Windows.Forms.TextBox();
            this.medicinetextBox = new System.Windows.Forms.TextBox();
            this.daytextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox2.Location = new System.Drawing.Point(46, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 452);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(12, 394);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 44);
            this.logout.TabIndex = 35;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.Location = new System.Drawing.Point(12, 328);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(125, 44);
            this.backbutton.TabIndex = 36;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(324, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 39);
            this.label4.TabIndex = 42;
            this.label4.Text = "See Prescription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(224, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doctor id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(224, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Disease";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(224, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Medicine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(224, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "No of days:";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(427, 113);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(218, 20);
            this.idtextBox.TabIndex = 51;
            // 
            // diseasetextBox
            // 
            this.diseasetextBox.Location = new System.Drawing.Point(427, 184);
            this.diseasetextBox.Name = "diseasetextBox";
            this.diseasetextBox.Size = new System.Drawing.Size(218, 20);
            this.diseasetextBox.TabIndex = 53;
            // 
            // medicinetextBox
            // 
            this.medicinetextBox.Location = new System.Drawing.Point(427, 250);
            this.medicinetextBox.Name = "medicinetextBox";
            this.medicinetextBox.Size = new System.Drawing.Size(218, 20);
            this.medicinetextBox.TabIndex = 54;
            // 
            // daytextBox
            // 
            this.daytextBox.Location = new System.Drawing.Point(427, 328);
            this.daytextBox.Name = "daytextBox";
            this.daytextBox.Size = new System.Drawing.Size(218, 20);
            this.daytextBox.TabIndex = 55;
            // 
            // seeprescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daytextBox);
            this.Controls.Add(this.medicinetextBox);
            this.Controls.Add(this.diseasetextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "seeprescription";
            this.Text = "seeprescription";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox diseasetextBox;
        private System.Windows.Forms.TextBox medicinetextBox;
        private System.Windows.Forms.TextBox daytextBox;
    }
}