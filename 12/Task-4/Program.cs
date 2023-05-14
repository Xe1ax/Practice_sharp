namespace Task_4
{
delegate int MyDelegate();

class Program
{
    static void Main(string[] args)
    {  
        MyDelegate[] delegatesArray = new MyDelegate[3];
        delegatesArray[0] = new MyDelegate(() => new Random().Next(1, 10));
        delegatesArray[1] = new MyDelegate(() => new Random().Next(1, 10));
        delegatesArray[2] = new MyDelegate(() => new Random().Next(1, 10));

            Func<MyDelegate[], double> average = delegate (MyDelegate[] delegates)
                {
                    int sum = 0;
                    foreach (MyDelegate del in delegates)
                    {
                        sum += del.Invoke();
                    }
                    return (double)sum / delegates.Length;
                };

    double result = average(delegatesArray);
    Console.WriteLine("Среднее арифметическое: {0}", result);
    Console.ReadKey();
        }
    }
}