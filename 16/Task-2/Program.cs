namespace Task_2
{
    class Program
    {
        static void Main()
        {
            // Создаем файл и записываем в него 5 строк разной длины
            string fileName = "test.txt";
            File.WriteAllLines(fileName, new[] { "1234", "56789", "0", "", "abcdef" });

            // a) Выводим весь файл на экран
            Console.WriteLine("File contents:");
            Console.WriteLine(File.ReadAllText(fileName));

            // b) Считаем количество строк
            int lineCount = File.ReadLines(fileName).Count();
            Console.WriteLine($"Line count: {lineCount}");

            // c) Считаем количество символов в каждой строке
            var lineLengths = File.ReadLines(fileName).Select(line => line.Length);
            Console.WriteLine($"Line lengths: {string.Join(", ", lineLengths)}");

            // d) Удаляем последнюю строку и записываем в новый файл
            string newFileName = "test_new.txt";
            File.WriteAllLines(newFileName, File.ReadLines(fileName).Take(lineCount - 1));
            Console.WriteLine($"File {newFileName} created with contents:");
            Console.WriteLine(File.ReadAllText(newFileName));

            // e) Выводим строки с s1 по s2
            int s1 = 2;
            int s2 = 4;
            var lines = File.ReadLines(fileName).Skip(s1 - 1).Take(s2 - s1 + 1);
            Console.WriteLine($"Lines {s1} to {s2}: {string.Join(", ", lines)}");

            // f) Находим длину самой длинной строки и выводим ее
            int longestLineLength = File.ReadLines(fileName).Max(line => line.Length);
            Console.WriteLine($"Longest line length: {longestLineLength}");

            // g) Выводим все строки, начинающиеся с заданной буквы
            char startingLetter = '5';
            var matchingLines = File.ReadLines(fileName).Where(line => line.StartsWith(startingLetter));
            Console.WriteLine($"Lines starting with {startingLetter}: {string.Join(", ", matchingLines)}");

            // h) Переписываем строки в другой файл в обратном порядке
            string reversedFileName = "test_reversed.txt";
            var reversedLines = File.ReadLines(fileName).Reverse();
            File.WriteAllLines(reversedFileName, reversedLines);
            Console.WriteLine($"File {reversedFileName} created with contents:");
            Console.WriteLine(File.ReadAllText(reversedFileName));
        }
    }
}