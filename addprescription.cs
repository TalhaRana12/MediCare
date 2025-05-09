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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_SE_project
{
    public partial class addprescription : Form
    {
        public addprescription()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            doctorhomepage form=new doctorhomepage();
            form.Show();
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
            doctorhomepage form=new doctorhomepage();
            form.Show();
            this.Hide();
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {
            string id = idtextBox.Text;
            string doctorID = LoggedDoctor.ID;
            if (!string.IsNullOrEmpty(id))
            {
                string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "select * from allocate where doctor_id = @doctorID AND patient_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                emailtextBox.Text = reader["patient_email"].ToString();
                            }
                            else
                            {
                                // Clear fields if no matching doctor found
                                emailtextBox.Text = "";
                                MessageBox.Show("Patient is not allocated to you");
                            }
                        }
                    }
                }
            }
        }

        private void precribe_btt_Click(object sender, EventArgs e)
        {
            string patient_id, email, medicine, disease, days;
            patient_id = idtextBox.Text;
            email = emailtextBox.Text;
            medicine = medicinetextBox.Text;
            disease = diseasetextBox.Text;
            days = daytextBox.Text;
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "insert into prescription (doctor_id,patient_id,patient_email,disease,medicine,no_of_days)\r\nvalues('" + LoggedDoctor.ID + "','" + patient_id + "','" + email + "','" + disease + "','" + medicine + "','" + days + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Prescription added successfully");
        }
    }
}
