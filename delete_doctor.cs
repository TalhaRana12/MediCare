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
    public partial class delete_doctor : Form
    {
        public delete_doctor()
        {
            InitializeComponent();
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query= "select *from doctor";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            datagird.DataSource = table;
            conn.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            admindoctor admindoctor = new admindoctor();
            admindoctor.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminhomepage adminhomepage = new adminhomepage();
            adminhomepage.Show();
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

        private void Updatepatient_btt_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string id = idtextbox.Text;

            string query = "delete from doctor where id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete query and get the number of affected rows

            if (rowsAffected > 0)
            {
                MessageBox.Show("Doctor deleted successfully!");
            }
            else
            {
                MessageBox.Show("No doctor found with the specified ID.");
            }
        }
    }
}
