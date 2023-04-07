namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.7;
            double y = (20 * Math.Log(Math.Cos(Math.Pow(x, double.E))) - (Math.Sqrt(Math.Pow(3, Math.Sin(Math.PI)) + Math.Abs(1 - Math.Pow(3, x)))));
            Console.WriteLine(y);
        }
    }
}