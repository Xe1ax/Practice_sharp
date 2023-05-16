using Task_1._1;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine("Triangle:");
            Console.WriteLine($"Side A: {triangle.SideA}");
            Console.WriteLine($"Side B: {triangle.SideB}");
            Console.WriteLine($"Side C: {triangle.SideC}");
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Type: {triangle.DetermineTriangleType()}");

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(5, 7);

            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Width: {rectangle.Width}");
            Console.WriteLine($"Height: {rectangle.Length}");
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}