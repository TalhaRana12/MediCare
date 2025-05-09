namespace HMS_SE_project
{
    partial class allocatepatient
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.didtextbox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.pidtextBox = new System.Windows.Forms.TextBox();
            this.pemailtextBox = new System.Windows.Forms.TextBox();
            this.Updatepatient_btt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox2.Image = global::HMS_SE_project.Properties.Resources.hospital_icon;
            this.pictureBox2.Location = new System.Drawing.Point(44, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 512);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.Location = new System.Drawing.Point(12, 333);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(125, 44);
            this.backbutton.TabIndex = 34;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Allocate Patient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(244, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Enter doctor id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(244, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Enter doctor email id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(244, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Enter patient id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(244, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Enter patient email id:";
            // 
            // didtextbox
            // 
            this.didtextbox.Location = new System.Drawing.Point(441, 113);
            this.didtextbox.Name = "didtextbox";
            this.didtextbox.Size = new System.Drawing.Size(220, 20);
            this.didtextbox.TabIndex = 45;
            this.didtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(441, 162);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(220, 20);
            this.emailtextBox.TabIndex = 46;
            // 
            // pidtextBox
            // 
            this.pidtextBox.Location = new System.Drawing.Point(441, 210);
            this.pidtextBox.Name = "pidtextBox";
            this.pidtextBox.Size = new System.Drawing.Size(220, 20);
            this.pidtextBox.TabIndex = 47;
            this.pidtextBox.TextChanged += new System.EventHandler(this.pidtextBox_TextChanged);
            // 
            // pemailtextBox
            // 
            this.pemailtextBox.Location = new System.Drawing.Point(441, 253);
            this.pemailtextBox.Name = "pemailtextBox";
            this.pemailtextBox.Size = new System.Drawing.Size(220, 20);
            this.pemailtextBox.TabIndex = 48;
            // 
            // Updatepatient_btt
            // 
            this.Updatepatient_btt.BackgroundImage = global::HMS_SE_project.Properties.Resources.bg;
            this.Updatepatient_btt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatepatient_btt.ForeColor = System.Drawing.Color.Transparent;
            this.Updatepatient_btt.Location = new System.Drawing.Point(384, 303);
            this.Updatepatient_btt.Name = "Updatepatient_btt";
            this.Updatepatient_btt.Size = new System.Drawing.Size(125, 44);
            this.Updatepatient_btt.TabIndex = 50;
            this.Updatepatient_btt.Text = "Allocate";
            this.Updatepatient_btt.UseVisualStyleBackColor = true;
            this.Updatepatient_btt.Click += new System.EventHandler(this.Updatepatient_btt_Click);
            // 
            // allocatepatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Updatepatient_btt);
            this.Controls.Add(this.pemailtextBox);
            this.Controls.Add(this.pidtextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.didtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "allocatepatient";
            this.Text = "allocatepatient";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox didtextbox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox pidtextBox;
        private System.Windows.Forms.TextBox pemailtextBox;
        private System.Windows.Forms.Button Updatepatient_btt;
    }
}