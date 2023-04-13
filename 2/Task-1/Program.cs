namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int numbA = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int numbB = int.Parse(Console.ReadLine());

            A a = new A(numbA, numbB);
            a.Print(numbA, numbB);
        }
    }
}