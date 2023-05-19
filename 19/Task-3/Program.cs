using System;

/// <summary>
/// Класс, содержащий методы для вычисления значения функции.
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет значение функции для заданного значения x.
    /// </summary>
    /// <param name="x">Значение аргумента x.</param>
    /// <param name="y">Выходной параметр, в котором будет сохранено значение функции.</param>
    static void f(double x, out double y)
    {
        y = Math.Cos(2 * x) + Math.Sin(x - 3);
    }

    /// <summary>
    /// Вычисляет и выводит значение функции для заданного значения x.
    /// </summary>
    /// <param name="x">Значение аргумента x.</param>
    static void f(double x)
    {
        double y;
        f(x, out y);
        Console.WriteLine($"f({x}) = {y}");
    }

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите значение точки a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение точки b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Вызов метода f(a):");
        f(a);

        Console.WriteLine("Вызов метода f(b):");
        f(b);

        Console.ReadLine();
    }
}