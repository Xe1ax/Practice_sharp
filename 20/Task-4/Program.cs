namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 54, 17, 25, 66 };
            CancellationTokenSource cts = new CancellationTokenSource();

            try
            {
                Parallel.ForEach(numbers, new ParallelOptions { CancellationToken = cts.Token }, (number) =>
                {
                    int result = Sum(number);
                    Console.WriteLine($"Сумма чисел от 0 до {number} = {result}");

                    if (result > 100)
                    {
                        cts.Cancel();
                    }
                });
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Выполнение было прервано.");
            }

            Console.ReadLine();
        }

        static int Sum(int n)
        {
            int result = 0;

            for (int i = 0; i <= n; i++)
            {
                result += i;
            }

            return result;
        }

        static long Product(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}