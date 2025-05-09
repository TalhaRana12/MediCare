namespace HMS_SE_project
{
    partial class managebill
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
            this.backbutton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.paymenttextBox = new System.Windows.Forms.TextBox();
            this.Updatepatient_btt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox2.Location = new System.Drawing.Point(53, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 512);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.Location = new System.Drawing.Point(12, 318);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(125, 44);
            this.backbutton.TabIndex = 35;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(12, 385);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 44);
            this.logout.TabIndex = 36;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(347, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Manage Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(248, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Enter patient id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(248, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Enter patient email id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(248, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Enter your phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(248, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Enter payment:";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(468, 113);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(220, 20);
            this.idtextbox.TabIndex = 48;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextBox_TextChanged);
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(468, 171);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(220, 20);
            this.emailtextBox.TabIndex = 49;
            // 
            // phonetextBox
            // 
            this.phonetextBox.Location = new System.Drawing.Point(468, 225);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(220, 20);
            this.phonetextBox.TabIndex = 50;
            // 
            // paymenttextBox
            // 
            this.paymenttextBox.Location = new System.Drawing.Point(468, 274);
            this.paymenttextBox.Name = "paymenttextBox";
            this.paymenttextBox.Size = new System.Drawing.Size(220, 20);
            this.paymenttextBox.TabIndex = 51;
            // 
            // Updatepatient_btt
            // 
            this.Updatepatient_btt.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.Updatepatient_btt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatepatient_btt.ForeColor = System.Drawing.Color.Transparent;
            this.Updatepatient_btt.Location = new System.Drawing.Point(394, 339);
            this.Updatepatient_btt.Name = "Updatepatient_btt";
            this.Updatepatient_btt.Size = new System.Drawing.Size(125, 44);
            this.Updatepatient_btt.TabIndex = 52;
            this.Updatepatient_btt.Text = "Add payment";
            this.Updatepatient_btt.UseVisualStyleBackColor = true;
            this.Updatepatient_btt.Click += new System.EventHandler(this.Updatepatient_btt_Click);
            // 
            // managebill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatepatient_btt);
            this.Controls.Add(this.paymenttextBox);
            this.Controls.Add(this.phonetextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "managebill";
            this.Text = "managebill";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.TextBox paymenttextBox;
        private System.Windows.Forms.Button Updatepatient_btt;
    }
}