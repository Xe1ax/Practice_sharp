namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Admin\\Desktop\input.txt");

            Queue<char> charsQueue = new Queue<char>();
            Queue<char> digitsQueue = new Queue<char>();

            while (!reader.EndOfStream)
            {
                char c = (char)reader.Read();

                if (char.IsDigit(c))
                {
                    digitsQueue.Enqueue(c);
                }
                else
                {
                    charsQueue.Enqueue(c);
                }
            }

            reader.Close();

            StreamWriter writer = new StreamWriter(@"C:\Users\Admin\Desktop\output.txt");

            while (charsQueue.Count > 0)
            {
                writer.Write(charsQueue.Dequeue());
            }

            while (digitsQueue.Count > 0)
            {
                writer.Write(digitsQueue.Dequeue());
            }

            writer.Close();
        }
    }
}