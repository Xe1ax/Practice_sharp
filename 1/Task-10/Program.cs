namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for(int i = 10 ; i < 100 ; i++)
            {
                a = i / 10;
                b = i % 10;
                c = a * a + b * b;
                if (c % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}