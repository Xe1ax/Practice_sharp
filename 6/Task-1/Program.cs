namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст с символом '*': ");
            string input = Console.ReadLine();

            int index = input.IndexOf('*');
            if (index == -1)
            {
                Console.WriteLine("Символ '*' не найден в тексте.");
                return;
            }

            string substring = input.Substring(index + 1);
            string lowerCase = substring.ToLower();
            string result = input.Substring(0, index + 1) + lowerCase;

            Console.WriteLine("Результат: " + result);
        }
    }
}