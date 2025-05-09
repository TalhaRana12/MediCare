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
    public partial class addpatient : Form
    {
        public addpatient()
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
            signin form= new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            adminpatient form= new adminpatient();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage form= new adminhomepage();   
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Addpatient_btt_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string username, email, password, phone_num, gender;
            string age;
            username = usernametextBox.Text;
            email = emailtextBox.Text;
            password = passwordtextBox.Text;
            phone_num = phonetextBox.Text;
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
            // check for duplication email
            string query1 = "select * from Patient where email = '" + email + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show(" This Email already has an account.");
                emailtextBox.Focus();
                return;
            }
            reader.Close();

            //check for duplication o phone number

            string query2 = "select * from Patient where phone_number= '" + phone_num + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                MessageBox.Show("This phone number already has an account.");
                phonetextBox.Focus();
                return;
            }
            reader2.Close();
            // after all the condition meets
            string query = "insert into patient(username, email, password, age, gender, phone_number) values('" + username + "', '" + email + "', '" + password + "', '" + age + "', '" + gender + "', '" + phone_num + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            emailtextBox.Clear();
            usernametextBox.Clear();
            passwordtextBox.Clear();
            phonetextBox.Clear();
            agetextBox.Clear();
        }
    }
}

