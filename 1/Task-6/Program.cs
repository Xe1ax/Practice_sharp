namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст:");
            double age = Double.Parse(Console.ReadLine());
            if (age < 1) Console.WriteLine("Младенец");
            if (age < 11 && age > 1) Console.WriteLine("Ребенок");
            if (age < 15 && age > 12) Console.WriteLine("Подросток");
            if (age < 25 && age > 16) Console.WriteLine("Юноша");
            if (age < 70 && age > 26) Console.WriteLine("Мужчина");
            if (age < 116  && age > 71) Console.WriteLine("Старик");
            if (age < double.PositiveInfinity && age > 117) Console.WriteLine("Прах");
        }
    }
}