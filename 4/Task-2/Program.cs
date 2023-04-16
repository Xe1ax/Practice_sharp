namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());
                double f;
                if ((0 < x) && (x < 1))
                {
                    f = 3 * Math.Pow(x, 2);
                    Console.WriteLine("f(x)=" + f);
                }
                else if (x >= 1)
                {
                    f = x / x - 1;
                    Console.WriteLine("f(x)" + f);
                }
                else throw new Exception("Error: going out of range");    
            }
            catch (Exception fx) 
            {
                Console.WriteLine("Error "+fx.Message);
            }
        }
    }
}