namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius = 5;
            int height = 10;
            Console.WriteLine("площадь поверхности циллиндра : {0}", (Math.Pow(2, Math.PI) * radius * height));
        }
    }
}