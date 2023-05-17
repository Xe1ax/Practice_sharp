using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private const int RocketSpeed = 10; // �������� ����������� ������

        private Panel backgroundPanel;
        private PictureBox rocketImage;
        private PictureBox redButton;
        private System.Windows.Forms.Timer animationTimer;

        private int rocketX;
        private int rocketY;

        public Form1()
        {
            InitializeComponent();

            // �������� � ��������� ������ �������� �����������
            // �������� � ��������� ������ �������� �����������
            backgroundPanel = new Panel();
            backgroundPanel.BackColor = Color.Transparent; // ��������� ����������� ����� ����
            backgroundPanel.Size = ClientSize;
            Controls.Add(backgroundPanel);


            // �������� � ��������� ����������� ������
            rocketImage = new PictureBox();
            rocketImage.Image = Image.FromFile("Rocket.png");
            rocketImage.Size = rocketImage.Image.Size;
            rocketX = (ClientSize.Width - rocketImage.Width) / 2; // ��������� ������ �� ������ �� �����������
            rocketY = ClientSize.Height - rocketImage.Height; // ��������� ������ ����� �����
            rocketImage.Location = new Point(rocketX, rocketY);
            rocketImage.Visible = false; // �������� ������ ������
            backgroundPanel.Controls.Add(rocketImage);

            // �������� � ��������� ������
            int desiredWidth = 200;
            int desiredHeight = 200;
            redButton = new PictureBox();
            redButton.Image = Image.FromFile("RedButton.png");
            redButton.SizeMode = PictureBoxSizeMode.StretchImage;
            redButton.Size = new Size(desiredWidth, desiredHeight);
            redButton.Location = new Point((backgroundPanel.Width - redButton.Width) / 2, (backgroundPanel.Height - redButton.Height) / 2);
            backgroundPanel.Controls.Add(redButton);
            redButton.Click += RedButton_Click;

            // �������� � ��������� ������� ��������
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 20; // �������� ���������� �������� (20 �����������)
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            // ��� ������� ������ "�������" ������ ����������, � ������ ���������� �������
            redButton.Visible = false;
            rocketImage.Visible = true;

            // ������ ������� ��������
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // ���������� ��������� ������
            rocketY -= RocketSpeed;

            // ���� ������ �������� ������� ������� �����, ������������� ��������
            if (rocketY + rocketImage.Height < 0)
            {
                animationTimer.Stop();
                MessageBox.Show("�������!");

                // ���������� ���������
                Application.Restart();
                Environment.Exit(0); // ������������� ����� ������� Environment.Exit(0), ����� ���������� ��������� ������� �������
            }

            // ���������� ��������� ������
            rocketImage.Location = new Point(rocketX, rocketY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

