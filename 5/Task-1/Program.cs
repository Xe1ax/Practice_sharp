using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(string.Join(", ", arr.Select((x, y) => (x % 2 != 0) ? y + 1 : 0).Where(x => x != 0).ToArray()));
        }
    }
}