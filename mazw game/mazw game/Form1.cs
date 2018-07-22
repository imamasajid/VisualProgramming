using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazw_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "MAZE GAME";
            this.button1.Text = "START";
            this.button2.Text = "EXIT";
            this.label1.BackColor = Color.MediumVioletRed;
            this.label1.ForeColor = Color.Wheat;
            this.button1.BackColor = Color.MediumVioletRed;
            this.button1.ForeColor = Color.Wheat;
            this.button2.BackColor = Color.MediumVioletRed;
            this.button2.ForeColor = Color.Wheat;
            this.BackColor = Color.Aqua;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
