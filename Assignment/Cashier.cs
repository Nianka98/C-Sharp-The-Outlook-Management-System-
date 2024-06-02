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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //name.Text = string.Empty;
            //id.Text = string.Empty;
            //admission.Text = string.Empty;
            //address.Text = string.Empty;
            //contact.Text = string.Empty;
            //dob.Text = string.Empty;
            //gender.Text = string.Empty;
            //coursetype.Text = string.Empty;
            //batch.Text = string.Empty;
            //branch.Text = string.Empty;
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblproduct_Click(object sender, EventArgs e)
        {

        }

        private void lblcustomer2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblinvoice_Click(object sender, EventArgs e)
        {

        }

        private void lbltotalprice_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txttotal.Text = (Convert.ToInt16(txtprice.Text) * Convert.ToInt16(txtqty.Text)).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //con.Open();
            ////SqlCommand cmd = new SqlCommand("INSERT INTO Create_Users VALUES(Student_Id,Student_Name,Password,Confirm_Password,Address,Gender,Course_Type,Contact_No, Branch, Batch_No, Email)", con);
            //SqlCommand cmd = new SqlCommand("Insert Into Create_Users(Student_Id,Student_Name,Password,Confirm_Password,Address,Gender,Course_Type, Contact_No, Branch, Batch_No, Email) Values (@Student_Id,@Student_Name,@Password, @Confirm_Password, @Address, @Gender, @Course_Type, @Contact_No, @Branch, @Batch_No, @Email)", con);

            //cmd.Parameters.AddWithValue("Student_Id", txtid.Text);
            //cmd.Parameters.AddWithValue("Student_Name", txtname.Text);
            //cmd.Parameters.AddWithValue("Password", txtpass.Text);
            //cmd.Parameters.AddWithValue("Confirm_Password", txtconfirmpass.Text);
            //cmd.Parameters.AddWithValue("Address", txtaddr.Text);
            //cmd.Parameters.AddWithValue("Gender", txtgender.Text);
            //cmd.Parameters.AddWithValue("Course_Type", txtcourse.Text);
            //cmd.Parameters.AddWithValue("Contact_No", txtcontactno.Text);
            //cmd.Parameters.AddWithValue("Branch", txtbranch.Text);
            //cmd.Parameters.AddWithValue("Batch_No", txtbatch.Text);
            //cmd.Parameters.AddWithValue("Email", txtemail.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Submitted sucessfully");
            //Bind();
            //Clear();
        }

        private void btncreatebill_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclogout_Click(object sender, EventArgs e)
        {
          Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
