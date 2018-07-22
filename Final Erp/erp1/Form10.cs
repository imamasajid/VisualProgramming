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
    public partial class Form10 : Form
    {
        Form4 f4 = new Form4();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select GRNID from GRN", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["GRNID"].ToString());
            }
            f4.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select GRDate,POID,TotalAmount,VName,DDate,VID from GRN where GRNID='" + comboBox1.Text + "'", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               textBox1.Text = dr["GRDate"].ToString();
               textBox5.Text = dr["TotalAmount"].ToString();
               textBox3.Text = dr["POID"].ToString();
               textBox4.Text = dr["VID"].ToString();
               textBox2.Text = dr["VName"].ToString();
            }
            
            
            f4.oleDbConnection1.Close();*/

            f4.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from GRN where GRNID=@GRNID", f4.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@GRNID", comboBox1.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            f4.oleDbConnection1.Close();
        }
    }
}
