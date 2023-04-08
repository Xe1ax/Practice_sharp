namespace Task_9
{
        internal class Program
        {
            static void Main(string[] args)
            {
                double step = (2 * Math.PI / 3 - Math.PI / 3) / 20;
                double result;
                double param = Math.PI / 3;
                for (int i = 1; i <= 20; i++)
                {
                    result =  Math.Cos(param);
                    Console.WriteLine("f({0:f2}) = {1:f2}", param, result);
                    param += step;
                }
            }
        }
    }