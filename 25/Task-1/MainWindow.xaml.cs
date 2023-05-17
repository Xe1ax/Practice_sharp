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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Привет, ";
            string input = string.Empty;

            if (string.IsNullOrEmpty(textBox.Text)
                || string.IsNullOrWhiteSpace(textBox.Text))
            {
                input = "Мир!";
            }
            else
            {
                input = textBox.Text;
            }
            textBlockHello.Text  = $"{hello} {input}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string filePath = "D:\\Колледж\\Справочка.docx"; // Укажите путь к файлу Word

            try
            {
                // Запуск приложения Word и открытие файла
                System.Diagnostics.Process.Start("WINWORD.EXE", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла Word: " + ex.Message);
            }
        }
    }
}
