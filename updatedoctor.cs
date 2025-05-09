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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMS_SE_project
{
    public partial class updatedoctor : Form
    {
        public updatedoctor()
        {
            InitializeComponent();
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select *from doctor";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            datagird.DataSource = table;
            conn.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            admindoctor form = new admindoctor();
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form= new signin();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form= new adminhomepage();
            form.Show();
            this.Hide();
        }

        private void updatedoctor_Click(object sender, EventArgs e)
        {
            //string id;
            //id = idtextbox.Text;
            //string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            //SqlConnection con = new SqlConnection(connectionstring);
            //con.Open();
            //if (idtextbox.Text == "")
            //{
            //    MessageBox.Show("Please enter the doctor id");
            //    return;
            //}
            //string querry = "select *from patient where id='" + id + "'";
            //SqlCommand cmd = new SqlCommand(querry, con);
            //var reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    idtextbox.Text = reader["id"].ToString();
            //    emailtextBox.Text = reader["email"].ToString();
            //    passwordtextBox.Text = reader["password"].ToString();
            //    spetextBox.Text = reader["specialization"].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Doctor does not found");
            //    return;
            //}
            //con.Close();
        }

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string email, password, special;
            string id;
            id = idtextbox.Text;
            email = emailtextBox.Text;
            password = passwordtextBox.Text;
            special = spetextBox.Text;
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            if (emailtextBox.Text == "" || passwordtextBox.Text == "" || spetextBox.Text == "")
            {
                MessageBox.Show("Please all the information");
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
            //string query1 = "select * from doctor where email = '" + email + "'";
            //SqlCommand cmd1 = new SqlCommand(query1, con);
            //SqlDataReader reader = cmd1.ExecuteReader();
            //if (reader.Read())
            //{
            //    MessageBox.Show(" This Email already has an account.");
            //    emailtextBox.Focus();
            //    return;
            //}
            //reader.Close();
            string updateQuery = "UPDATE doctor SET email = @email, password = @password, specialization = @specialization WHERE id = @id";
            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
            {
                cmdUpdate.Parameters.AddWithValue("@id", id);
                cmdUpdate.Parameters.AddWithValue("@email", email);
                cmdUpdate.Parameters.AddWithValue("@password", password);
                cmdUpdate.Parameters.AddWithValue("@specialization", special);

                int rowsAffected = cmdUpdate.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated successfully");
                }

                con.Close();
            }
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
                        string query = "select * from doctor where id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    emailtextBox.Text = reader["email"].ToString();
                                    passwordtextBox.Text = reader["password"].ToString();
                                    spetextBox.Text = reader["specialization"].ToString();
                                }
                                else
                                {
                                    // Clear fields if no matching doctor found
                                    emailtextBox.Text = "";
                                    passwordtextBox.Text = "";
                                    spetextBox.Text = "";
                                    MessageBox.Show("Doctor does not found");
                                }
                            }
                        }
                    }
                }
           
        }
    }
}
