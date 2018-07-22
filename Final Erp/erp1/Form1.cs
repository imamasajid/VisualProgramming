using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace erp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "a" && this.textBox2.Text == "a")
            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
                
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
