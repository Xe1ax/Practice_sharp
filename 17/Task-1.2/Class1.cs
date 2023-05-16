using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_1._2
{
    public class Class1
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Product(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }

        public class ShoppingCart
        {
            private List<Product> products;

            public ShoppingCart()
            {
                products = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                products.Add(product);
            }

            public void RemoveProduct(Product product)
            {
                products.Remove(product);
            }

            public double CalculateTotalPrice()
            {
                double totalPrice = 0;
                foreach (var product in products)
                {
                    totalPrice += product.Price;
                }
                return totalPrice;
            }

            public void DisplayCartContents()
            {
                Console.WriteLine("Shopping Cart Contents:");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Name} - ${product.Price}");
                }
            }
        }
    }
}