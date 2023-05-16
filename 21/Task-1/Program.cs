namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new Duck(new FlyWithWings(), new Quack());
            mallardDuck.PerformFly(); // I'm flying with wings!
            mallardDuck.PerformQuack(); // Quack quack!
            mallardDuck.SetFlyBehavior(new FlyNoWay());
            mallardDuck.PerformFly(); // I can't fly.
            mallardDuck.SetQuackBehavior(new Squeak());
            mallardDuck.PerformQuack(); // Squeak squeak!
        }
    }
}