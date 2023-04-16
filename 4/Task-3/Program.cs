namespace Task_3
{
    internal class Program
    {
        static void Mean(double x, double y, out double AMean, out double GMean)
        {
            AMean = (x + y) / 2;
            GMean = (x * y);
        }

        static void Main(string[] args)
        {
            double AMean, GMean;
            Console.Write("Enter A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Enter D: ");
            double D = double.Parse(Console.ReadLine());
            Mean(A, B, out AMean, out GMean);
            Console.WriteLine($"Arithmic and Geometric mean of {A} and {B} is {AMean} and {GMean}");
            Mean(A, C, out AMean, out GMean);
            Console.WriteLine($"Arithmic and Geometric mean of {A} and {C} is {AMean} and {GMean}");
            Mean(A, D, out AMean, out GMean);
            Console.WriteLine($"Arithmic and Geometric mean of {A} and {D} is {AMean} and {GMean}");
            Console.ReadKey(true);
        }
    }
}
