using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private const int RocketSpeed = 10; // Скорость перемещения ракеты

        private Panel backgroundPanel;
        private PictureBox rocketImage;
        private PictureBox redButton;
        private System.Windows.Forms.Timer animationTimer;

        private int rocketX;
        private int rocketY;

        public Form1()
        {
            InitializeComponent();

            // Создание и настройка панели фонового изображения
            // Создание и настройка панели фонового изображения
            backgroundPanel = new Panel();
            backgroundPanel.BackColor = Color.Transparent; // Установка прозрачного цвета фона
            backgroundPanel.Size = ClientSize;
            Controls.Add(backgroundPanel);


            // Создание и настройка изображения ракеты
            rocketImage = new PictureBox();
            rocketImage.Image = Image.FromFile("Rocket.png");
            rocketImage.Size = rocketImage.Image.Size;
            rocketX = (ClientSize.Width - rocketImage.Width) / 2; // Размещаем ракету по центру по горизонтали
            rocketY = ClientSize.Height - rocketImage.Height; // Размещаем ракету внизу формы
            rocketImage.Location = new Point(rocketX, rocketY);
            rocketImage.Visible = false; // Начально ракета скрыта
            backgroundPanel.Controls.Add(rocketImage);

            // Создание и настройка кнопки
            int desiredWidth = 200;
            int desiredHeight = 200;
            redButton = new PictureBox();
            redButton.Image = Image.FromFile("RedButton.png");
            redButton.SizeMode = PictureBoxSizeMode.StretchImage;
            redButton.Size = new Size(desiredWidth, desiredHeight);
            redButton.Location = new Point((backgroundPanel.Width - redButton.Width) / 2, (backgroundPanel.Height - redButton.Height) / 2);
            backgroundPanel.Controls.Add(redButton);
            redButton.Click += RedButton_Click;

            // Создание и настройка таймера анимации
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 20; // Интервал обновления анимации (20 миллисекунд)
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            // При нажатии кнопки "красная" кнопка скрывается, а ракета становится видимой
            redButton.Visible = false;
            rocketImage.Visible = true;

            // Запуск таймера анимации
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Обновление координат ракеты
            rocketY -= RocketSpeed;

            // Если ракета достигла верхней границы формы, останавливаем анимацию
            if (rocketY + rocketImage.Height < 0)
            {
                animationTimer.Stop();
                MessageBox.Show("Поехали!");

                // Перезапуск программы
                Application.Restart();
                Environment.Exit(0); // Дополнительно можно вызвать Environment.Exit(0), чтобы немедленно завершить текущий процесс
            }

            // Обновление положения ракеты
            rocketImage.Location = new Point(rocketX, rocketY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

