using System;

public class StrategyPattern
{

  static public void Main()
  {
    Console.WriteLine("hello StrategyPattern!");

    Duck wild = new WildDuck();
    Duck rubber = new RubberDuck();

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

  public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) {
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

public class NoQuack : IQuackBehavior {
  
}

public class flyDefault : IFlyBehavior {
  
}

