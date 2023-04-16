namespace Task_1_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());
                double y = Math.Log10(x) + (Math.Cos(x) / x + 6);
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