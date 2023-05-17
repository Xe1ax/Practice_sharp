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

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            ShowShapeWindow("Треугольник");
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            ShowShapeWindow("Круг");
        }

        private void PyramidButton_Click(object sender, RoutedEventArgs e)
        {
            ShowShapeWindow("Пирамида");
        }

        private void ShowShapeWindow(string shapeName)
        {
            var shapeWindow = new Window
            {
                Title = "Это " + shapeName + "!",
                Width = 300,
                Height = 200,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            var label = new Label
            {
                Content = "Это " + shapeName + "!",
                FontSize = 24,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            shapeWindow.Content = label;
            shapeWindow.ShowDialog();
        }
    }
}



