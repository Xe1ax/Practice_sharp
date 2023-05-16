namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = Task.Run(() =>
            {
                int number = 345;
                int firstDigit = number / 100;
                int lastDigit = number % 10;
                return int.Parse($"{lastDigit}{number % 100 / 10}{firstDigit}");
            });

            Task task2 = task1.ContinueWith(previousTask =>
            {
                Console.WriteLine("Результат первой задачи: " + previousTask.Result);
            });

            Task.WaitAll(task1, task2);
        }
    }
}