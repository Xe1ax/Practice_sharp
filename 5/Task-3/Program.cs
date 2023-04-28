namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the matrix (N < 10): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the range of random numbers (a, b): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the interval for computing the product (C, D): ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(a, b + 1);
                }
            }

            Console.WriteLine("Original matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int product = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] >= c && matrix[i, j] <= d)
                    {
                        product *= matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Product of numbers in the interval [{c}, {d}] is {product}");

            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}