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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Практическая работа 22, Группа: 37тп, Дереченик Алексей";
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            string outputText = string.Format("\r\nx ={0}\r\ny ={1}\r\nz ={2}", x, y, z);
            textBox4.Text += outputText;

            double g = ((Math.Pow(y, x + 1)) / (Math.Pow(Math.Sqrt(Math.Abs(y-2) + 3), 3) + ((x + y/2) / (2*Math.Abs(x + y)))* Math.Pow(x+1, -1/Math.Sin(z))));;
            textBox4.Text += "\r\nРезультат = " + g.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
