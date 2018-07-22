using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IceCream_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text="LOGIN";
            this.label1.Text = "User ID";
            this.label2.Text = "Password";
            this.button1.Text = "LOGIN";
            this.button2.Text = "EXIT";
            this.textBox2.PasswordChar = '*';
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.button1;
            this.CancelButton = this.button2;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text=="imama"&&this.textBox2.Text=="987")
            {
                MessageBox.Show("Successfully Login");
                Form2 f2 = new Form2();
                f2.Show();
                
            }
            else
            {
                MessageBox.Show("Failed");
                this.Close();
            }
        }
    }
}
