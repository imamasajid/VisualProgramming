using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace erp1
{
    public partial class Form12 : Form
    {
        Form4 f4 = new Form4();

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand c1 = new OleDbCommand("select Deptid from Dept ", f4.oleDbConnection1);
            OleDbDataReader dr1 = c1.ExecuteReader();

            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["Deptid"].ToString());
            }
            f4.oleDbConnection1.Close();

            f4.oleDbConnection1.Open();
            OleDbCommand c = new OleDbCommand("select CID from customer ", f4.oleDbConnection1);
            OleDbDataReader dr = c.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["CID"].ToString());
            }
            f4.oleDbConnection1.Close();


            f4.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select Pid from Products ", f4.oleDbConnection1);
            OleDbDataReader d1 = cmd1.ExecuteReader();

            while (d1.Read())
            {
                comboBox3.Items.Add(d1["Pid"].ToString());
            }
            f4.oleDbConnection1.Close();
       
       
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Products where Pid='" + comboBox3.Text + "'", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox8.Text = dr["PName"].ToString();
                textBox7.Text = dr["PQuantity"].ToString();
                textBox6.Text = dr["ProductType"].ToString();
                textBox5.Text = dr["WarrentyPeriod"].ToString();
                textBox9.Text = dr["BasePrice"].ToString();
            }
            f4.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer where CID='" + comboBox2.Text + "'", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Cname"].ToString();
                textBox2.Text = dr["CreditLimit"].ToString();
                textBox3.Text = dr["CGroup"].ToString();
                textBox4.Text = dr["PH1"].ToString();

            }
            f4.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into SOP (SOID,DeptID,CID,PID,PQuantity,Creditlimit) Values(@SOID,@DeptID,@CID,@PID,@PQuantity,@Creditlimit)", f4.oleDbConnection1);
            cmd.Parameters.AddWithValue("@SOID",Convert.ToInt32( textBox10.Text));
            cmd.Parameters.AddWithValue("@DeptID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@CID", comboBox2.Text);
            cmd.Parameters.AddWithValue("@PID", comboBox3.Text);
            cmd.Parameters.AddWithValue("@PQuantity",Convert.ToInt32( textBox7.Text));
           // cmd.Parameters.AddWithValue("@Group", textBox3.Text);
            cmd.Parameters.AddWithValue("@Creditlimit",Convert.ToInt32( textBox2.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Insert");
            f4.oleDbConnection1.Close();
        }
    }
}
