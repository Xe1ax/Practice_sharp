namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число килограмм: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Тонн : {0} ", m / 1000);
        }
    }
}