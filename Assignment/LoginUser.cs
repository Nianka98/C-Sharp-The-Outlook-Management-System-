using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Assignment
{
    public partial class LoginUser : Form
    {
        SqlConnection sqlCon;

        public LoginUser()
        {
            InitializeComponent();
            try
            {

                DBconnection obj = new DBconnection();
                sqlCon = obj.getconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting" + ex, "Login Form", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
