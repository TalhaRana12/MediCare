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
    public partial class patienthomepage : Form
    {
        public patienthomepage()
        {
            InitializeComponent();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            seeprescription from=new seeprescription();
            from.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            updateprofile from=new updateprofile();
            from.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            paybill from=new paybill();
            from.Show();
            this.Hide();
        }
    }
}
