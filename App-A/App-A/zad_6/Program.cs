namespace zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Первое число: {0}",(num / 100));
            Console.WriteLine("Последнее число: {0}", num % 10);
        }
    }
}