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

namespace task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Button> createdButtons;
        public MainWindow()
        {
            InitializeComponent();
            createdButtons = new List<Button>();

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            if (!createdButtons.Contains(button))
            {
                Button newButton = new Button
                {
                    Content = "click",
                    Width = 100,
                    Height = 30,
                    Margin = new Thickness(0, 10, 0, 0)
                };

                newButton.MouseEnter += Button_MouseEnter;
                newButton.Click += Button_Click;

                createdButtons.Add(newButton);
                buttonPanel.Children.Add(newButton);
            }
        }
        private void NewButton_MouseEnter(object sender, MouseEventArgs e)
        {
            // Ничего не делаем при наведении на созданные кнопки
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            createdButtons.Remove(button);
            buttonPanel.Children.Remove(button);
        }
    }
    
}
