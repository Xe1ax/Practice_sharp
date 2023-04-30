namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию пользователя: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя пользователя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество пользователя: ");
            string middleName = Console.ReadLine();

            string fullName = lastName + firstName + middleName;

            int sum = 0;
            foreach (char c in fullName)
            {
                if (char.IsLetter(c))
                {
                    int charValue = (int)c - 64;
                    sum += charValue;
                }
            }

            while (sum >= 10)
            {
                int newSum = 0;
                while (sum > 0)
                {
                    newSum += sum % 10;
                    sum /= 10;
                }
                sum = newSum;
            }

            Console.WriteLine("Код личности пользователя: " + sum);
        }
    }
}