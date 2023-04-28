namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];

            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }

            int[] neg = Array.FindAll(arr, x => x < 0);
            int[] pos = Array.FindAll(arr, x => x >= 0);

            Array.Sort(neg);
            Array.Sort(pos);

            Console.WriteLine("Negative numbers:");
            foreach (int num in neg)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Positive numbers:");
            foreach (int num in pos)
            {
                Console.WriteLine(num);
            }

            Console.Write("Enter the number to search for: ");
            int k = int.Parse(Console.ReadLine());
            int index = Array.BinarySearch(arr, k);

            if (index >= 0)
            {
                Console.WriteLine($"The number {k} was found at index {index}");
            }
            else
            {
                Console.WriteLine($"The number {k} was not found in the array");
            }
        }
    }
}
    
