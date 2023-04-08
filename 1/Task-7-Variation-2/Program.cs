namespace Task_7_Variation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilo = 0.435;
            int funts = 1;
            do
            {
                Console.WriteLine("{0} фунтов = {1:F2} килограмм", funts, kilo * funts);
                funts++;
            }
            while (funts < 100);
        }
    }
}