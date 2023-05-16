using static Task_1._2.Class1;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Apple", 1.99);
            Product product2 = new Product("Banana", 0.99);

            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            cart.DisplayCartContents();
            double totalPrice = cart.CalculateTotalPrice();
            Console.WriteLine($"Total Price: ${totalPrice}");

            Console.ReadLine();
        }
    }
}