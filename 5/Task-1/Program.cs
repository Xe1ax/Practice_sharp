using System;

namespace Task_1
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.WriteLine($"The sequence number of the odd element: {i + 1} ");
                }
            }
        }
    }
}