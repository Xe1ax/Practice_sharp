namespace Task_2
{
    delegate double CalcDelegate(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            CalcDelegate add = (a, b) => a + b;
            CalcDelegate sub = (a, b) => a - b;
            CalcDelegate mul = (a, b) => a * b;
            CalcDelegate div = (a, b) => b == 0 ? double.NaN : a / b;

            Console.Write("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Результаты арифметических операций:");

            Console.WriteLine($"Сумма: {add(x, y)}");
            Console.WriteLine($"Разность: {sub(x, y)}");
            Console.WriteLine($"Произведение: {mul(x, y)}");
            Console.WriteLine($"Частное: {div(x, y)}");

            Console.ReadKey();
        }
    }
}