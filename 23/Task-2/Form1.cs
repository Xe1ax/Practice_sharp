using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            // Очищаем график
            chart1.Series.Clear();

            // Добавляем новый ряд данных
            Series series = chart1.Series.Add("sin(x)*cos(x)");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;

            // Задаем параметры настройки графика
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 2 * Math.PI;
            chart1.ChartAreas[0].AxisX.Interval = 0.5 * Math.PI;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "sin(x)*cos(x)";

            // Задаем шаг для изменения параметра x
            double h;
            if (!double.TryParse(textBox1.Text, out h))
            {
                MessageBox.Show("Введите корректное значение шага!");
                return;
            }

            // Добавляем точки на график
            for (double x = 0; x <= 2 * Math.PI; x += h)
            {
                double y = Math.Sin(x) * Math.Cos(x);
                series.Points.AddXY(x, y);
            }
        }
    }
}
