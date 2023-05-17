using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Определение параметров рисования
            var pen = new Pen(Brushes.Black, 1);
            var transparentBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

            // Начало координат
            var startPoint = new Point(10, 10);

            // Размеры прямоугольников
            var rectangleWidth = 40;
            var rectangleHeight = 70;

            // Рисование 5 прямоугольников
            for (int i = 0; i < 5; i++)
            {
                // Определение координат прямоугольника
                var topLeft = new Point(startPoint.X + i * rectangleWidth, startPoint.Y + i * rectangleHeight);
                var rectangle = new Rect(topLeft, new Size(rectangleWidth + 30, rectangleHeight + 30));

                // Создание объекта прямоугольника
                var rectShape = new Rectangle();
                rectShape.Width = rectangle.Width;
                rectShape.Height = rectangle.Height;
                rectShape.Fill = transparentBrush;
                rectShape.Stroke = pen.Brush;
                rectShape.StrokeThickness = pen.Thickness;

                // Добавление прямоугольника на Canvas
                myCanvas.Children.Add(rectShape);
                Canvas.SetLeft(rectShape, rectangle.Left);
                Canvas.SetTop(rectShape, rectangle.Top);
            }
        }
    }
}

