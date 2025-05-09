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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void singin_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string email = signinemailtextbox.Text;
            string password = signinpasswordtextbox.Text;
            string query = "";
            string usertype = "";
            if (signinemailtextbox.Text == "" || signinpasswordtextbox.Text == "" || (admincheckbox.Checked == false && doctorcheckbox.Checked == false && patientcheckbox.Checked == false))
            {
                MessageBox.Show("Please fill all the data first");
                signinemailtextbox.Focus();
                return;
            }
            if (admincheckbox.Checked == true && doctorcheckbox.Checked == true && patientcheckbox.Checked == true)
            {
                MessageBox.Show("Please select only one option.");
                return;
            }
            if ((admincheckbox.Checked == true && doctorcheckbox.Checked == true) || (admincheckbox.Checked == true && patientcheckbox.Checked == true) || (doctorcheckbox.Checked == true && patientcheckbox.Checked == true))
            {
                MessageBox.Show("Please select only one option");
                return;
            }
            if (email != "")// for checking whether the email is in correct format or not
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    // checking whether the spelling of the domain is correct or not
                    string[] commonDomains = { "gmail.com", "yahoo.com", "outlook.com", "hotmail.com", "icloud.com" };
                    string domain = email.Split('@')[1];

                    if (!commonDomains.Contains(domain))
                    {
                        MessageBox.Show("Invalid or uncommon email domain. Please check your email spelling.");
                        signinemailtextbox.Focus();
                        return;
                    }
                }
                catch (FormatException) // in case format of the email is not correct
                {
                    MessageBox.Show("Invalid Email");
                    signinemailtextbox.Focus();
                    return;
                }
            }
            if (admincheckbox.Checked)
            {
                query = "select * from admin where email = '" + email + "' and password = '" + password + "'";
                usertype = "admin";
            }
            else if (doctorcheckbox.Checked)
            {
                query = "select * from doctor where email = '" + email + "' and password = '" + password + "'";
                usertype = "doctor";
            }
            else if (patientcheckbox.Checked)
            {
                query = "select * from patient where email = '" + email + "' and password = '" + password + "'";
                usertype = "patient";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            // user type
            if (reader.Read())
            {
                //close connections
                con.Close();
                if (usertype == "admin")
                {
                    adminhomepage form1 = new adminhomepage();
                    form1.Show();
                    this.Hide();
                }
                else if (usertype == "doctor")
                {
                    string connection= "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            conn.Open();

                            string email1 = signinemailtextbox.Text;
                            string password1 = signinpasswordtextbox.Text;
                            string query1 = "SELECT id FROM doctor WHERE email = @email AND password = @password";

                            using (SqlCommand command = new SqlCommand(query1, conn))
                            {
                                command.Parameters.AddWithValue("@email", email1);
                                command.Parameters.AddWithValue("@password", password1);

                                using (SqlDataReader reader1 = command.ExecuteReader())
                                {
                                    if (reader1.Read())
                                    {
                                        // Assuming 'id' is a string in your database
                                        string doctorID = reader1["id"].ToString();
                                        LoggedDoctor.ID = doctorID; // Store the ID in the string variable
                                    }
                                    else
                                    {
                                        // Handle the case where no doctor is found (e.g., invalid credentials)
                                        MessageBox.Show("Invalid email or password.");
                                        // Consider clearing login fields or taking other appropriate actions
                                    }
                                }
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        // Log the error for debugging purposes
                    }
                    doctorhomepage form2 = new doctorhomepage();
                    form2.Show();
                    this.Hide();
                }
                else if(usertype =="patient")
                {
                    string connection1 = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
                    try
                    {
                        using (SqlConnection conn1 = new SqlConnection(connection1))
                        {
                            conn1.Open();

                            string email2 = signinemailtextbox.Text;
                            string password2 = signinpasswordtextbox.Text;
                            string query2 = "SELECT id FROM patient WHERE email = @email AND password = @password";

                            using (SqlCommand command = new SqlCommand(query, conn1))
                            {
                                command.Parameters.AddWithValue("@email", email2);
                                command.Parameters.AddWithValue("@password", password2);

                                using (SqlDataReader reader2 = command.ExecuteReader())
                                {
                                    if (reader2.Read())
                                    {
                                        // Assuming 'id' is a string in your database
                                        string ID = reader2["id"].ToString();
                                        LoggedPatient.ID = ID; // Store the ID in the string variable
                                    }
                                    else
                                    {
                                        // Handle the case where no doctor is found (e.g., invalid credentials)
                                        MessageBox.Show("Invalid email or password.");
                                        // Consider clearing login fields or taking other appropriate actions
                                    }
                                }
                            }
                            conn1.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        // Log the error for debugging purposes
                    }
                    patienthomepage from=new patienthomepage();
                    from.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or Password");
                signinemailtextbox.Clear();
                signinpasswordtextbox.Clear();
                signinemailtextbox.Focus();
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup form = new signup();
            form.Show();
            this.Hide();
        }

        private void signinemailtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
