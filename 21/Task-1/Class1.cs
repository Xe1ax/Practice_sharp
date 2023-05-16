using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_1
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quacki();
    }
}
public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with wings!");
    }
}

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly.");
    }
}
public class Quack : IQuackBehavior
{
    public void Quacki()
    {
        Console.WriteLine("Quack quack!");
    }
}

public class Squeak : IQuackBehavior
{
    public void Quacki()
    {
        Console.WriteLine("Squeak squeak!");
    }
}

public class MuteQuack : IQuackBehavior
{
    public void Quacki()
    {
        Console.WriteLine("<< Silence >>");
    }
}
public class Duck
{
    private IFlyBehavior flyBehavior;
    private IQuackBehavior quackBehavior;

    public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        this.flyBehavior = flyBehavior;
        this.quackBehavior = quackBehavior;
    }

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        this.quackBehavior = quackBehavior;
    }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quacki();
    }
}