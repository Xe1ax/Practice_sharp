namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new Duck(new FlyWithWings(), new Quack());
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.SetFlyBehavior(new FlyNoWay());
            mallardDuck.PerformFly();
            mallardDuck.SetQuackBehavior(new Squeak());
            mallardDuck.PerformQuack();
        }
    }
}