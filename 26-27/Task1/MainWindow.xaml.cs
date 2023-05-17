using Microsoft.Win32;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string XmlFilePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                XmlFilePath = filePath;

                string fileName = System.IO.Path.GetFileName(filePath);
                XmlDocName.Text = fileName;

                // Обработка XML-документа
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);

                // Получение содержимого XML
                XmlNodeList products = xmlDocument.GetElementsByTagName("Студенты");

                if (radioButton1.IsChecked == true)
                {
                    // Формирование списка строк для ListBox
                    List<string> productList = new List<string>();
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName}, Имя: {expirationDate}, Дата рождения: {price}";
                        productList.Add(productInfo);
                    }


                    // Присвоение содержимого ListBox
                    XmlDocView.ItemsSource = productList;
                }

                if (radioButton2.IsChecked == true)
                {
                    // Формирование списка строк для ListBox
                    List<string> productList = new List<string>();
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName},\n    Имя: {expirationDate},\n       Дата рождения: {price}\n";
                        productList.Add(productInfo);
                    }


                    // Присвоение содержимого ListBox
                    XmlDocView.ItemsSource = productList;
                }

                if(radioButton3.IsChecked == true)
                {
                    // Формирование списка строк для ListBox
                    List<string> productList = new List<string>();
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName},\n\r Имя: {expirationDate},\n\r Дата рождения: {price}\n\r";
                        productList.Add(productInfo);
                    }


                    // Присвоение содержимого ListBox
                    XmlDocView.ItemsSource = productList;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создание экземпляра AddItemWindow
            AddItemWindow addItemWindow = new AddItemWindow();

            addItemWindow.XmlFilePath = XmlFilePath;
            addItemWindow.ItemAdded += AddItemWindow_ItemAdded;

            // Открытие окна AddItemWindow
            addItemWindow.ShowDialog();
        }


        private void AddItemWindow_ItemAdded(object sender, EventArgs e)
        {
            UpdateXmlDocView();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Получить выбранный элемент ListBox
            var selectedItem = XmlDocView.SelectedItem as string;

            // Проверить, что элемент выбран
            if (selectedItem != null)
            {
                try
                {
                    // Создать экземпляр XmlDocument
                    XmlDocument xmlDoc = new XmlDocument();

                    // Загрузить XML-документ из файла
                    xmlDoc.Load(XmlFilePath);

                    // Найти элемент для удаления
                    XmlNodeList products = xmlDoc.GetElementsByTagName("Студенты");
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName}, Имя: {expirationDate}, Дата рождения: {price}";

                        if (productInfo == selectedItem)
                        {
                            // Удалить найденный элемент
                            productNode.ParentNode.RemoveChild(productNode);
                            break;
                        }
                    }

                    // Сохранить изменения обратно в файл
                    xmlDoc.Save(XmlFilePath);

                    // Обновить содержимое ListBox
                    UpdateXmlDocView();
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при удалении элемента
                    MessageBox.Show("Ошибка удаления элемента: " + ex.Message);
                }
            }
        }

        private void UpdateXmlDocView()
        {
            // Обновление содержимого ListBox после удаления элемента
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFilePath);

            // Получение содержимого XML
            XmlNodeList products = xmlDocument.GetElementsByTagName("Студенты");

            // Формирование списка строк для ListBox
            List<string> productList = new List<string>();
            foreach (XmlNode productNode in products)
            {
                string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                string price = productNode.SelectSingleNode("Датарождения").InnerText;

                string productInfo = $"Фамилия: {productName}, Имя: {expirationDate}, Дата рождения: {price}";
                productList.Add(productInfo);
            }

            // Присвоение содержимого ListBox
            XmlDocView.ItemsSource = productList;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchTextBox.Text.ToLower();

            // Пройти по каждому элементу ListBox и проверить название товара
            foreach (var listBoxItem in XmlDocView.Items)
            {
                var listBoxItemContainer = XmlDocView.ItemContainerGenerator.ContainerFromItem(listBoxItem) as ListBoxItem;
                string productInfo = listBoxItem.ToString().ToLower();

                // Если название товара содержит искомую фразу
                if (productInfo.Contains(searchQuery))
                {
                    // Пометить элемент как выбранный
                    listBoxItemContainer.IsSelected = true;

                    // Прокрутить к выбранному элементу
                    XmlDocView.ScrollIntoView(listBoxItem);
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void XmlDocView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}