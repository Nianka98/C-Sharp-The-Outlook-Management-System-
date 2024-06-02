using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            progressBar1.Increment(8);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login fromobj = new Login();
                fromobj.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
