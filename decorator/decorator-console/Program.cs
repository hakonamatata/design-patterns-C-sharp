using System;

namespace decorator_console
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Decorator!");

      Decaf decaf = new Decaf();
      decaf.getDescription();
      decaf.getCost();

    }
  }

  public abstract class Beverage
  {

    protected double _cost = 0;
    protected string _description = "empty";

    public virtual double getCost()
    {
      Console.WriteLine("cost: {0}", _cost);
      return this._cost;
    }

    public virtual void getDescription()
    {
      Console.WriteLine("description: {0}", _description);
    }

  }

  // decorator IS a Beverage and HAS a Beverage
  public class BeverageDecorator : Beverage
  {
    protected Beverage _beverage;

    public BeverageDecorator(Beverage beverage)
    {
      this._beverage = beverage;
    }

  }

  public class Decaf : Beverage
  {

    public override double getCost()
    {
      base._cost = 1.25;
      return this._cost;
    }

  }

  public class Espresso : Beverage
  {

    public override double getCost()
    {
      base._cost = 3.15;
      return this._cost;
    }

  }

    // you can rap the Soy or Caramel beverage decorator around Espresso or Decaf
    public class SoyBeverageDecorator : BeverageDecorator
    {
        public SoyBeverageDecorator(Beverage beverage) : base(beverage)
        {
        }
    }

    public class CaramelBeverageDecorator : BeverageDecorator
    {
        public CaramelBeverageDecorator(Beverage beverage) : base(beverage)
        {
        }
    }


}
