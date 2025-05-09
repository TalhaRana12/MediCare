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
    public partial class paybill : Form
    {
        public paybill()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "select *from payment where patient_id='" + LoggedPatient.ID + "';"; // Use parameterized queries

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@patientID", LoggedPatient.ID); // Assuming LoggedPatient.ID is an integer

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paymenttextBox.Text = reader["payment"].ToString();
                        }
                        else
                        {
                            paymenttextBox.Text = "";
                            MessageBox.Show("Bill not added yet.");
                        }
                    }
                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            patienthomepage from = new patienthomepage();
            from.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from=new signin();
            from.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            patienthomepage from=new patienthomepage();
            from.Show();
            this.Hide();
        }

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string bank, card;
            card = cardtextBox.Text;
            bank = banktextBox.Text;
            if (cardtextBox.Text == "" || banktextBox.Text == "")
            {
                MessageBox.Show("Please fill the data");
                return;
            }
            if (cardtextBox.Text.Length != 13)
            {
                MessageBox.Show("Please enter valid card number");
                return;
            }
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "update payment set paid=1 where patient_id='" + LoggedPatient.ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Payment is received");
        }
    }
}
