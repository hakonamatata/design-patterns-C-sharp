using System;

public class StrategyPattern
{

  static public void Main()
  {
    Console.WriteLine("hello StrategyPattern!");
  }

}

public class Duck {

  public void display() { }
  public void quack() { }

}

public class WildDuck : Duck {



}