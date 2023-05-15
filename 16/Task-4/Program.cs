namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\\Users\\Admin\\Desktop\\input.txt";  
            string outputFilePath = @"C:\\Users\\Admin\\Desktop\\output.txt";  

            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string replacedLine = ReplaceZerosAndOnes(line);
                    writer.WriteLine(replacedLine);
                }
            }
        }

        static string ReplaceZerosAndOnes(string line)
        {
            char[] chars = line.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '0')
                {
                    chars[i] = '1';
                }
                else if (chars[i] == '1')
                {
                    chars[i] = '0';
                }
            }

            return new string(chars);
        }
    }
}