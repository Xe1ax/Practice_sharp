namespace Task_3
{
 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            Thread t1 = new Thread(() => Sum(a, n));
            Thread t2 = new Thread(() => Multiply(a, n));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Главный поток завершил работу");
            Console.ReadKey();
        }

        static void Sum(int a, int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += a;
                Console.WriteLine($"Поток 1: промежуточный результат = {result}");
                Thread.Sleep(1000); 
            }
            Console.WriteLine($"Поток 1: итоговый результат = {result}");
        }

        static void Multiply(int a, int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= a;
                Console.WriteLine($"Поток 2: промежуточный результат = {result}");
                Thread.Sleep(1000); 
            }
            Console.WriteLine($"Поток 2: итоговый результат = {result}");
        }
    }
}