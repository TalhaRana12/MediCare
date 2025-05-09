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
    public partial class adminpatient : Form
    {
        public adminpatient()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin form=new signin();
            form.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            adminhomepage from=new adminhomepage();
            from.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage adminhomepage = new adminhomepage();
            adminhomepage.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addpatient from=new addpatient();
            from.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            updatepatient from=new updatepatient();
            from.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            searchpatient from=new searchpatient();
            from.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            deletepatient from=new deletepatient();
            from.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            managebill from=new managebill();
            from.Show();
            this.Hide();
        }
    }
}
