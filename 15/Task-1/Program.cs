namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine("Count: " + myList.Count);
            Console.WriteLine("Item at index 1: " + myList[1]);
        }
    }

    class MyList<T>
    {
        private List<T> items;

        public MyList()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}