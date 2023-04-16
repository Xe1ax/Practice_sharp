namespace Task_1_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());
                double y = ((Math.Pow(x, 3) - 2) / x + 10) + 4 * x;
                Console.WriteLine("Sucsess");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: wrong type!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: divide by 0!");
            }
        }
    }
}