namespace Task_1
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        Console.WriteLine("Count: " + myList.Count);

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("Item at index {0}: {1}", i, myList[i]);
        }
    }
}
  