namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и B:");
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            int n = 0;

            for (int i = b - 1; i > a; i--)
            {
                Console.WriteLine(i);
                n += 1;
            }
            Console.WriteLine($"Количество чисел от {a} до {b} = {n}");
        }
    }
}