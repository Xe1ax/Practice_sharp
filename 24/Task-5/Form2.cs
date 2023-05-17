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
    public partial class Form2 : Form
    {
        private Image gifImage;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Укажите путь к изображению, которое хотите отобразить
            string imagePath = "D:\\Колледж\\Практика С#\\1 практика\\pract25z3\\task1\\bin\\Debug\\LEHm.gif";

            // Загрузка изображения в PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);

            
        }


    }
}
