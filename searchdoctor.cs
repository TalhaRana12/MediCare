using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_SE_project
{
    public partial class searchdoctor : Form
    {
        public searchdoctor()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form= new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            admindoctor from= new admindoctor();
            from.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form= new adminhomepage();
            form.Show();
            this.Hide();
        }

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string doctor_id;
            doctor_id = id.Text;
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            if(id.Text=="")
            {
                MessageBox.Show("Please enter the doctor id");
                return;
            }
            string querry = "select *from doctor where id='" + doctor_id + "'";
            SqlCommand cmd = new SqlCommand(querry,con);    
            var reader= cmd.ExecuteReader();
            if (reader.Read())
            {
                idtextbox.Text = reader["id"].ToString();
                emailtextBox.Text = reader["email"].ToString();
                passwordtextBox.Text = reader["password"].ToString();
                spetextBox.Text = reader["specialization"].ToString();
            }
            else
            {
                MessageBox.Show("Doctor does not found");
                return;
            }
            con.Close();
        }
    }
}
