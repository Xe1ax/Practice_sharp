namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] spiralArray = new int[7, 7];

            int i = 0, j = 0, num = 1;
            while (num <= 49)
            {
                for (int k = j; k < 7 - j; k++)
                {
                    spiralArray[i, k] = num++;
                }

                for (int k = i + 1; k < 7 - i; k++)
                {
                    spiralArray[k, 7 - j - 1] = num++;
                }

                for (int k = 7 - j - 2; k >= j; k--)
                {
                    spiralArray[7 - i - 1, k] = num++;
                }

                for (int k = 7 - i - 2; k > i; k--)
                {
                    spiralArray[k, j] = num++;
                }

                i++;
                j++;
            }

            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write("{0,2} ", spiralArray[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}