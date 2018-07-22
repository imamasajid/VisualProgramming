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
    public partial class Form6 : Form
    {
        Form4 f4 = new Form4();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand c = new OleDbCommand("select VID from vendor ",f4.oleDbConnection1);
            OleDbDataReader dr = c.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"].ToString());
            }
            f4.oleDbConnection1.Close();


            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select Pid from Products ", f4.oleDbConnection1);
            OleDbDataReader d = cmd.ExecuteReader();

            while (d.Read())
            {
                comboBox2.Items.Add(d["Pid"].ToString());
            }
            f4.oleDbConnection1.Close();

            f4.oleDbConnection1.Open();
            OleDbCommand c1 = new OleDbCommand("select Deptid from Dept ", f4.oleDbConnection1);
            OleDbDataReader dr1 = c1.ExecuteReader();

            while (dr1.Read())
            {
                comboBox3.Items.Add(dr1["Deptid"].ToString());
            }
            f4.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where VID='" + comboBox1.Text + "'", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["VName"].ToString();
                textBox2.Text = dr["CPName"].ToString();
                textBox3.Text = dr["VGroup"].ToString();
                //textBox4.Text = dr["VStatus"].ToString();
                textBox5.Text = dr["CPPH"].ToString();
                
            }
            f4.oleDbConnection1.Close();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            f4.oleDbConnection1.Open();
            OleDbCommand cm = new OleDbCommand("select * from Products where Pid='" + comboBox2.Text + "'", f4.oleDbConnection1);
           OleDbDataReader d = cm.ExecuteReader();
            if (d.Read())
          {
               textBox6.Text = d["PName"].ToString();
               textBox7.Text = d["BasePrice"].ToString();
               //textBox8.Text = d["InventoryStatus"].ToString();
               textBox9.Text = d["WarrentyPeriod"].ToString();
               textBox10.Text = d["ProductType"].ToString();

            }
            f4.oleDbConnection1.Close();
        }

       

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Dept where Deptid='" + comboBox3.Text + "'", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox11.Text = dr["deptname"].ToString();
            }
            f4.oleDbConnection1.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into PO (POID, TotalAmount,VID,VDept,PODate,DDate) values (@POID, @TotalAmount,@VID,@VDept,@PODate,@DDate)", f4.oleDbConnection1);
            cmd.Parameters.AddWithValue("@POID", textBox11.Text);
           // cmd.Parameters.AddWithValue("@Pid", comboBox2.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", textBox8.Text);
            cmd.Parameters.AddWithValue("@VID",Convert.ToInt32( comboBox1.Text));
            cmd.Parameters.AddWithValue("@VDept", comboBox3.Text);
            cmd.Parameters.AddWithValue("@PODate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker2);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Data insert");
            f4.oleDbConnection1.Close();

        }
    }
}
