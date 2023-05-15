namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Admin\Desktop\1.txt";

            double sum = 0;
            double product = 1;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double num = double.Parse(line);

                    sum += num;
                    product *= num;
                }
            }

            double absSum = Math.Abs(sum);
            double squareProduct = product * product;

            Console.WriteLine("Модуль суммы: {0}", absSum);
            Console.WriteLine("Квадрат произведения: {0}", squareProduct);
        }
    }
}