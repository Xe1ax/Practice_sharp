namespace Task_1
{
    class BackspaceString
    {
        public static string Process(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c != '#')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            char[] arr = stack.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc#d##c";
            string result = BackspaceString.Process(str);
            Console.WriteLine("Результат(abc#d##c): " + result); 
        }
    }
}