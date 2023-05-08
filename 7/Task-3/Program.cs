using System.Text.RegularExpressions;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.Write("Введите минимальное количество слов в предложении: ");
            int n = int.Parse(Console.ReadLine());

            string[] sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"\b\w+\b");
            foreach (string sentence in sentences)
            {
                MatchCollection matches = regex.Matches(sentence);
                if (matches.Count >= n)
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}