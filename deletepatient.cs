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

namespace HMS_SE_project
{
    public partial class deletepatient : Form
    {
        public deletepatient()
        {
            InitializeComponent();
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select *from patient";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            datagird.DataSource = table;
            conn.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form=new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            adminpatient adminpatient = new adminpatient();
            adminpatient.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage adminhomepage = new adminhomepage();
            adminhomepage.Show();
            this.Hide();
        }

        private void idtextbox_TextChanged(object sender, EventArgs e)
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
                                usernametextBox.Text = reader["username"].ToString();
                                emailtextBox.Text = reader["email"].ToString();
                                passwordtextBox.Text = reader["password"].ToString();
                                agetextBox.Text = reader["age"].ToString();
                                string gender = reader["gender"].ToString();

                                if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                                {
                                    male_btt.Checked = true;
                                    female_btt.Checked = false;
                                }
                                else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                                {
                                    male_btt.Checked = false;
                                    female_btt.Checked = true;
                                }
                                else
                                {
                                    // Handle cases where gender is not "Male" or "Female" 
                                    male_btt.Checked = false;
                                    female_btt.Checked = false;
                                }
                                phonetextBox.Text = reader["phone_number"].ToString();
                            }
                            else
                            {
                                // Clear fields if no matching doctor found
                                usernametextBox.Text = "";
                                emailtextBox.Text = "";
                                passwordtextBox.Text = "";
                                agetextBox.Text = "";
                                male_btt.Checked = false;
                                female_btt.Checked = false;
                                phonetextBox.Text = "";
                                MessageBox.Show("Patient does not found");
                            }
                        }
                    }
                }
            }
        }

        private void deletepatient_btt_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string id = idtextbox.Text;

            string query = "delete from patient where id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete query and get the number of affected rows

            if (rowsAffected > 0)
            {
                MessageBox.Show("Patient deleted successfully!");
            }
            else
            {
                MessageBox.Show("No patient found with the specified ID.");
            }
        }
    }
}
