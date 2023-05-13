namespace Task_1
{

    class A
    {
        protected float a = 2.4F;
        protected float b = 4.3F;
        public float c
        {
            get
            {
                var per = a * 30 / b;
                per %= 10;
                return per;
            }
        }
        public A()
        {

        }
        public A(float a1, float b1)
        {
            a = a1;
            b = b1;
        }
    }

    class B : A
    {
        public float d;
        public float c2
        {
            get
            {
                float result = 0;
                int i = (int)d;
                while (i >= 0)
                {
                    if (i == 0)
                    {
                        result = (a + b) * 2;
                        break;
                    }
                    else
                    {
                        var per = a * b;
                        per %= 10;
                        result = per;
                        i--;
                    }
                }
                return result;
            }
        }
        public B(float a1, float b1) : base(a1, b1)
        {
            a = a1;
            b = b1;
            d = 7.1F;
        }
        public B(float a1, float b1, float d1) : this(a1, b1)
        {
            a = a1;
            b = b1;
            d = d1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var classA = new A();
            Console.WriteLine(classA.c);

            var classA2 = new A(3.4F, 7.8F);
            Console.WriteLine(classA2.c);

            var classB = new B(3.4F, 7.8F);
            Console.WriteLine(classB.c);
            Console.WriteLine(classB.c2);

            var classB2 = new B(3.4F, 7.8F, 0F);
            Console.WriteLine(classB2.c);
            Console.WriteLine(classB2.c2);

        }
    }
}
