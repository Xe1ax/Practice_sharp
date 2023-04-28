namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] salaries = new int[18, 12];
            int totalIncome = 0;
            int threshold = 0;

            Random rnd = new Random();
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    salaries[i, j] = rnd.Next(1000, 10000);
                }
            }
 
            for (int j = 0; j < 12; j++)
            {
                totalIncome += salaries[0, j];
            }

            Console.Write("Введите заданное число: ");
            threshold = Convert.ToInt32(Console.ReadLine());

            if (totalIncome > threshold)
            {
                Console.WriteLine("Годовой доход первого человека больше заданного числа.");
            }
            else
            {
                Console.WriteLine("Годовой доход первого человека меньше или равен заданному числу.");
            }

        }
    }
}