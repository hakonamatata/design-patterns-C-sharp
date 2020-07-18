using System;

/*

Definition:

Define a family of algorithms, encapsulate each one, and make them interchangeable.
Strategy lets the algorithm vary independently from clients that use it.

SOLID principle:

Use composition over inheritance by using interfaces that has replacable behavior.
This allows changing the method behavior during run-time.

*/


public class StrategyPattern
{

  static public void Main()
  {

    // create duck object using different implementations of the fly() and quack() methods
    Duck wild = new Duck(new DefaultFlying(), new DefaultQuack());
    Duck rubber = new Duck(new NoFlying(), new RubberQuack());

    Console.WriteLine("Wild duck:");
    wild.fly();
    wild.quack();

    Console.WriteLine();
    Console.WriteLine("Rubber duck:" + Environment.NewLine);

    rubber.fly();
    rubber.quack();

    // change an objects method implementation during run-time
    // wild duck can no longer fly!
    wild.setFlyBehavior(new NoFlying());

    Console.WriteLine(Environment.NewLine + "Change Wild duck fly behavior during run-time!");
    Console.WriteLine("Wild duck:");
    wild.fly();
  }

}

// public interface IQuackBehavior
// {
//   void execute();
// }

public interface IBehavior
{
  void execute();
}

public class Duck
{

  IBehavior flyBehavior;
  IBehavior quackBehavior;

  public Duck(IBehavior flyBehavior, IBehavior quackBehavior)
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

  // enable changing the flyBehavior during run-time
  public void setFlyBehavior(IBehavior flyBehavior) {
    this.flyBehavior = flyBehavior;
  }

  // enable changing the quackBehavior during run-time
  public void setQuackBehavior(IBehavior quackBehavior) {
    this.quackBehavior = quackBehavior;
  }

}

public class DefaultQuack : IBehavior
{
  public void execute()
  {
    Console.WriteLine("quack quack");
  }
}

public class RubberQuack : IBehavior
{
  public void execute()
  {
    Console.WriteLine("squick!");
  }
}

public class DefaultFlying : IBehavior
{
  public void execute()
  {
    Console.WriteLine("fly");
  }
}

public class NoFlying : IBehavior
{
  public void execute()
  {
    Console.WriteLine("cannot fly!");
  }
}