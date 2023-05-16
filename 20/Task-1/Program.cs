namespace Task_1
{
    class Program
    {
        static void Main()
        {
            int number = 123;

            Task<int> task1 = Task.Run(() => ReverseNumber(number));
            Console.WriteLine($"Результат (Task.Run): {task1.Result}");

            Task<int> task2 = new Task<int>(() => ReverseNumber(number));
            task2.Start();
            Console.WriteLine($"Результат (Start): {task2.Result}");

            Task<int> task3 = Task.Factory.StartNew(() => ReverseNumber(number));
            Console.WriteLine($"Результат (StartNew): {task3.Result}");
        }

        static int ReverseNumber(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            return reverse;
        }
    }
}