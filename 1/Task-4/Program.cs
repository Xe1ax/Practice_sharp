namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x,y;
            x2:
            x = double.Parse(Console.ReadLine());
            if (x < 1.3) Console.WriteLine("y = {0}", y = (Math.PI * Math.Pow(2, x) - (7 / Math.Sqrt(Math.Abs(x)))));
            else if (x == 1.3) Console.WriteLine("y = {0}", y = (3 * x - Math.Pow(2, Math.Cos(x))));
            else {
                Console.WriteLine("Читай условие аболтус");
                    goto x2; };
            
        }
    }
}