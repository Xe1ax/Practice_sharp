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
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        public AddItemWindow()
        {
            InitializeComponent();
        }

        public event EventHandler ItemAdded;

        public string XmlFilePath;

        public AddItemWindow(string XmlFilePath)
        {
            InitializeComponent();
            this.XmlFilePath = XmlFilePath;
        }


        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string price = PriceTB.Text;
            string expirationDate = ExpirationDateTB.Text;
            string productName = ProductNameTB.Text;

            if (!string.IsNullOrEmpty(price) && !string.IsNullOrEmpty(expirationDate) && !string.IsNullOrEmpty(productName))
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);

                XElement newItem = new XElement("Студенты",
                    new XElement("Фамилия", productName),
                    new XElement("Имя", expirationDate),
                    new XElement("Датарождения", price));

                xmlDoc.Root.Add(newItem);

                xmlDoc.Save(XmlFilePath);

                ItemAdded?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            else
            {
            }

        }
    }
}
