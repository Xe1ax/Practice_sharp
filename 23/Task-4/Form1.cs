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

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);

            if (textBox1.Text.Contains("К"))
            {
                Button button = new Button();
                button.Location = new Point(x, y);
                button.Text = "Кнопка";
                button.BackColor = Color.Yellow;
                button.Size = new Size(100, 50);
                this.Controls.Add(button);
                button.MouseHover += (s, ev) => this.Controls.Remove(button);
            }
            else if (textBox1.Text.Contains("П"))
            {
                TextBox textbox = new TextBox();
                textbox.Location = new Point(x, y);
                textbox.Text = "Текстовое поле";
                textbox.BackColor = Color.LightBlue;
                textbox.Size = new Size(100, 50);
                this.Controls.Add(textbox);
                textbox.MouseHover += (s, ev) => this.Controls.Remove(textbox);
            }
            else if (textBox1.Text.Contains("М"))
            {
                Label label = new Label();
                label.Location = new Point(x, y);
                label.Text = "Метка";
                label.BackColor = Color.LightGreen;
                label.Size = new Size(100, 50);
                this.Controls.Add(label);
                label.MouseHover += (s, ev) => this.Controls.Remove(label);
            }
        }
    }
}
