using System.Runtime.CompilerServices;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x и y:");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1 четверть");
            }
            else if (x< 0 && y > 0) 
            {
                Console.WriteLine("2 четверть");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3 четверть");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4 четверть");
            }
            else { Console.WriteLine("Координаты равны нулю"); }
        }
    }
}