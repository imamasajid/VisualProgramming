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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "START";
            this.label1.ForeColor = Color.Wheat;
            this.label31.Text = "Finish";
            this.label31.BackColor = Color.Purple;
            this.label31.ForeColor = Color.White;
            this.panel1.BackColor = Color.Aqua;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void label31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WELL DONE :) :)");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Point startpiont = panel1.Location;
            Cursor.Position = PointToScreen(startpiont);
        }
    }
}
