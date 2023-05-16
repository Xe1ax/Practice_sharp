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
            // Создаем объект Graphics для рисования на форме
            Graphics g = this.CreateGraphics();

            // Задаем цвет заливки и создаем эллипс для верхней части арбуза
            Brush brush = new SolidBrush(Color.Green);
            RectangleF rect = new RectangleF(30, 30, 200, 150);
            g.FillEllipse(brush, rect);

            // Создаем треугольник для стебля арбуза
            Point[] points = new Point[3];
            points[0] = new Point(130, 10);
            points[1] = new Point(180, 60);
            points[2] = new Point(80, 60);
            g.FillPolygon(Brushes.Green, points);

            // Задаем цвет контура и создаем эллипс для нижней части арбуза
            Pen pen = new Pen(Color.Black, 4);
            g.DrawEllipse(pen, rect);

            // Создаем два прямоугольника для рисования полосок на арбузе
            Rectangle rect1 = new Rectangle(55, 55, 25, 100);
            Rectangle rect2 = new Rectangle(100, 55, 25, 100);
            Rectangle rect3 = new Rectangle(145, 55, 25, 100);
            Brush stripBrush = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(stripBrush, rect1);
            g.FillRectangle(stripBrush, rect2);
            g.FillRectangle(stripBrush, rect3);
            g.DrawRectangle(pen, rect1);
            g.DrawRectangle(pen, rect2);
            g.DrawRectangle(pen, rect3);
        }
    }
}
