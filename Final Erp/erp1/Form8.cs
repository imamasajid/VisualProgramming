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
    public partial class Form8 : Form
    {
        Form4 f4 = new Form4();
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor", f4.oleDbConnection1);
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
            OleDbCommand cmd = new OleDbCommand("update vendor set VStatus ='Approve' where VID='" + status + "'", f4.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
            dataGridView1.Refresh();
            f4.oleDbConnection1.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into vendor (VID,VName,Vcode,Vcity,PH1,PH2,VAddress,CPname,CPPH,VEmail,VFax,VGroup,Vstatus) values (@VID,@VName,@Vcode,@Vcity,@PH1,@PH2,@VAddress,@CPname,@CPPH,@VEmail,@VFax,@VGroup,@Vstatus)", f4.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Vcode", textBox3.Text);
            cmd.Parameters.AddWithValue("@Vcity", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH1", Convert.ToInt32(textBox5.Text));
            cmd.Parameters.AddWithValue("@PH2", Convert.ToInt32(textBox6.Text));
            cmd.Parameters.AddWithValue("@Address", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPname", textBox8.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox9.Text);
            cmd.Parameters.AddWithValue("@VEmail", textBox10.Text);
            cmd.Parameters.AddWithValue("@VFax", textBox11.Text);
            cmd.Parameters.AddWithValue("@VGroup", textBox12.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox13.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been inserted");

            f4.oleDbConnection1.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.textBox13.Text = "Dis-Approved";
        }
    }
}
