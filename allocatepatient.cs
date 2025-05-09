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
    public partial class allocatepatient : Form
    {
        public allocatepatient()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            admindoctor form = new admindoctor();
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form = new signin();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage from = new adminhomepage();
            from.Show();
            this.Hide();
        }

        private void idtextbox_TextChanged(object sender, EventArgs e)
        {
            string id = didtextbox.Text;

            if (!string.IsNullOrEmpty(id))
            {
                string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "select * from doctor where id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                emailtextBox.Text = reader["email"].ToString();
                            }
                            else
                            {
                                // Clear fields if no matching doctor found
                                emailtextBox.Text = "";
                                MessageBox.Show("Doctor does not found");
                            }
                        }
                    }
                }
            }
        }

        private void pidtextBox_TextChanged(object sender, EventArgs e)
        {
            string id = pidtextBox.Text;

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
                                //usernametextBox.Text = reader["username"].ToString();
                                pemailtextBox.Text = reader["email"].ToString();
                                //passwordtextBox.Text = reader["password"].ToString();
                                //agetextBox.Text = reader["age"].ToString();
                                //string gender = reader["gender"].ToString();

                                //if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                                //{
                                //    male_btt.Checked = true;
                                //    female_btt.Checked = false;
                                //}
                                //else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                                //{
                                //    male_btt.Checked = false;
                                //    female_btt.Checked = true;
                                //}
                                //else
                                //{
                                //    // Handle cases where gender is not "Male" or "Female" 
                                //    male_btt.Checked = false;
                                //    female_btt.Checked = false;
                                //}
                                //phonetextBox.Text = reader["phone_number"].ToString();
                            }
                            else
                            {
                                // Clear fields if no matching doctor found

                                pemailtextBox.Text = "";
                                MessageBox.Show("Patient does not found");
                            }
                        }
                    }
                }
            }
        }

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string patient_id, patient_name, doctor_id, doctor_name;
            patient_id = pidtextBox.Text;
            patient_name = pemailtextBox.Text;
            doctor_id = didtextbox.Text;
            doctor_name = emailtextBox.Text;
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query= "insert into allocate(doctor_id,doctor_email,patient_id,patient_email) values('"+doctor_id+"','"+doctor_name+"','"+patient_id+"','"+patient_name+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Patient allocated successfully");
        }
    }
}