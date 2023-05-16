using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.ToLower().Replace(" ", "");
            string reversedText = new string(inputText.Reverse().ToArray());

            if (inputText == reversedText)
            {
                textBox2.Text = "Строка является палиндромом.";
            }
            else
            {
                textBox2.Text = "Строка не является палиндромом.";
            }
        }
    }
}
