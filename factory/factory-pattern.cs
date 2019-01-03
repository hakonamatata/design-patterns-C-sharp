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

    RandomObstacleCreator factory = new RandomObstacleCreator();

    Console.WriteLine(factory.CreateObstacle());

  }

}

public enum ObstacleType
{
    Rock,
    Ship,
    Alien
}

public interface IObstacle
{
  ObstacleType GetType();
}

public class Obstacle : IObstacle
{

  private string _name;

  public Obstacle(string name)
  {
    this._name = name;
  }

  public override String ToString()
  {
    return this._name;
  }

}

// creator of some shared type
public interface IObstacleFactory
{
  IObstacle CreateObstacle();
}

// concrete impementation of creator that initialize type
public class RandomObstacleCreator : IObstacleFactory
{

  public IObstacle CreateObstacle()
  {
    return new Obstacle("Large Rock");
  }

}
