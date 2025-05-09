namespace HMS_SE_project
{
    partial class delete_doctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.spetextBox = new System.Windows.Forms.TextBox();
            this.datagird = new System.Windows.Forms.DataGridView();
            this.Updatepatient_btt = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(347, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Delete Doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(276, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Enter id:";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(479, 101);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(220, 20);
            this.idtextbox.TabIndex = 46;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(276, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Enter email id:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(479, 136);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(220, 20);
            this.emailtextBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(276, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Enter  passoword:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(276, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Enter specialization:";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(479, 207);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(220, 20);
            this.passwordtextBox.TabIndex = 51;
            // 
            // spetextBox
            // 
            this.spetextBox.Location = new System.Drawing.Point(479, 170);
            this.spetextBox.Name = "spetextBox";
            this.spetextBox.Size = new System.Drawing.Size(220, 20);
            this.spetextBox.TabIndex = 52;
            // 
            // datagird
            // 
            this.datagird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagird.Location = new System.Drawing.Point(234, 300);
            this.datagird.Name = "datagird";
            this.datagird.Size = new System.Drawing.Size(465, 138);
            this.datagird.TabIndex = 54;
            // 
            // Updatepatient_btt
            // 
            this.Updatepatient_btt.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.Updatepatient_btt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatepatient_btt.ForeColor = System.Drawing.Color.Transparent;
            this.Updatepatient_btt.Location = new System.Drawing.Point(404, 251);
            this.Updatepatient_btt.Name = "Updatepatient_btt";
            this.Updatepatient_btt.Size = new System.Drawing.Size(125, 44);
            this.Updatepatient_btt.TabIndex = 53;
            this.Updatepatient_btt.Text = "Delete";
            this.Updatepatient_btt.UseVisualStyleBackColor = true;
            this.Updatepatient_btt.Click += new System.EventHandler(this.Updatepatient_btt_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(21, 394);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 44);
            this.logout.TabIndex = 36;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.Location = new System.Drawing.Point(21, 332);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(125, 44);
            this.backbutton.TabIndex = 35;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox1.Location = new System.Drawing.Point(54, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 448);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // delete_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagird);
            this.Controls.Add(this.Updatepatient_btt);
            this.Controls.Add(this.spetextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "delete_doctor";
            this.Text = "delete_doctor";
            ((System.ComponentModel.ISupportInitialize)(this.datagird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox spetextBox;
        private System.Windows.Forms.Button Updatepatient_btt;
        private System.Windows.Forms.DataGridView datagird;
    }
}