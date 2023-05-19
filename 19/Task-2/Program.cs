using System;
using System.IO;

/// <summary>
/// Класс, выполняющий создание новой папки.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        string folderName = "New_folder";

        try
        {
            // Создание новой папки
            Directory.CreateDirectory(folderName);
            Console.WriteLine("Папка успешно создана.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка при создании папки: " + ex.Message);
        }
    }
}