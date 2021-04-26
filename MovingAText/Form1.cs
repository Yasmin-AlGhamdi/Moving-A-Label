using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingAText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X - 1, label1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 1, label1.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 1);
        }
    }
}
