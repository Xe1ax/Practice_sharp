namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxThreads = 2;

            object lockObject = new object();

            Thread[] threads = new Thread[maxThreads];

            for (int i = 0; i < maxThreads; i++)
            {
                threads[i] = new Thread(() =>
                {
                    int sum = 0;
                    for (int j = 1; j <= 10; j++)
                    {
                        sum += j;
                        Thread.Sleep(100);
                    }

                    lock (lockObject)
                    {
                        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: сумма чисел от 1 до 10 = {sum}");
                    }
                });

                threads[i].Start();
            }

            for (int i = 0; i < maxThreads; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("Работа всех потоков завершена.");
            Console.ReadLine();
        }
    }
}