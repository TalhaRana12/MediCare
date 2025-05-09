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
    public partial class updatepatient : Form
    {
        public updatepatient()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form = new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            adminpatient form = new adminpatient();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form = new adminhomepage();
            form.Show();
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
                                female_btt .Checked = false;
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
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string username, email, password, phone_number, gender;
            string age,id;
            id=idtextbox.Text;
            username = usernametextBox.Text;
            email = emailtextBox.Text;
            password = passwordtextBox.Text;
            phone_number = phonetextBox.Text;
            age = agetextBox.Text;
            gender = "";
            if (male_btt.Checked == true)
            {
                gender = "Male";
            }
            else if (female_btt.Checked == true)
            {
                gender = "Female";
            }
            // to check all the data is entered not of them are empty
            if (usernametextBox.Text == "" || emailtextBox.Text == "" || passwordtextBox.Text == "" || phonetextBox.Text == "" || agetextBox.Text == "" || (!male_btt.Checked && !female_btt.Checked))
            {
                MessageBox.Show("Please Fill all the data.");
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
                        emailtextBox.Focus();
                        return;
                    }
                }
                catch (FormatException) // in case format of the email is not correct
                {
                    MessageBox.Show("Invalid Email");
                    emailtextBox.Focus();
                    return;
                }
            }
            if (phonetextBox.Text.Length != 11) // in case when the phone is less than or greater than 11 digits
            {
                MessageBox.Show("Phone number must be 11 digit.");
                phonetextBox.Clear();
                phonetextBox.Focus();
                return;
            }
            string updateQuery = "UPDATE patient SET username=@username,email = @email, password = @password, age=@age,gender=@gender,phone_number=@phone_number WHERE id = @id";
            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
            {
                cmdUpdate.Parameters.AddWithValue("@id", id);
                cmdUpdate.Parameters.AddWithValue("@username", username);
                cmdUpdate.Parameters.AddWithValue("@email", email);
                cmdUpdate.Parameters.AddWithValue("@password", password);
                cmdUpdate.Parameters.AddWithValue("@age", age);
                cmdUpdate.Parameters.AddWithValue("@gender",gender);
                cmdUpdate.Parameters.AddWithValue("@phone_number", phone_number);

                int rowsAffected = cmdUpdate.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated successfully");
                }
                con.Close();
            }
        }
    }
}