using System;

// Use composition over inheritance by using interfaces that has replacable behavior. 
// also allows changing the method behavior during run-time.  
public class StrategyPattern
{

  static public void Main()
  {
    Console.WriteLine("hello StrategyPattern!");

    Duck wild = new Duck(new DefaultFlying(), new DefaultQuack());
    Duck rubber = new Duck(new NoFlying(), new RubberQuack());

    wild.fly();
    wild.quack();

    rubber.fly();
    rubber.quack();
  }

}

public interface IQuackBehavior
{
  void execute();
}

public interface IFlyBehavior
{
  void execute();
}

public class Duck
{

  IFlyBehavior flyBehavior;
  IQuackBehavior quackBehavior;

  public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
  {
    this.flyBehavior = flyBehavior;
    this.quackBehavior = quackBehavior;
  }

  public virtual void fly()
  {
    this.flyBehavior.execute();
  }

  public virtual void quack()
  {
    this.quackBehavior.execute();
  }

}

public class DefaultQuack : IQuackBehavior
{
  public void execute()
  {
    Console.WriteLine("quack quack");
  }
}

public class RubberQuack : IQuackBehavior
{
  public void execute()
  {
    Console.WriteLine("squick!");
  }
}

public class DefaultFlying : IFlyBehavior
{
  public void execute()
  {
    Console.WriteLine("fly");
  }
}

public class NoFlying : IFlyBehavior
{
  public void execute()
  {
    Console.WriteLine("cannot fly!");
  }
}