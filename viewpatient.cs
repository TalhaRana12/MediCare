using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_SE_project
{
    public partial class viewpatient : Form
    {
        public viewpatient()
        {
            InitializeComponent();
            string connectionstring = "Data Source=DESKTOP-QR4BNH8\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select *from prescription where doctor_id='" + LoggedDoctor.ID + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            datagird.DataSource = table;
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            doctorhomepage from=new doctorhomepage();
            from.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            doctorhomepage from=new doctorhomepage();
            from.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from=new signin();
            from.Show();
            this.Hide();
        }
    }
}
