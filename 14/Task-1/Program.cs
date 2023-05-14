namespace Task_1
{
    using System;
    using System.Threading;

    class Program
    {
        static object lockObj = new object();
        static AutoResetEvent event1 = new AutoResetEvent(false);
        static AutoResetEvent event2 = new AutoResetEvent(false);

        static void Main()
        {
            Thread t1 = new Thread(PrintNumbers);
            Thread t2 = new Thread(PrintNumbers);
            Thread t3 = new Thread(PrintNumbers);

            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t3.Name = "Thread 3";

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start(0);
            t2.Start(10);
            t3.Start(20);

            Console.ReadKey();
        }

        static void PrintNumbers(object start)
        {
            int num = (int)start;
            while (true)
            {
                lock (lockObj)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {num}");
                    num++;

                    if (num % 10 == 0)
                    {
                        if (Thread.CurrentThread.Name == "Thread 1")
                        {
                            event2.Set();
                            event1.WaitOne();
                        }
                        else if (Thread.CurrentThread.Name == "Thread 2")
                        {
                            event1.Set();
                            event2.WaitOne();
                        }
                        else if (Thread.CurrentThread.Name == "Thread 3")
                        {
                            event1.Set();
                            event2.WaitOne();
                        }
                    }

                    Thread.Sleep(100);
                }
            }
        }
    }
}