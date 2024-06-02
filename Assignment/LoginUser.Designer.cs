namespace Assignment
{
    partial class LoginUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuname);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 558);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Stock Keeper"});
            this.comboBox1.Location = new System.Drawing.Point(274, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "----Select----";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(258, 216);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(386, 22);
            this.txtpass.TabIndex = 8;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(246, 150);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(398, 22);
            this.txtuname.TabIndex = 7;
            this.txtuname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 553);
            this.Controls.Add(this.panel1);
            this.Name = "LoginUser";
            this.Text = "LoginUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Button button1;
    }
}