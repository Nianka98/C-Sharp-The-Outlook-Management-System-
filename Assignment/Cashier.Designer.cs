namespace Assignment
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnclogout = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btncreatebill = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.lblinvoice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblcustomer2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 702);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(409, 305);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(12, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1182, 699);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnclogout);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1174, 666);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Home";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // btnclogout
            // 
            this.btnclogout.Location = new System.Drawing.Point(961, 588);
            this.btnclogout.Name = "btnclogout";
            this.btnclogout.Size = new System.Drawing.Size(180, 47);
            this.btnclogout.TabIndex = 5;
            this.btnclogout.Text = "Logout";
            this.btnclogout.UseVisualStyleBackColor = true;
            this.btnclogout.Click += new System.EventHandler(this.btnclogout_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.btncreatebill);
            this.tabPage4.Controls.Add(this.btnclear);
            this.tabPage4.Controls.Add(this.btnadd);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.txttotal);
            this.tabPage4.Controls.Add(this.txtqty);
            this.tabPage4.Controls.Add(this.lbltotalprice);
            this.tabPage4.Controls.Add(this.lblinvoice);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.lblcustomer2);
            this.tabPage4.Controls.Add(this.txtprice);
            this.tabPage4.Controls.Add(this.lblproduct);
            this.tabPage4.Controls.Add(this.lblcustomer);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1174, 666);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Sales";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(734, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btncreatebill
            // 
            this.btncreatebill.Location = new System.Drawing.Point(932, 276);
            this.btncreatebill.Name = "btncreatebill";
            this.btncreatebill.Size = new System.Drawing.Size(166, 32);
            this.btncreatebill.TabIndex = 15;
            this.btncreatebill.Text = "Bill";
            this.btncreatebill.UseVisualStyleBackColor = true;
            this.btncreatebill.Click += new System.EventHandler(this.btncreatebill_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(932, 343);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(166, 32);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1039, 100);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 32);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 436);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1210, 248);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(182, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(407, 232);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(948, 215);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(166, 27);
            this.txttotal.TabIndex = 9;
            this.txttotal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(948, 161);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(166, 27);
            this.txtqty.TabIndex = 8;
            this.txtqty.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Location = new System.Drawing.Point(841, 222);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(101, 20);
            this.lbltotalprice.TabIndex = 7;
            this.lbltotalprice.Text = "Total Price";
            this.lbltotalprice.Click += new System.EventHandler(this.lbltotalprice_Click);
            // 
            // lblinvoice
            // 
            this.lblinvoice.AutoSize = true;
            this.lblinvoice.Location = new System.Drawing.Point(841, 161);
            this.lblinvoice.Name = "lblinvoice";
            this.lblinvoice.Size = new System.Drawing.Size(93, 20);
            this.lblinvoice.TabIndex = 6;
            this.lblinvoice.Text = "Invoice ID";
            this.lblinvoice.Click += new System.EventHandler(this.lblinvoice_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 369);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(432, 27);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblcustomer2
            // 
            this.lblcustomer2.AutoSize = true;
            this.lblcustomer2.Location = new System.Drawing.Point(29, 372);
            this.lblcustomer2.Name = "lblcustomer2";
            this.lblcustomer2.Size = new System.Drawing.Size(90, 20);
            this.lblcustomer2.TabIndex = 4;
            this.lblcustomer2.Text = "Customer";
            this.lblcustomer2.Click += new System.EventHandler(this.lblcustomer2_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(632, 36);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(203, 27);
            this.txtprice.TabIndex = 3;
            this.txtprice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Location = new System.Drawing.Point(178, 43);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(74, 20);
            this.lblproduct.TabIndex = 2;
            this.lblproduct.Text = "Product";
            this.lblproduct.Click += new System.EventHandler(this.lblproduct_Click);
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Location = new System.Drawing.Point(6, 39);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(0, 20);
            this.lblcustomer.TabIndex = 0;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 724);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panel1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Label lblinvoice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblcustomer2;
        private System.Windows.Forms.Button btncreatebill;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Button btnclogout;
    }
}