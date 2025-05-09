using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_SE_project
{
    public partial class admindoctor : Form
    {
        public admindoctor()
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
            adminhomepage form=new adminhomepage();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adminhomepage adminhomepage = new adminhomepage();
            adminhomepage.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adddoctor form=new adddoctor();
            form.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            searchdoctor form= new searchdoctor();
            form.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            updatedoctor from=new updatedoctor();
            from.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            delete_doctor form=new delete_doctor();
            form.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            allocatepatient form=new allocatepatient();
            form.Show();
            this.Hide();
        }
    }
}
