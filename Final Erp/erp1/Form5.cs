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
    public partial class Form5 : Form
    {
        Form4 f4 = new Form4();

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Products (Pid,PName,BasePrice,WeightInPounds,InventoryStatus,EstimatedDelivery,AmountOnHand,AllowPerOrder,WarrentyPeriod,ProductType) values (@Pid,@PName,@BasePrice,@WeightInPounds,@InventoryStatus,@EstimatedDelivery,@AmountOnHand,@AllowPerOrder,@WarrentyPeriod,@ProductType)", f4.oleDbConnection1);
            cmd.Parameters.AddWithValue("@Pid", textBox1.Text);
            cmd.Parameters.AddWithValue("@PName", textBox2.Text);
            cmd.Parameters.AddWithValue("@BasePrice", Convert.ToInt32(textBox3.Text));
            cmd.Parameters.AddWithValue("@WeightInPounds", Convert.ToInt32(textBox4.Text));
            cmd.Parameters.AddWithValue("@InventoryStatus",textBox5.Text);
            cmd.Parameters.AddWithValue("@EstimatedDelivery", Convert.ToInt32(textBox6.Text));
            cmd.Parameters.AddWithValue("@AmountOnHand", Convert.ToInt32(textBox7.Text));
            cmd.Parameters.AddWithValue("@AllowPerOrder", Convert.ToInt32(textBox8.Text));
            cmd.Parameters.AddWithValue("@WarrentyPeriod", textBox9.Text);
            cmd.Parameters.AddWithValue("@ProductType", textBox10.Text);
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been inserted");

            f4.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            f4.oleDbConnection1.Close();

        }
    }
}
