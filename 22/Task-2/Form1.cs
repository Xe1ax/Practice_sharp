using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            string outputText = string.Format("x = {0}\r\ny = {1}\r\nz = {2}", x, y, z);
            textBox4.Text = outputText;

            if (radioButton1.Checked)
            {
                double q = ((Math.Max(Math.Sinh(x) + y + z, x * y * z)) / (Math.Min(Math.Sinh(x) + y + z, x * y * z)));
                textBox4.Text += "\r\nРезультат = " + q.ToString();
            } 
            else if (radioButton2.Checked)
            {
                double q = ((Math.Max(Math.Pow(x, 2) + y + z, x * y * z)) / (Math.Min(Math.Pow(x, 2) + y + z, x * y * z)));
                textBox4.Text += "\r\nРезультат = " + q.ToString();
            }
            else if (radioButton3.Checked)
            {
                double q = ((Math.Max(Math.Exp(x) + y + z, x * y * z)) / (Math.Min(Math.Exp(x) + y + z, x * y * z)));
                textBox4.Text += "\r\nРезультат = " + q.ToString();
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
