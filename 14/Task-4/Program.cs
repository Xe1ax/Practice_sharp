namespace Task_4
{
    class Program
    {
        static int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int numThreads = 2;
        static int[] partialSums;
        static Thread[] threads;

        static void Main(string[] args)
        {
            partialSums = new int[numThreads];
            threads = new Thread[numThreads];
            int chunkSize = arr.Length / numThreads;

            for (int i = 0; i < numThreads; i++)
            {
                int threadNum = i;
                threads[i] = new Thread(() =>
                {
                    int start = threadNum * chunkSize;
                    int end = (threadNum == numThreads - 1) ? arr.Length : start + chunkSize;
                    int sum = 0;

                    for (int j = start; j < end; j++)
                    {
                        if (arr[j] % 2 == 0)
                        {
                            sum += arr[j];
                        }
                    }

                    partialSums[threadNum] = sum;
                });

                threads[i].Start();
            }

            foreach (var t in threads)
            {
                t.Join();
            }

            int totalSum = 0;
            foreach (int s in partialSums)
            {
                totalSum += s;
            }

            Console.WriteLine("Сумма четных чисел: " + totalSum);
            Console.ReadLine();
        }
    }
}