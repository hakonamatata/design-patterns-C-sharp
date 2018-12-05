using System;
using System.Collections.Generic;

// Observer / Subscriber pattern for getting data when object has changed, 
// instead of "pulling" data on a regular basis
public class ObserverPattern
{

  public static void Main()
  {
    Console.WriteLine("hello world");

    // TODO: first an object subscribe to an observable 
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

public class ConcreteObserver : IObserver
{

  IObservable observable;

  public ConcreteObserver(IObservable o)
  {
    this.observable = o;
  }

  public void update()
  {

  }
}

public class ConcreteObservable : IObservable
{

  List<IObserver> observers = new List<IObserver>();

  public void add(IObserver o)
  {
    observers.Add(o);
  }

  public void remove(IObserver o)
  {
    observers.Remove(o);
  }

  public void notify()
  {

    foreach (IObserver o in observers)
    {
      o.update();
    }

  }

  void setState()
  {

  }

  // method set some state

}


