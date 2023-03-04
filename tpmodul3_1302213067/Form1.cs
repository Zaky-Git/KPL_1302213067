using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul3_1302213067
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "Submit/Kirim";

            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.BackColor = Color.White;

            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Dock = DockStyle.None;


        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Halo " + textBox1.Text;
        }
    }
}
