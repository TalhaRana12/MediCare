using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_SE_project
{
    public partial class searchpatient : Form
    {
        public searchpatient()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form=new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            adminpatient form=new adminpatient();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form=new adminhomepage();
            form.Show();
            this.Hide();
        }

        private void searchpatient_btt_Click(object sender, EventArgs e)
        {
            string patient_id;
            patient_id = id.Text;
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            if (id.Text == "")
            {
                MessageBox.Show("Please enter the doctor id");
                return;
            }
            string querry = "select *from patient where id='" + patient_id + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idtextBox.Text = reader["id"].ToString();
                usernametextBox.Text = reader["username"].ToString();
                emailtextBox.Text = reader["email"].ToString();
                passwordtextBox.Text = reader["password"].ToString();
                agetextBox.Text = reader["age"].ToString();
                string gender = reader["gender"].ToString();
                if(gender =="Male")
                {
                    male_btt.Checked = true;
                }
                else if(gender =="Female")
                {
                    female_btt.Checked = true;
                }
                phonetextBox.Text = reader["phone_number"].ToString();
            }
            else
            {
                MessageBox.Show("Patient does not found");
                return;
            }
            con.Close();
        }
    }
}
