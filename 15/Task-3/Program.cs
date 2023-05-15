namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            int[] arr = myList.ToArray();
            Console.WriteLine("MyList as array:");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyList<T>
    {
        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T this[int index]
        {
            get { return _list[index]; }
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public T[] ToArray()
        {
            return _list.ToArray();
        }
    }
}