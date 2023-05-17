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

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);

                XmlNodeList products = xmlDocument.GetElementsByTagName("Студенты");

                if (radioButton1.IsChecked == true)
                {
                    List<string> productList = new List<string>();
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName}, Имя: {expirationDate}, Дата рождения: {price}";
                        productList.Add(productInfo);
                    }


                    XmlDocView.ItemsSource = productList;
                }

                if (radioButton2.IsChecked == true)
                {
                    List<string> productList = new List<string>();
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName},\n    Имя: {expirationDate},\n       Дата рождения: {price}\n";
                        productList.Add(productInfo);
                    }


                    XmlDocView.ItemsSource = productList;
                }

                if(radioButton3.IsChecked == true)
                {
                    List<string> productList = new List<string>();
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName},\n\r Имя: {expirationDate},\n\r Дата рождения: {price}\n\r";
                        productList.Add(productInfo);
                    }


                    XmlDocView.ItemsSource = productList;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddItemWindow addItemWindow = new AddItemWindow();

            addItemWindow.XmlFilePath = XmlFilePath;
            addItemWindow.ItemAdded += AddItemWindow_ItemAdded;

            addItemWindow.ShowDialog();
        }


        private void AddItemWindow_ItemAdded(object sender, EventArgs e)
        {
            UpdateXmlDocView();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var selectedItem = XmlDocView.SelectedItem as string;

            if (selectedItem != null)
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();

                    xmlDoc.Load(XmlFilePath);

                    XmlNodeList products = xmlDoc.GetElementsByTagName("Студенты");
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                        string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                        string price = productNode.SelectSingleNode("Датарождения").InnerText;

                        string productInfo = $"Фамилия: {productName}, Имя: {expirationDate}, Дата рождения: {price}";

                        if (productInfo == selectedItem)
                        {
                            productNode.ParentNode.RemoveChild(productNode);
                            break;
                        }
                    }

                    xmlDoc.Save(XmlFilePath);

                    UpdateXmlDocView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления элемента: " + ex.Message);
                }
            }
        }

        private void UpdateXmlDocView()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFilePath);

            XmlNodeList products = xmlDocument.GetElementsByTagName("Студенты");

            List<string> productList = new List<string>();
            foreach (XmlNode productNode in products)
            {
                string productName = productNode.SelectSingleNode("Фамилия").InnerText;
                string expirationDate = productNode.SelectSingleNode("Имя").InnerText;
                string price = productNode.SelectSingleNode("Датарождения").InnerText;

                string productInfo = $"Фамилия: {productName}, Имя: {expirationDate}, Дата рождения: {price}";
                productList.Add(productInfo);
            }

            XmlDocView.ItemsSource = productList;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchTextBox.Text.ToLower();

            foreach (var listBoxItem in XmlDocView.Items)
            {
                var listBoxItemContainer = XmlDocView.ItemContainerGenerator.ContainerFromItem(listBoxItem) as ListBoxItem;
                string productInfo = listBoxItem.ToString().ToLower();

                if (productInfo.Contains(searchQuery))
                {
                    listBoxItemContainer.IsSelected = true;

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

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}