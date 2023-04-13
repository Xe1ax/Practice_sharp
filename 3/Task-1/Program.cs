namespace Task_1
{
         class Program
        {
            static double max(double a, double b)
            {
                return (a > b) ? a : b;
            }

            static void Main(string[] args)
            {
                Console.Write("Введите x : ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите y : ");
                double y = double.Parse(Console.ReadLine());
                double z = max(x, 2 * y - x) + max(5 * x + 3 * y, y);
                Console.WriteLine($"z = {z}");
            }
        }
    } 

