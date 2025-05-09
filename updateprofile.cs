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
    public partial class updateprofile : Form
    {
        public updateprofile()
        {
            InitializeComponent();
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "select * from patient where id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", LoggedPatient.ID);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            patienthomepage from=new patienthomepage();
            from.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            patienthomepage from = new patienthomepage();
            from.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from= new signin();
            from.Show();
            this.Hide();
        }

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string updateQuery = "UPDATE patient SET " +
                        "username = @username, " +
                        "email = @email, " +
                        "age = @age, " +
                        "gender = @gender, " +
                        "phone_number = @phone " +
                        "WHERE id = @patientID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", usernametextBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailtextBox.Text);
                        cmd.Parameters.AddWithValue("@age", agetextBox.Text);

                        // Determine gender based on checked radio button
                        string gender = male_btt.Checked ? "Male" : "Female";
                        cmd.Parameters.AddWithValue("@gender", gender);

                        cmd.Parameters.AddWithValue("@phone", phonetextBox.Text);
                        cmd.Parameters.AddWithValue("@patientID", LoggedPatient.ID); // Assuming LoggedPatient.ID is available

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient information updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update patient information.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

