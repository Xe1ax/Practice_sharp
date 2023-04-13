namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter number a: ");
            int numbA = int.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            int numbB = int.Parse(Console.ReadLine());

            A a = new A(numbA, numbB);
            a.Print(numbA, numbB);
        }
    }
}