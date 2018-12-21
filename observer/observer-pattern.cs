using System;
using System.Collections.Generic;

// Observer / Subscriber pattern for getting data when object has changed, 
// instead of "pulling" data on a regular basis
public class ObserverPattern
{

  public static void Main()
  {

    // create object that implements IObservable
    WeatherStation weatherStation = new WeatherStation();

    // create object that implements IObserver and add IObservable object
    PhoneDisplay o1 = new PhoneDisplay(weatherStation);
    weatherStation.add(o1);

    Webpage o2 = new Webpage(weatherStation);
    weatherStation.add(o2);

    weatherStation.setTemprature(21);
    weatherStation.setTemprature(23);

    weatherStation.remove(o1);

    weatherStation.setTemprature(18);

  }

}

// sometimes called "subject"
// NOTE: could create an abstract class that implements observable
public interface IObservable
{
  void add(IObserver o);
  void remove(IObserver o);
  void notify();
}

public interface IObserver
{
  void update();
}

public class Webpage : IObserver
{

  WeatherStation weatherStation;

  public string name = "webpage";

  // constructor
  public Webpage(WeatherStation w)
  {
    this.weatherStation = w;
  }

  public void update()
  {
    this.printState();
  }

  public void printState()
  {
    Console.WriteLine("state of {0}, is {1}", this.name, this.weatherStation.getTemprature());
  }

}

public class PhoneDisplay : IObserver
{

  WeatherStation weatherStation;

  public string name = "phoneDisplay";

  // constructor
  public PhoneDisplay(WeatherStation w)
  {
    this.weatherStation = w;
  }

  public void update()
  {
    this.printState();
  }

  public void printState()
  {
    Console.WriteLine("state of {0}, is {1}", this.name, this.weatherStation.getTemprature());
  }

}

public class WeatherStation : IObservable
{

  private List<IObserver> observers = new List<IObserver>();

  private int temprature = 0;

  public void add(IObserver o)
  {
    observers.Add(o);
    Console.WriteLine("Adding observer {0}, observers amount {1}", o.ToString(), this.observers.Count);
  }

  public void remove(IObserver o)
  {
    observers.Remove(o);
    Console.WriteLine("Removing observer {0}, observers amount {1}", o.ToString(), this.observers.Count);
  }

  public void notify()
  {

    foreach (IObserver o in observers)
    {
      o.update();
    }

  }

  // example of a simple implementation of state to be observed
  public int getTemprature()
  {
    return temprature;
  }

  public void setTemprature(int t)
  {
    this.temprature = t;
    Console.WriteLine("Updating observer state to {0}", this.getTemprature());

    // notify all subscribers / observers
    this.notify();
  }

}


