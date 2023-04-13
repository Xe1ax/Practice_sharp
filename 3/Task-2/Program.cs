namespace Task_2
{
    class Program
    {
        static double f(double x, double a)
        {
            double y;
            if (x < a) y = 0;
            else if (x > a) y = (x - a) / (x + a);
            else y = 1;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите а : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите h : ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
            Console.WriteLine($"f({i:f2}) = {f(i):f4}") ;
        }
    }
}