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
    public partial class Form6 : Form
    {
        Form1 f1 = new Form1();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.label1.Text = "VID";
            this.label2.Text = "VName";
            this.label3.Text = "V_NO";
            this.label4.Text = "VCompany";
            this.label5.Text = "VAddress";
            this.label6.Text = "Email";
            this.button1.Text = "Insert";
            this.button2.Text = "Update";
            this.button3.Text = "Delete";
            this.button5.Text = "Show All Vendor";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            f1.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into vendor(V_ID,V_Name,V_PNO,V_CMP,V_ADD,V_Email)values(@V_ID,@V_Name,@V_PNO,@V_CMP,@V_ADD,@V_Email)", f1.oleDbConnection1);

            cmd.Parameters.AddWithValue("@V_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@V_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@V_PNO", textBox3.Text);
            cmd.Parameters.AddWithValue("@V_CMP", textBox4.Text);
            cmd.Parameters.AddWithValue("@V_ADD", textBox5.Text);
            cmd.Parameters.AddWithValue("@V_Email", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record inserted");
            f1.oleDbConnection1.Close();
             * */
            f1.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("insert into vendors(VName,VPNO,VCMP,VAdd,VEmail) values ('" + textBox2.Text + "','" + Convert.ToInt32(textBox3.Text) + "," + textBox4.Text + "'," + textBox5.Text + "'," + textBox6.Text + ")", f1.oleDbConnection1);
            //cmd.Parameters.AddWithValue("@I_ID", Convert.ToInt32(textBox1.Text));
            //cmd.Parameters.AddWithValue("@I_Name", textBox2.Text);
            //cmd.Parameters.AddWithValue("@I_QTY", textBox3.Text);
            //cmd.Parameters.AddWithValue("@ITP",Convert.ToInt32( textBox4.Text));
            //cmd.Parameters.AddWithValue("@IRT", Convert.ToInt32(textBox5.Text));
            cmd.ExecuteNonQuery();

            f1.oleDbConnection1.Close();
            MessageBox.Show("record inserted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f1.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor", f1.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            f1.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.oleDbConnection1.Open();
            OleDbCommand cm2 = new OleDbCommand("update items set VName = '" + textBox2.Text + "',VPNO=" + Convert.ToInt32(textBox3.Text) + ",VCMP=" + textBox4.Text + ",VAdd" + textBox5.Text +"VName = '" + textBox2.Text + " where I_ID=" + Convert.ToInt32(textBox1.Text) + "", f1.oleDbConnection1);
            //cm2.Parameters.AddWithValue("@I_Name",textBox2.Text);
            //cm2.Parameters.AddWithValue("@I_QTY",Convert.ToInt32(textBox3.Text));
            //cm2.Parameters.AddWithValue("@ITP",Convert.ToInt32(textBox4.Text));
            //cm2.Parameters.AddWithValue("@IRT",Convert.ToInt32(textBox5.Text));
            cm2.ExecuteNonQuery();

            f1.oleDbConnection1.Close();
            MessageBox.Show("record updated");
        }
    }
}
