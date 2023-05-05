using System.Text.RegularExpressions;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Слова, оканчивающиеся на несколько подряд идущих гласных:");
            foreach (string word in words)
            {
                if (Regex.IsMatch(word, @"[аеёиоуыэюя]{2,}$", RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}