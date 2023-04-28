namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = CalculateFn(n);
            Console.WriteLine("f({0}) = {1}", n, result);
        }
        static double CalculateFn(int n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            else
            {
                double fnMinus1 = CalculateFn(n - 1);
                return fnMinus1 / (n + 1);
            }
        }
    }
}