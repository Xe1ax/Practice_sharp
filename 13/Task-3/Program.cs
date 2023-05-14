namespace Task_3
{
    public delegate void EventHandler();

    public class EventClass
    {
        public event EventHandler MyEvent;

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
            MyEvent?.Invoke();
        }
    }

    public class Observer1
    {
        public void OnEvent()
        {
            Console.WriteLine("Observer 1 reacted to event");
        }
    }

    public class Observer2
    {
        public void OnEvent()
        {
            Console.WriteLine("Observer 2 reacted to event");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventClass eventClass = new EventClass();

            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            eventClass.MyEvent += observer1.OnEvent;
            eventClass.MyEvent += observer1.OnEvent;
            eventClass.MyEvent += observer2.OnEvent;

            eventClass.DoSomething();

            eventClass.MyEvent -= observer1.OnEvent;

            eventClass.DoSomething();

            Console.ReadLine();
        }
    }
}