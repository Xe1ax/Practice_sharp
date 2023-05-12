using System;

namespace Task_1
{
    interface Ix
    {
        void IxF0(int параметр);
        void IxF1();
    }

    interface Iy
    {
        void F0(int параметр);
        void F1();
    }

    interface Iz
    {
        void F0(int параметр);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        private int w;

        public TestClass(int w)
        {
            this.w = w;
        }

        public void IxF0(int параметр)
        {
            Console.WriteLine("IxF0: " + (Math.Cos(Math.Exp(w))));
        }

        public void IxF1()
        {
            Console.WriteLine("IxF1: " + (Math.Cos(Math.Exp(w))));
        }

        void Iy.F0(int параметр)
        {
            Console.WriteLine("Iy.F0: " + (Math.Cos(Math.Exp(w))));
        }

        void Iy.F1()
        {
            Console.WriteLine("Iy.F1: " + (Math.Cos(Math.Exp(w))));
        }

        void Iz.F0(int параметр)
        {
            Console.WriteLine("Iz.F0: " + (1 / Math.Exp(w)));
        }

        void Iz.F1()
        {
            Console.WriteLine("Iz.F1: " + (1 / Math.Exp(w)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass(5);

            Ix ix = test;
            ix.IxF0(0);
            ix.IxF1();

            Iy iy = test;
            iy.F0(0);
            iy.F1();

            Iz iz = test;
            iz.F0(0);
            iz.F1();

            ((Iy)test).F0(0);
            ((Iy)test).F1();

            ((Iz)test).F0(0);
            ((Iz)test).F1();

            Console.ReadLine();
        }
    }
}