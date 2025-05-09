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
using System.Data.SqlClient;
namespace HMS_SE_project
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void singin_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string username, email, password, phone_num, gender;
            string age;
            username = signupusernametextbox.Text;
            email = signupemailtextBox.Text;
            password = signuppasswordtextBox.Text;
            phone_num = signupphonenumbertextBox.Text;
            age = signupagetextBox.Text;
            gender = "";
            if (male_radiobutton.Checked == true)
            {
                gender = "Male";
            }
            else if (female_radiobutton.Checked == true)
            {
                gender = "Female";
            }
            // to check all the data is entered not of them are empty
            if (signupusernametextbox.Text == "" || signupemailtextBox.Text == "" || signuppasswordtextBox.Text == "" || signupphonenumbertextBox.Text == "" || signupagetextBox.Text == "" || (!male_radiobutton.Checked && !female_radiobutton.Checked))
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
                        signupemailtextBox.Focus();
                        return;
                    }
                }
                catch (FormatException) // in case format of the email is not correct
                {
                    MessageBox.Show("Invalid Email");
                    signupemailtextBox.Focus();
                    return;
                }
            }
            if (signupphonenumbertextBox.Text.Length != 11) // in case when the phone is less than or greater than 11 digits
            {
                MessageBox.Show("Phone number must be 11 digit.");
                signupphonenumbertextBox.Clear();
                signupphonenumbertextBox.Focus();
                return;
            }
            // check for duplication email
            string query1 = "select * from Patient where email = '" + email + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show(" This Email already has an account.");
                signupemailtextBox.Focus();
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
                signupphonenumbertextBox.Focus();
                return;
            }
            reader2.Close();
            // after all the condition meets
            string query = "insert into patient(username, email, password, age, gender, phone_number) values('" + username + "', '" + email + "', '" + password + "', '" + age + "', '" + gender + "', '" + phone_num + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully registered");
            con.Close();
            signupemailtextBox.Clear();
            signupusernametextbox.Clear();
            signuppasswordtextBox.Clear();
            signupphonenumbertextBox.Clear();
            signupagetextBox.Clear();
            signin form = new signin();
            form.Show();
            this.Hide();
        }
    }
}
