using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private List<Point> points = new List<Point>(); // ������ ����� ��� ����������� ����
        private Random random = new Random(); // ��������� ��������� ����� ��� ������
        private int x1, y1, x2, y2;
        private double a, t, fi;
        private Pen pen = new Pen(Color.DarkRed, 2);

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // ���������� ���������� ������� Load
            this.Paint += Form1_Paint; // ���������� ���������� ������� Paint

            timer1.Interval = 10; // ������������� �������� ������� (� �������������)
            timer1.Tick += timer1_Tick; // ���������� ���������� ������� Tick
            timer1.Start(); // ��������� ������

            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            a = 150;
            fi = -0.5;
            t = Math.Sin(fi);
            x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t));

            this.BackColor = Color.White; // ��������� ����� ���� �����
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ������ �����, ����������� ����� � ������ points
            for (int i = 1; i < points.Count; i++)
            {
                Color lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Pen linePen = new Pen(lineColor, 2);
                g.DrawLine(linePen, points[i - 1], points[i]);
            }

            // ������ ������� ������� � ���� �����
            g.DrawEllipse(pen, x2, y2, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fi += 0.05; // ���������� ���� ��������� ����
            t = Math.Tan(fi);
            x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
            y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t));

            // ��������� ������� ������� � ������ points
            points.Add(new Point(x2 + 10, y2 + 10));

            // ������������ ���������� �����, ����� �� �������� ������� ������� ����
            if (points.Count > 100)
            {
                points.RemoveAt(0);
            }

            Invalidate();
        }
    }
}

