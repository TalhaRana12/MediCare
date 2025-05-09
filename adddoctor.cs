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
    public partial class adddoctor : Form
    {
        public adddoctor()
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

        private void logout_Click(object sender, EventArgs e)
        {
            signin form = new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            admindoctor form= new admindoctor();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form = new adminhomepage();  
            form.Show();
            this.Hide();
        }

        private void Adddoctor_btt_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string  email, password,special;
            email = emailtextBox.Text;
            password = passwordtextBox.Text;
            special=spetextBox.Text;
            // to check all the data is entered not of them are empty
            if ( emailtextBox.Text == "" || passwordtextBox.Text == "" ||spetextBox.Text=="")
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
            // check for duplication email
            string query1 = "select * from doctor where email = '" + email + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show(" This Email already has an account.");
                emailtextBox.Focus();
                return;
            }
            reader.Close();

            // after all the condition meets
            string query = "insert into doctor( email, password,specialization) values('" + email + "', '" + password + "', '" + special + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added new doctor");
            emailtextBox.Clear();
            passwordtextBox.Clear();
            spetextBox.Clear();
        }
    }
}
