namespace Task_2
{
    class A
    {
        private int a = 5;
        private int b = 10;

        public int C
        {
            get { return a + b; }
        }
    }

    class B : A
    {
        private int d = 15;

        public int D
        {
            get { return d; }
            set { d = value; }
        }

        public int C2
        {
            get
            {
                int result = 0;
                for (int i = 0; i < D; i++)
                {
                    result += base.C * i;
                }
                return result;
            }
        }

        public B() { }

        public B(int d)
        {
            this.D = d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine($"Значение свойства С у объекта класса A: {a.C}");

            B b1 = new B();
            Console.WriteLine($"Значение свойства С у объекта класса B (конструктор 1): {b1.C}");
            Console.WriteLine($"Значение свойства С2 у объекта класса B (конструктор 1): {b1.C2}");

            B b2 = new B(20);
            Console.WriteLine($"Значение свойства С2 у объекта класса B (конструктор 2): {b2.C2}");
        }
    }
}