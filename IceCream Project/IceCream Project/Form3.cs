using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace IceCream_Project
{
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label2.Text = "Purchase ID";
            this.label3.Text = "Item ID";
            this.label4.Text = "Quantity";
            this.label5.Text = "Price";
            this.Text = "Purchase";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
