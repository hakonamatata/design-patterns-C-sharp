using System;
using System.Collections.Generic;

/*

Definition:

The builder pattern is a design pattern designed to provide a flexible solution to various object creation problems in object-oriented programming. The intent of the Builder design pattern is to separate the construction of a complex object from its representation. It is one of the Gang of Four design patterns.

*/

public class Car
{
  public string Make { get; set; }
  public string Model { get; set; }
  public int NumDoors { get; set; }
  public string Color { get; set; }

  public Car() { }

  public Car(string make, string model, string color, int numDoors)
  {
    Make = make;
    Model = model;
    Color = color;
    NumDoors = numDoors;
  }

  public void Print()
  {
    Console.WriteLine("{0} {1} {2} {3}", this.Make, this.Model, this.NumDoors, this.Color);
  }
}

public class CarBuilder
{
  private Car _car;

  public CarBuilder()
  {
    this._car = new Car();
  }

  public CarBuilder Default()
  {
    this._car.Make = "Ferrari";
    this._car.Color = "red";
    this._car.NumDoors = 2;
    this._car.Model = "SF90";

    return this;
  }

  public CarBuilder WithBlueColor()
  {
    this._car.Color = "blue";

    return this;
  }

  public Car Build()
  {
    return this._car;
  }

}

public class BuilderPattern
{

  public static void Main()
  {

    CarBuilder carBuilder = new CarBuilder();
    Car defaultCar = carBuilder
      .Default()
      .Build();

    Console.WriteLine("Default");
    defaultCar.Print();

    Car defaultCarWithBlueColor = carBuilder
      .Default()
      .WithBlueColor()
      .Build();

    Console.WriteLine("Default with blue color");
    defaultCarWithBlueColor.Print();
  }

}

