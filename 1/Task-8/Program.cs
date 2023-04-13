namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 2 * i - 1;
                Console.WriteLine(sum);
            }
        }
    }
}