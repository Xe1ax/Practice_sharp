namespace Task_1
{
    delegate double CalcFigure(double R);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности: ");
            double radius = double.Parse(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            Console.WriteLine($"Длина окружности с радиусом {radius} = {CF(radius)}");

            CF = new CalcFigure(Get_Area);
            Console.WriteLine($"Площадь круга с радиусом {radius} = {CF(radius)}");

            CF = new CalcFigure(Get_Volume);
            Console.WriteLine($"Объем шара с радиусом {radius} = {CF(radius)}");
        }

        static double Get_Length(double R)
        {
            return 2.0 * Math.PI * R;
        }

        static double Get_Area(double R)
        {
            return Math.PI * R * R;
        }

        static double Get_Volume(double R)
        {
            return 4.0 / 3.0 * Math.PI * R * R * R;
        }
    }
}