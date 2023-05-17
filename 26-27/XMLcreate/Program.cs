using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Создание XML-документа
        XmlDocument xmlDoc = new XmlDocument();

        // Создание корневого элемента "Магазин"
        XmlElement shopElement = xmlDoc.CreateElement("Магазин");
        xmlDoc.AppendChild(shopElement);

        // Массив с информацией о товарах
        string[,] products = {
            { "Молоко", "2023-12-31", "2.99" },
            { "Яблоки", "2023-05-31", "1.49" },
            { "Хлеб", "2023-05-10", "0.99" },
            { "Мясо", "2023-05-15", "4.99" },
            { "Сок", "2023-06-30", "2.49" },
            { "Мороженое", "2023-06-15", "1.99" },
            { "Печенье", "2023-07-31", "0.79" }
        };

        // Добавление 7 элементов товара
        for (int i = 0; i < 7; i++)
        {
            // Создание элемента "Товар"
            XmlElement productElement = xmlDoc.CreateElement("Товар");
            shopElement.AppendChild(productElement);

            // Получение информации о товаре из массива
            string productName = products[i, 0];
            string expirationDate = products[i, 1];
            string price = products[i, 2];

            // Создание элементов "Название", "СрокГодности" и "Стоимость"
            XmlElement nameElement = xmlDoc.CreateElement("Название");
            nameElement.InnerText = productName;
            productElement.AppendChild(nameElement);

            XmlElement expirationDateElement = xmlDoc.CreateElement("СрокГодности");
            expirationDateElement.InnerText = expirationDate;
            productElement.AppendChild(expirationDateElement);

            XmlElement priceElement = xmlDoc.CreateElement("Стоимость");
            priceElement.InnerText = price;
            productElement.AppendChild(priceElement);
        }

        // Сохранение XML-документа в файл
        xmlDoc.Save("магазин.xml");

        Console.WriteLine("XML-файл создан успешно.");
        Console.ReadLine();
    }
}
