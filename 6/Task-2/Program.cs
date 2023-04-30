namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            int errorCount = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                char currentChar = input[i];
                char nextChar = input[i + 1];

                if (IsPunctuation(currentChar) && nextChar != ' ')
                {
                    errorCount++;
                }
            }

            Console.WriteLine("Количество ошибок: " + errorCount);
        }

        static bool IsPunctuation(char c)
        {
            return char.IsPunctuation(c) && c != '\'';
        }
    }
}