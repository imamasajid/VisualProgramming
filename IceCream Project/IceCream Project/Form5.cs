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
    
    public partial class Form5 : Form
    {
        Form1 f1 = new Form1();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.label1.Text = "STOKE DETAILS";
            this.label1.BackColor = Color.Transparent;
            this.label2.Text = "Item_ID";
            this.label3.Text = "Item_Name";
            this.label4.Text = "Item_Quantity";
            this.label5.Text = "Item_TP";
            this.label6.Text = "Item_RT";
            this.button1.Text = "Insert";
            this.button2.Text = "Update";
            this.button3.Text = "Delete";
            this.button5.Text = "Show All Items";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.oleDbConnection1.Open();
          
            OleDbCommand cmd = new OleDbCommand("insert into items(I_Name,I_QTY,ITP,IRT) values ('"+textBox2.Text+"','"+textBox3.Text+"',"+Convert.ToInt32( textBox4.Text)+","+Convert.ToInt32(textBox5.Text)+")", f1.oleDbConnection1);
            //cmd.Parameters.AddWithValue("@I_ID", Convert.ToInt32(textBox1.Text));
            //cmd.Parameters.AddWithValue("@I_Name", textBox2.Text);
            //cmd.Parameters.AddWithValue("@I_QTY", textBox3.Text);
            //cmd.Parameters.AddWithValue("@ITP",Convert.ToInt32( textBox4.Text));
            //cmd.Parameters.AddWithValue("@IRT", Convert.ToInt32(textBox5.Text));
            cmd.ExecuteNonQuery();
            
            f1.oleDbConnection1.Close();
            MessageBox.Show("record inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.oleDbConnection1.Open();
            OleDbCommand cm2 = new OleDbCommand("update items set I_Name = '" + textBox2.Text + "',I_QTY=" + Convert.ToInt32(textBox3.Text) + ",ITP=" + Convert.ToInt32(textBox4.Text) + ",IRT=" + Convert.ToInt32(textBox5.Text) + "  where I_ID=" + Convert.ToInt32(textBox1.Text) + "", f1.oleDbConnection1);
            //cm2.Parameters.AddWithValue("@I_Name",textBox2.Text);
            //cm2.Parameters.AddWithValue("@I_QTY",Convert.ToInt32(textBox3.Text));
            //cm2.Parameters.AddWithValue("@ITP",Convert.ToInt32(textBox4.Text));
            //cm2.Parameters.AddWithValue("@IRT",Convert.ToInt32(textBox5.Text));
            cm2.ExecuteNonQuery();
            
            f1.oleDbConnection1.Close();
            MessageBox.Show("record updated");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            f1.oleDbConnection1.Open();
            OleDbCommand cm1 = new OleDbCommand("select * from items ", f1.oleDbConnection1);
            OleDbDataReader d1 = cm1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d1);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
