namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("число четное");
            else Console.WriteLine("число нечетное");
        }
    }
}