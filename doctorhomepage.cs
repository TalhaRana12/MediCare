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
    public partial class doctorhomepage : Form
    {
        public doctorhomepage()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin from=new signin();
            from.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            doctorhomepage from=new doctorhomepage();
            from.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            viewpatient from=new viewpatient();
            from.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            addprescription from=new addprescription();
            from.Show();
            this.Hide();
        }
    }
}
