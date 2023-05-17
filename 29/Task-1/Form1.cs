using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int centerX;
        int centerY;
        int radius;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.DoubleBuffered = true;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;
            radius = Math.Min(centerX, centerY) - 20;

            // Отрисовка круга с синей окантовкой
            Pen circlePen = new Pen(Color.Blue, 5);
            g.DrawEllipse(circlePen, centerX - radius, centerY - radius, radius * 2, radius * 2);

            // Отрисовка цифр
            Font numberFont = new Font("Arial", 12, FontStyle.Bold);
            Brush numberBrush = Brushes.Black;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            for (int i = 1; i <= 12; i++)
            {
                double angle = 2 * Math.PI * i / 12;
                int x = (int)(centerX + (radius - 20) * Math.Sin(angle));
                int y = (int)(centerY - (radius - 20) * Math.Cos(angle));
                Rectangle numberRect = new Rectangle(x - 10, y - 10, 20, 20);
                string numberText = i.ToString();
                SizeF textSize = g.MeasureString(numberText, numberFont);
                PointF textPosition = new PointF(numberRect.Left + (numberRect.Width - textSize.Width) / 2, numberRect.Top + (numberRect.Height - textSize.Height) / 2);
                g.DrawString(numberText, numberFont, numberBrush, textPosition);
            }


            // Отрисовка стрелок
            DateTime now = DateTime.Now;
            int second = now.Second;
            int minute = now.Minute;
            int hour = now.Hour % 12;

            DrawHand(g, centerX, centerY, radius * 0.85, second * 6, new Pen(Color.Red, 4));
            DrawHand(g, centerX, centerY, radius * 0.7, minute * 6, new Pen(Color.Black, 5));
            DrawHand(g, centerX, centerY, radius * 0.5, hour * 30 + minute / 2, new Pen(Color.Black, 6));
        }

        private void DrawHand(Graphics g, int centerX, int centerY, double length, double angle, Pen pen)
        {
            double radians = (angle - 90) * Math.PI / 180;
            int x = (int)(centerX + length * Math.Cos(radians));
            int y = (int)(centerY + length * Math.Sin(radians));
            g.DrawLine(pen, centerX, centerY, x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


