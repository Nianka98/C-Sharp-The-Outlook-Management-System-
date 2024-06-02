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


    public partial class admin : Form
    {
        SqlConnection con;

        public admin()
        {
            try
            {

                DBconnection DBCon = new DBconnection();
                con = DBCon.getconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Colombo City Institute ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           // LOGIN obj = new LOGIN();
           // obj.Show();
           // this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bool valid = true;


            if (String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtfname.Text) || String.IsNullOrEmpty(txtlname.Text) ||
                String.IsNullOrEmpty(txtemail.Text) || String.IsNullOrEmpty(txtmobile.Text) || String.IsNullOrEmpty(txtusrname.Text) ||
                String.IsNullOrEmpty(txtpassword.Text) || String.IsNullOrEmpty(cmbusert.Text) || String.IsNullOrEmpty(cmbs.Text))
            {
                MessageBox.Show("Need to fill all the values", "ManageUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            try
            {
                con.Open();
                if (valid)
                {
                    DialogResult confirm = MessageBox.Show("Are You Sure to Add the User", "Manage User",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (confirm == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("insert into UserManage values ('" + txtid.Text + "','"
                            + txtfname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "' ,'" + txtmobile.Text + "','"
                            + txtusrname.Text + "','" + txtpassword.Text + "','" + cmbusert.SelectedItem.ToString() + "','"
                            + cmbs.SelectedItem.ToString() + "')", con);
                        cmd.Connection = con;
                        int NoRows = cmd.ExecuteNonQuery();

                        if (NoRows > 0)
                        {
                            MessageBox.Show("User Added Successfully !", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user!", "Add Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "ManageUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btncsave_Click(object sender, EventArgs e)
        {
            bool valid = true;


            if (String.IsNullOrEmpty(txtcid.Text) || String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtaddress.Text) ||
                String.IsNullOrEmpty(txtcemail.Text) || String.IsNullOrEmpty(txtcmobile.Text) || String.IsNullOrEmpty(combocststus.Text))
            {
                MessageBox.Show("Need to fill all the values", "Customer_Manage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            try
            {
                con.Open();
                if (valid)
                {
                    DialogResult confirm = MessageBox.Show("Are You Sure to Add the Customer", "Customer Manage",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (confirm == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Customer_Manage values ('" + txtcid.Text + "','"
                            + txtname.Text + "','" + txtaddress.Text + "','" + txtcemail.Text + "' ,'" + txtcmobile.Text + "','"
                            + combocststus.SelectedItem.ToString() + "')", con);
                        cmd.Connection = con;
                        int NoRows = cmd.ExecuteNonQuery();

                        if (NoRows > 0)
                        {
                            MessageBox.Show("Customer Added Successfully !", "Customer Manage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Customer!", "Add Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Customer_Manage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE UserManage SET First_Name ='" + txtfname.Text + "',Last_Name ='" +
                txtlname.Text + "',Email ='" + txtemail.Text + "',Mobile ='" +
                txtmobile.Text + "',UserName ='" + txtusrname.Text + "',Password ='" + txtpassword.Text + "',UserType ='" +
                cmbusert.Text + "', Status ='" + cmbstatus.Text + "'WHERE UserID = '" + txtid.Text + "'";
            SqlDataAdapter update = new SqlDataAdapter(query, con);
            update.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void btnbupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Customer_Manage SET Name ='" + txtname.Text + "',Address ='" + txtaddress.Text + "',Email ='" +
                txtcemail.Text + "',Mobile ='" + txtcmobile.Text + "', Status ='" + combocststus.Text + "'WHERE Customer ID = '" + txtcid.Text + "'";
            SqlDataAdapter update = new SqlDataAdapter(query, con);
            update.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");

           
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtmobile.Text = string.Empty;
            txtusrname.Text = string.Empty;
            txtpassword.Text = string.Empty;
            cmbusert.Text = string.Empty;
            cmbs.Text = string.Empty;
        }


        private void btncdelete_Click(object sender, EventArgs e)
        {
            txtcid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtcemail.Text = string.Empty;
            txtcmobile.Text = string.Empty;
            combocststus.Text = string.Empty;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6FMHLM\SQLEXPRESS;Initial Catalog=Outlook;Integrated Security=True");

            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Enter UserID", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand search = new SqlCommand("select  * from UserManage where UserID = @UserID", con);
                search.Parameters.Add(new SqlParameter("UserID", txtid.Text.ToString()));
                SqlDataReader reader = search.ExecuteReader();
                bool rowfound = reader.HasRows;
                if (rowfound)
                {
                    while (reader.Read())
                    {
                        txtfname.Text = reader[1].ToString();
                        txtlname.Text = reader[2].ToString();
                        txtemail.Text = reader[3].ToString();
                        txtmobile.Text = reader[4].ToString();
                        txtusrname.Text = reader[5].ToString();
                        txtpassword.Text = reader[6].ToString();
                        cmbusert.Text = reader[7].ToString();
                        cmbs.Text = reader[8].ToString();
                    }
                    MessageBox.Show("Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Record not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            con.Close();
        }

        private void btncsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6FMHLM\SQLEXPRESS;Initial Catalog=Outlook;Integrated Security=True");

            if (string.IsNullOrEmpty(txtcid.Text))
            {
                MessageBox.Show("Enter Customer ID", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand search = new SqlCommand("select  * from Customer_Manage where Customer ID = @Customer ID", con);
                search.Parameters.Add(new SqlParameter("Customer ID", txtcid.Text.ToString()));
                SqlDataReader reader = search.ExecuteReader();
                bool rowfound = reader.HasRows;
                if (rowfound)
                {
                    while (reader.Read())
                    {
                  
                        txtname.Text = reader[2].ToString();
                        txtaddress.Text = reader[3].ToString();
                        txtcemail.Text = reader[4].ToString();
                        txtcmobile.Text = reader[5].ToString();
                        combocststus.Text = reader[6].ToString();
                       

                    }
                    MessageBox.Show("Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Record not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {


        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void dataGridViewures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = UserGV.SelectedRows[0].Cells[0].Value.ToString();
            txtfname.Text = UserGV.SelectedRows[0].Cells[1].Value.ToString();
            txtlname.Text = UserGV.SelectedRows[0].Cells[2].Value.ToString();
            txtemail.Text = UserGV.SelectedRows[0].Cells[3].Value.ToString();
            txtmobile.Text = UserGV.SelectedRows[0].Cells[4].Value.ToString();
            txtusrname.Text = UserGV.SelectedRows[0].Cells[5].Value.ToString();
            txtpassword.Text = UserGV.SelectedRows[0].Cells[6].Value.ToString();
            cmbusert.SelectedIndex = cmbusert.FindString(UserGV.SelectedRows[0].Cells[7].Value.ToString());
            cmbs.SelectedIndex = cmbs.FindString(UserGV.SelectedRows[0].Cells[8].Value.ToString());
        }

        private void UserGV_Click(object sender, EventArgs e)
        {
            txtid.Text = UserGV.SelectedRows[0].Cells[0].Value.ToString();
            txtfname.Text = UserGV.SelectedRows[0].Cells[1].Value.ToString();
            txtlname.Text = UserGV.SelectedRows[0].Cells[2].Value.ToString();
            txtemail.Text = UserGV.SelectedRows[0].Cells[3].Value.ToString();
            txtmobile.Text = UserGV.SelectedRows[0].Cells[4].Value.ToString();
            txtusrname.Text = UserGV.SelectedRows[0].Cells[5].Value.ToString();
            txtpassword.Text = UserGV.SelectedRows[0].Cells[6].Value.ToString();
            cmbusert.SelectedIndex = cmbusert.FindString(UserGV.SelectedRows[0].Cells[7].Value.ToString());
            cmbs.SelectedIndex = cmbs.FindString(UserGV.SelectedRows[0].Cells[8].Value.ToString());
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6FMHLM\SQLEXPRESS;Initial Catalog=Outlook;Integrated Security=True");

            if (string.IsNullOrEmpty(txtpid.Text))
            {
                MessageBox.Show("Enter Product ID", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand search = new SqlCommand("select  * from Stock_Manage where Product ID = @Product ID", con);
                search.Parameters.Add(new SqlParameter("Product ID", txtpid.Text.ToString()));
                SqlDataReader reader = search.ExecuteReader();
                bool rowfound = reader.HasRows;
                if (rowfound)
                {
                    while (reader.Read())
                    {
                        txtpcode.Text = reader[1].ToString();
                        txtpname.Text = reader[2].ToString();
                        cmbsize.Text = reader[3].ToString();
                        cmbcategory.Text = reader[4].ToString();
                        txtqunt.Text = reader[5].ToString();
                        txtboxdis.Text = reader[6].ToString();
                        txtprice.Text = reader[7].ToString();
                        cmbstatus.Text = reader[8].ToString();

                    }
                    MessageBox.Show("Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Record not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            bool valid = true;


            if (String.IsNullOrEmpty(txtpid.Text) || String.IsNullOrEmpty(txtpcode.Text) || String.IsNullOrEmpty(txtpname.Text)
               || String.IsNullOrEmpty(cmbsize.Text) || String.IsNullOrEmpty(cmbcategory.Text) || String.IsNullOrEmpty(txtqunt.Text)
               || String.IsNullOrEmpty(txtboxdis.Text) ||
                String.IsNullOrEmpty(txtprice.Text) || String.IsNullOrEmpty(cmbstatus.Text))

            {
                MessageBox.Show("Need to fill all the values", "Stock_Manage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            try
            {
                con.Open();
                if (valid)
                {
                    DialogResult confirm = MessageBox.Show("Are You Sure to Add the Stock", "Stock Manage",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (confirm == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Stock_Manage values ('" + txtpid.Text + "','"
                            + txtpcode.Text + "','" + txtpname.Text + "','" + cmbsize.SelectedItem.ToString() + "','"
                            + cmbcategory.SelectedItem.ToString() + "','" + txtqunt.Text + "','"
                            + txtboxdis.TextLength + "','" + txtprice.Text + "','" + cmbstatus.SelectedItem.ToString() + "')", con);
                        cmd.Connection = con;
                        int NoRows = cmd.ExecuteNonQuery();

                        if (NoRows > 0)
                        {
                            MessageBox.Show("Stock Added Successfully !", "Stock Manage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Stock!", "Add Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Stock_Manage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
          
            con.Open();
            string query = "UPDATE Stock_Manage SET Product code ='" + txtpcode.Text + "',Product name ='" +
                txtpname.Text + "',Size ='" + cmbsize.Text + "',Category ='" +
                cmbcategory.Text + "',Quantity ='" + txtqunt.Text + "',Discription ='" + txtboxdis.Text + "',Price ='" +
                txtprice.Text + "', Status ='" + cmbstatus.Text + "'WHERE Product ID = '" + txtpid.Text + "'";
            SqlDataAdapter update = new SqlDataAdapter(query, con);
            update.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            txtpid.Text = string.Empty;
            txtpcode.Text = string.Empty;
            txtpname.Text = string.Empty;
            cmbsize.Text = string.Empty;
            cmbcategory.Text = string.Empty;
            txtqunt.Text = string.Empty;
            txtboxdis.Text = string.Empty;
            txtprice.Text = string.Empty;
            cmbstatus.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}