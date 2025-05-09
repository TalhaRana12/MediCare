using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_SE_project
{
    public partial class adminhomepage : Form
    {
        public adminhomepage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            admindoctor form= new admindoctor();
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from= new signin();
            from.Show();
            this.Hide();
        }

        private void doctor_label_Click(object sender, EventArgs e)
        {
            admindoctor form = new admindoctor();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            adminpatient adminpatient = new adminpatient();
            adminpatient.Show();
            this.Hide();
        }

        private void patient_label_Click(object sender, EventArgs e)
        {
            adminpatient adminpatient = new adminpatient();
            adminpatient.Show();
            this.Hide();
        }
    }
}
