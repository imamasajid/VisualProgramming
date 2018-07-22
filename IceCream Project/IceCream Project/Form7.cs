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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Text = "Customer";
            this.label1.Text = "Customer ID";
            this.label2.Text = "Cutomer Name";
            this.label3.Text = "Customer PNO";
            this.label4.Text = "Customer Address";
            this.label5.Text = "Cutomer Email";
            this.button1.Text = "Insert";
            this.button2.Text = "Update";
            this.button3.Text = "Delete";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into vendor(C_ID,C_Name,C_PNO,C_ADD,C_Email)values(@C_ID,@C_Name,@C_PNO,@C_ADD,@C_Email)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@C_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@C_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@C_PNO", textBox3.Text);
            cmd.Parameters.AddWithValue("@C_ADD", textBox4.Text);
            cmd.Parameters.AddWithValue("@C_Email", textBox5.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("record inserted");
            f2.oleDbConnection1.Close();
        }
    }
}
