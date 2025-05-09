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
    public partial class managebill : Form
    {
        public managebill()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form = new adminhomepage();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            adminpatient form = new adminpatient();
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from = new signin();
            from.Show();
            this.Hide();
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {
            string id = idtextbox.Text;

            if (!string.IsNullOrEmpty(id))
            {
                string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "select * from patient where id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                emailtextBox.Text = reader["email"].ToString();
                                phonetextBox.Text = reader["phone_number"].ToString();
                            }
                            else
                            {
                                // Clear fields if no matching doctor found
                                emailtextBox.Text = "";
                                phonetextBox.Text = "";
                                MessageBox.Show("Patient does not found");
                            }
                        }
                    }
                }
            }
        }

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string id, email, phone;
            string payment;
            id=idtextbox.Text;
            email=emailtextBox.Text;
            phone=phonetextBox.Text;
            payment=paymenttextBox.Text;
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "insert into payment (patient_id,patient_email,phone,payment,paid) values('"+id+"','"+email+"','"+phone+"','"+payment+"','"+0+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Add the bill successfully");
        }
    }
}