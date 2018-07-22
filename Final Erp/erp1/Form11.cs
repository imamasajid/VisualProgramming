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
    public partial class Form11 : Form
    {
        Form4 f4 = new Form4();

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox11.Text = "Dis_Approve";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into customer(CID,Cname,CAddress,City,PH1,PH2,ContectPerson,CPPH,CEmail,CreditLimit,CStatus,CGroup) Values(@CID,@Cname,@CAddress,@City,@PH1,@PH2,@ContectPerson,@CPPH,@CEmail,@CreditLimit,@CStatus,@CGroup)", f4.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Cname", textBox2.Text);
            cmd.Parameters.AddWithValue("@CAddress", textBox3.Text);
            cmd.Parameters.AddWithValue("@City", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH1", Convert.ToInt32(textBox5.Text));
            cmd.Parameters.AddWithValue("@PH2", Convert.ToInt32(textBox6.Text));
            cmd.Parameters.AddWithValue("@ContectPerson", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPPH", Convert.ToInt32(textBox8.Text));
            cmd.Parameters.AddWithValue("@CEmail", textBox9.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", Convert.ToInt32(textBox10.Text));
            cmd.Parameters.AddWithValue("@CStatus", textBox11.Text);
            cmd.Parameters.AddWithValue("@CGroup", textBox12.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Record has been Inserted ");
            f4.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer", f4.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Approve";
            btn.Name = "APPROVE";
            btn.Text = "APPROVE";
            btn.UseColumnTextForButtonValue = true;
            f4.oleDbConnection1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String status = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update customer set CStatus ='Approve' where CID='" + status + "'", f4.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
            dataGridView1.Refresh();
            f4.oleDbConnection1.Close();
        }

        
    }
}
