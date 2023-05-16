namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -7;
            double b = 3;
            int n = 1000;
            double[] results = new double[n];

            Parallel.For(0, n, i =>
            {
                double x = a + (b - a) * i / (n - 1);
                results[i] = Math.Cos(x);
            });

            Console.WriteLine("Результаты:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Cos({0:F2}) = {1:F4}", a + (b - a) * i / (n - 1), results[i]);
            }
        }
    }
}