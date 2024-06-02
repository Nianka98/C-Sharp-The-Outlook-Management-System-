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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnmlogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //con.Open();
            //string query = "UPDATE Create_Users SET Student_Name ='" + txtfullname.Text +
            //    "',Password ='" + txtpassword.Text +
            //    "',Confirm_Password ='" + txtconpass.Text +
            //     "',Address ='" + txtaddress.Text +
            //    "',Gender ='" + txtgender1.Text +
            //     "',Course_Type ='" + txtctype.Text +
            //    "',Contact_No ='" + txtcontactno.Text +
            //    "',Branch ='" + txtbranchh.Text +
            //    "',Batch_No ='" + txtbatch.Text +
            //    "',Email ='" + txtemaill.Text +
            //    "'  WHERE Student_Id = '" + txtstudentid.Text + "'";
            //SqlDataAdapter update = new SqlDataAdapter(query, con);
            //update.SelectCommand.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Updated Successfully");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //con.Open();
            //string query = "UPDATE Create_Users SET Student_Name ='" + txtfullname.Text +
            //    "',Password ='" + txtpassword.Text +
            //    "',Confirm_Password ='" + txtconpass.Text +
            //     "',Address ='" + txtaddress.Text +
            //    "',Gender ='" + txtgender1.Text +
            //     "',Course_Type ='" + txtctype.Text +
            //    "',Contact_No ='" + txtcontactno.Text +
            //    "',Branch ='" + txtbranchh.Text +
            //    "',Batch_No ='" + txtbatch.Text +
            //    "',Email ='" + txtemaill.Text +
            //    "'  WHERE Student_Id = '" + txtstudentid.Text + "'";
            //SqlDataAdapter update = new SqlDataAdapter(query, con);
            //update.SelectCommand.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Updated Successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("DELETE  FROM Create_Users where Student_Id='" + id.Text + "'", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Successfully Deleted");
            //Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("DELETE  FROM Create_Users where Student_Id='" + id.Text + "'", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Successfully Deleted");
            //Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TPOLVOE6;Initial Catalog=WinAD;Integrated Security=True");

            //if (string.IsNullOrEmpty(txtid2.Text))
            //{
            //    MessageBox.Show("Enter Student_Id", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    con.Open();
            //    SqlCommand search = new SqlCommand("select  * from Reults where Student_Id = @Student_Id", con);
            //    search.Parameters.Add(new SqlParameter("Student_Id", txtid2.Text.ToString()));
            //    SqlDataReader reader = search.ExecuteReader();
            //    bool rowfound = reader.HasRows;
            //    if (rowfound)
            //    {
            //        while (reader.Read())
            //        {
            //            txtname2.Text = reader[1].ToString();
            //            m1.Text = reader[2].ToString();
            //            m2.Text = reader[3].ToString();
            //            m3.Text = reader[4].ToString();
            //            m4.Text = reader[5].ToString();
            //            m5.Text = reader[6].ToString();
            //            m6.Text = reader[7].ToString();
            //            m7.Text = reader[8].ToString();
            //            m8.Text = reader[9].ToString();
            //            m9.Text = reader[10].ToString();
            //        }
            //        MessageBox.Show("Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    }
            //    else
            //    {
            //        MessageBox.Show("Record not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    reader.Close();
            //}
            //con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TPOLVOE6;Initial Catalog=WinAD;Integrated Security=True");

            //if (string.IsNullOrEmpty(txtid2.Text))
            //{
            //    MessageBox.Show("Enter Student_Id", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    con.Open();
            //    SqlCommand search = new SqlCommand("select  * from Reults where Student_Id = @Student_Id", con);
            //    search.Parameters.Add(new SqlParameter("Student_Id", txtid2.Text.ToString()));
            //    SqlDataReader reader = search.ExecuteReader();
            //    bool rowfound = reader.HasRows;
            //    if (rowfound)
            //    {
            //        while (reader.Read())
            //        {
            //            txtname2.Text = reader[1].ToString();
            //            m1.Text = reader[2].ToString();
            //            m2.Text = reader[3].ToString();
            //            m3.Text = reader[4].ToString();
            //            m4.Text = reader[5].ToString();
            //            m5.Text = reader[6].ToString();
            //            m6.Text = reader[7].ToString();
            //            m7.Text = reader[8].ToString();
            //            m8.Text = reader[9].ToString();
            //            m9.Text = reader[10].ToString();
            //        }
            //        MessageBox.Show("Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    }
            //    else
            //    {
            //        MessageBox.Show("Record not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    reader.Close();
            //}
            //con.Close();
        }
    }
}
