namespace Task_2
{
    class MyDictionary<TKey, TValue>
    {
        private List<TKey> keys;
        private List<TValue> values;

        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                    throw new KeyNotFoundException();
                return values[index];
            }
            set
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                    throw new KeyNotFoundException();
                values[index] = value;
            }
        }

        public int Count
        {
            get { return keys.Count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dict = new MyDictionary<string, int>();

            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);

            Console.WriteLine(dict["one"]); 
            Console.WriteLine(dict["two"]); 
            Console.WriteLine(dict["three"]);

            dict["one"] = 10;
            Console.WriteLine(dict["one"]);

            Console.WriteLine(dict.Count);
        }
    }
}