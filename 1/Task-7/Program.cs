namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilo = 0.435;
            int funts;
            for (funts = 1; funts <= 100; funts++)
            {
                Console.WriteLine("{0} фунтов = {1:F2} килограмм", funts,kilo * funts);
            }
        }
    }
}