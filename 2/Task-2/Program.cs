using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Женя", 30);
            Personnal personnal = new Personnal("Ваня", 35, 10);
            Engineer engineer = new Engineer("Ання", 20, "ЭВМ");
            Administration administration = new Administration("Ян", 25, "Заместитель директора");
            Console.WriteLine(worker);
        }
    }
}