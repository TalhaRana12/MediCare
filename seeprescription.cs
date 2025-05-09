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
    public partial class seeprescription : Form
    {
        public seeprescription()
        {
            InitializeComponent();
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();

                string query = "select * from prescription where patient_id = @patientID"; // Use parameterized query

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@patientID", LoggedPatient.ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idtextBox.Text = reader["doctor_id"].ToString();
                            //emailtextBox.Text = reader["doctor_email"].ToString();
                            diseasetextBox.Text = reader["disease"].ToString();
                            medicinetextBox.Text = reader["medicine"].ToString();
                            daytextBox.Text = reader["no_of_days"].ToString();
                        }
                        else
                        {
                            // Clear fields if no matching prescription found
                            //emailtextBox.Text = "";
                            idtextBox.Text = "";
                            diseasetextBox.Text = "";
                            medicinetextBox.Text = "";
                            daytextBox.Text = "";
                            MessageBox.Show("Not prescribed yet");
                        }
                    }
                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            patienthomepage form= new patienthomepage();
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from= new signin();
            from.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            patienthomepage from= new patienthomepage();
            from.Show();
            this.Hide();
        }
    }
}
