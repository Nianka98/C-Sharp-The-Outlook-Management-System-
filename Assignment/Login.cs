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
    public partial class Login : Form
    {
        SqlConnection con;
        public Login()
        {
            try
            {
                DBconnection DBCon = new DBconnection();
                con = DBCon.getconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "OutLook ", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                bool valid = true;
                if (string.IsNullOrEmpty(txtuname.Text) || string.IsNullOrEmpty(txtpassw.Text) || string.IsNullOrEmpty(cmbsuser.Text))
                {
                    MessageBox.Show("Need to fill all the values ", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
                if (valid)
                {
                    String UserType = null;
                    string qry = "Select Outlook from  login where Username ='" + txtuname.Text + "' and " +
                        "Password ='" + txtpassw.Text + "'and User Type ='" + cmbsuser.Text + "' ";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            UserType = dr[0].ToString();
                        }
                        if (UserType.Equals("Admin"))
                        {
                            MessageBox.Show("Login Success ", "Welcome to SManagement System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            admin obj = new admin();
                            obj.Show();
                            this.Hide();
                        }
                        else if (UserType.Equals("Manager"))
                        {
                            MessageBox.Show("Login Success ", "Welcome to  Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Manager obj = new Manager();
                            obj.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
