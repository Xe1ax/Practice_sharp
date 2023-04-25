namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = {rnd.Next(1,100)};
            Console.WriteLine(string.Join(", ", arr.OrderBy(n => n >= 0)));
        }
    }
}