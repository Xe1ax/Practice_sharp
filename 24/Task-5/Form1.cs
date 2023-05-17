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
            DialogResult result = MessageBox.Show("Вы уверены, что хотите видеть, что за этой кнопкой?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Мы вас предупредили...");

                Form2 form2 = new Form2();

                form2.Show();
            }
            else
            {
                MessageBox.Show("Ну ладно...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Да ладно, именно эту??", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Мм, ладно....");

                Form2 form2 = new Form2();

                form2.Show();

                MessageBox.Show("Все-равно мы будем смотреть на капибару))");
            }
            else
            {
                MessageBox.Show("Эх...");
            }
        }
    }
}

