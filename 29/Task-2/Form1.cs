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
                // �������� ��������
                bannerImage = new Bitmap("banner.png");
            }
            catch (Exception e)
            {
                // � ������ ������ �������� ����� �������
                MessageBox.Show("������ �������� ����� �������\n" + e.ToString(), "������");
            }

            bannerPosition = 0;

            // ��������� ��������� ������� (� �������������)
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isMouseOverBanner) // ���������, ���� ������ ���� �� ��������� ��� ��������
            {
                // ���������� ������� ��������
                bannerPosition -= 5;

                // ���� ������� ����������� ������� "������" �� ����� ������� �����,
                // �� ���������� �� �������
                if (bannerPosition + bannerImage.Width < 0)
                {
                    bannerPosition = ClientSize.Width;
                }

                // ����������� �����
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // ��������� ��������
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

