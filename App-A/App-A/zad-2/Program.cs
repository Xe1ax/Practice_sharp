namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string numRev = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                numRev += num[i];
            }
            Console.WriteLine(numRev);
        }
    }
}