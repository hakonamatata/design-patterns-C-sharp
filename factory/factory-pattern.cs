using System;

/*

Definition:

Define an interface for creating an object, but let subclasses decide which class to instantiate. 
Factory Method lets a class defer instantiation to subclasses. 

*/

public class Program
{

  static void Main(string[] args)
  {
    Console.WriteLine("Hello Factory");

    // example of a factory that create random subtypes of IObstacle (Alien, Rock, Ship)
    IObstacleFactory factory = new RandomObstacleCreator();

    // create five random obstacles 
    IObstacle o1 = factory.CreateObstacle();
    IObstacle o2 = factory.CreateObstacle();
    IObstacle o3 = factory.CreateObstacle();
    IObstacle o4 = factory.CreateObstacle();
    IObstacle o5 = factory.CreateObstacle();

    // print object type
    Console.WriteLine(o1);
    Console.WriteLine(o2);
    Console.WriteLine(o3);
    Console.WriteLine(o4);
    Console.WriteLine(o5);

    // example result
    /*
    Hello Factory
    Ship
    Alien
    Ship
    Alien
    Rock
    */

  }

}

// Random Singleton from other example!
class RandomSingleton : Random
{

  private static RandomSingleton _instance;

  // Constructor is protected, can be accessed from any class in the same assembly
  protected RandomSingleton() { }

  public static RandomSingleton Instance
  {
    get
    {
      if (_instance == null)
      {
        _instance = new RandomSingleton();
      }
      return _instance;
    }
  }

}

public interface IObstacle { }

// different objects that can be created by different factory methods
public class Rock : IObstacle { }
public class Alien : IObstacle { }
public class Ship : IObstacle { }

// creator of some shared type
public interface IObstacleFactory
{
  IObstacle CreateObstacle();
}

// concrete impementation of creator that initialize type
public class RandomObstacleCreator : IObstacleFactory
{

  // create a random object that inherit IObstacle properties
  public IObstacle CreateObstacle()
  {
    int r = RandomSingleton.Instance.Next(0, 3);
    switch (r)
    {
      case 0:

        // each object created can also have different properties based on some bussiness logic in the factory
        return new Alien();
      case 1:
        return new Rock();
      case 2:
        return new Ship();
      default:
        return null;
    }

  }

}