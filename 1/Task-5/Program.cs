namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double a = double.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Число четное");
            else Console.WriteLine("Число нечетное");
        }
    }
}