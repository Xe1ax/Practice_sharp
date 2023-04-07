namespace zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число альфа: ");
            double alfa = Double.Parse(Console.ReadLine());
            Console.WriteLine("z1 = {0}", ((((Math.Sin(4 * alfa))) / (1 + Math.Cos(4 * alfa))) * ((Math.Cos(2 * alfa))/(1 + Math.Cos(2 * alfa)))));
            Console.WriteLine("z2 = {0}", (1 / Math.Tan((3 / 2) * Math.PI - alfa)));
        }
    }
}