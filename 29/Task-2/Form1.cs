using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Bitmap bannerImage;
        private int bannerPosition;
        private bool isMouseOverBanner;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.DoubleBuffered = true;
            this.MouseEnter += new EventHandler(Form1_MouseEnter);
            this.MouseLeave += new EventHandler(Form1_MouseLeave);

            try
            {
                // Загрузка картинки
                bannerImage = new Bitmap("banner.png");
            }
            catch (Exception e)
            {
                // В случае ошибки загрузки файла баннера
                MessageBox.Show("Ошибка загрузки файла баннера\n" + e.ToString(), "Баннер");
            }

            bannerPosition = 0;

            // Установка интервала таймера (в миллисекундах)
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isMouseOverBanner) // Проверяем, если курсор мыши не находится над баннером
            {
                // Увеличение позиции картинки
                bannerPosition -= 5;

                // Если область отображения целиком "уехала" за левую границу формы,
                // то возвращаем ее обратно
                if (bannerPosition + bannerImage.Width < 0)
                {
                    bannerPosition = ClientSize.Width;
                }

                // Перерисовка формы
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Отрисовка картинки
            e.Graphics.DrawImage(bannerImage, bannerPosition, 0);
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverBanner = true;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverBanner = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

