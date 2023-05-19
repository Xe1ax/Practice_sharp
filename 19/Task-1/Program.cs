using System;

/// <summary>
/// Класс, демонстрирующий вычисления для фигуры.
/// </summary>
public class Program
{
    /// <summary>
    /// Делегат для вычисления параметров фигуры.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Результат вычисления.</returns>
    public delegate double CalcFigure(double radius);

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        CalcFigure CF = Get_Length;
        double radius = 5.0;

        double length = CF(radius);
        Console.WriteLine("Длина окружности: " + length);

        CF = Get_Area;

        double area = CF(radius);
        Console.WriteLine("Площадь круга: " + area);

        CF = Get_Volume;

        double volume = CF(radius);
        Console.WriteLine("Объем шара: " + volume);
    }

    /// <summary>
    /// Вычисляет длину окружности.
    /// </summary>
    /// <param name="radius">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    static double Get_Length(double radius)
    {
        double length = 2 * Math.PI * radius;
        return length;
    }

    /// <summary>
    /// Вычисляет площадь круга.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    static double Get_Area(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }

    /// <summary>
    /// Вычисляет объем шара.
    /// </summary>
    /// <param name="radius">Радиус шара.</param>
    /// <returns>Объем шара.</returns>
    static double Get_Volume(double radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        return volume;
    }
}