namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            string firstWord = words[0];
            string lastWord = words[words.Length - 1];

            string gluedWords = (words[1] += words[2]);
            Console.WriteLine("Склееные 2 и 3 слова: " + gluedWords);

            char[] thirdWord = words[2].ToCharArray();
            Array.Reverse(thirdWord);
            Console.WriteLine("Третье слово в обратном порядке: " + new string(thirdWord));

            string firstTwoLettersRemoved = firstWord.Substring(2);
            words[0] = firstTwoLettersRemoved;
            sentence = string.Join(' ', words);
            Console.WriteLine("Первые две буквы первого слова удалены:" + sentence);
        }
    }
}