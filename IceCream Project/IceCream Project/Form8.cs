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
    public partial class Form8 : Form
    {
        Form1 f1 = new Form1();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f1.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into vendor(C_ID,C_Name,C_PNO,C_ADD,C_Email)values(@C_ID,@C_Name,@C_PNO,@C_ADD,@C_Email)", f1.oleDbConnection1);

            cmd.Parameters.AddWithValue("@C_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@C_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@C_PNO", textBox3.Text);
            cmd.Parameters.AddWithValue("@C_ADD", textBox4.Text);
            cmd.Parameters.AddWithValue("@C_Email", textBox5.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("record inserted");
            f1.oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f1.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer", f1.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            f1.oleDbConnection1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
