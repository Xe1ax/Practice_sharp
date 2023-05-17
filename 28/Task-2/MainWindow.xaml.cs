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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Получение контекста рисования
            var drawingVisual = new DrawingVisual();
            using (var drawingContext = drawingVisual.RenderOpen())
            {
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

                    // Заполнение прямоугольника прозрачным цветом
                    drawingContext.DrawRectangle(transparentBrush, pen, rectangle);
                }
            }

            // Добавление объекта DrawingVisual в элемент управления WPF
            myCanvas.Children.Add(new DrawingVisualHost(drawingVisual));
        }
    }

    // Вспомогательный класс для отображения DrawingVisual в элементе управления WPF
    public class DrawingVisualHost : UIElement
    {
        private readonly Visual _visual;

        public DrawingVisualHost(Visual visual)
        {
            _visual = visual;
        }

        protected override int VisualChildrenCount => 1;

        protected override Visual GetVisualChild(int index)
        {
            return _visual;
        }
    }
}