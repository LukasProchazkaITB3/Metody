using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Vzdalenost(double aX, double aY, double bX, double bY)
        {
            double x = Math.Abs(aX - bX);
            double y = Math.Abs(aY - bY);

            double vysl = Math.Sqrt((x * x) + (y * y));

            return vysl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double aX = Convert.ToInt32(textBox1.Text.ToString());
            double aY = Convert.ToInt32(textBox2.Text.ToString());
            double bX = Convert.ToInt32(textBox3.Text.ToString());
            double bY = Convert.ToInt32(textBox4.Text.ToString());

            label1.Text = Vzdalenost(aX, aY, bX, bY).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
