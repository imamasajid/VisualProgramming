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
    public partial class Form9 : Form
    {
        Form4 f4 = new Form4(); 
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select PO.POID from PO where NOT EXISTS(SELECT GRN.POID FROM GRN WHERE PO.POID = GRN.POID)", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"].ToString());

            }
            f4.oleDbConnection1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            f4.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("select VName,VID,TotalAmount from PO where POID='"+comboBox1.Text+"'", f4.oleDbConnection1);
           // OleDbCommand cmd2 = new OleDbCommand("", f4.oleDbConnection1);

            OleDbDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["VID"].ToString();
                textBox2.Text = dr["VName"].ToString();
                textBox3.Text = dr["TotalAmount"].ToString();
                //textBox4.Text = dr["Pid"].ToString();

            }
           
            f4.oleDbConnection1.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into GRN (POID,GRNID,VName,DDate,GRDate) values (@POID,@GRNID,@VName,@DDate,@GRDate)", f4.oleDbConnection1);
            cmd.Parameters.AddWithValue("@POID",comboBox1.Text);
            cmd.Parameters.AddWithValue("@GRNID", textBox1.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@GRDate", dateTimePicker2);
            cmd.ExecuteNonQuery();

            MessageBox.Show("GRN CREATE");
            f4.oleDbConnection1.Close();

        }

        

        
    }
}
