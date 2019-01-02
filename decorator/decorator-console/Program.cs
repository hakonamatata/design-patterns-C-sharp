using System;

/*

Definition:

Attach additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for extending functionality. 

*/

namespace decorator_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Decorator!");

            // Decaf decaf = new Decaf();
            // decaf.getDescription();
            // decaf.getCost();

        }
    }

    public abstract class Beverage
    {

        protected double _cost = 0;
        protected string _description = "empty";

        public abstract double getCost();

        public abstract void getDescription();

    }

    // decorator IS a Beverage and HAS a Beverage
    public abstract class BeverageDecorator : Beverage
    {
        public BeverageDecorator(Beverage beverage) : base() { }
    }

    public class Decaf : Beverage
    {

        public override double getCost()
        {
            return 1.25;
        }

        public override void getDescription()
        {
            throw new NotImplementedException();
        }
    }

    public class Espresso : Beverage
    {

        public override double getCost()
        {
            return 3.15;
        }

        public override void getDescription()
        {
            throw new NotImplementedException();
        }
    }

    // you can rap the Soy or Caramel beverage decorator around Espresso or Decaf
    public class SoyBeverageDecorator : BeverageDecorator
    {
        protected Beverage _beverage;

        public SoyBeverageDecorator(Beverage beverage) : base(beverage)
        {
            this._beverage = beverage;
        }

        public override double getCost()
        {
            return this._beverage.getCost() + 0.25;
        }

        public override void getDescription()
        {
            throw new NotImplementedException();
        }
    }

    public class CaramelBeverageDecorator : BeverageDecorator
    {
        protected Beverage _beverage;

        public CaramelBeverageDecorator(Beverage beverage) : base(beverage)
        {
            this._beverage = beverage;
        }

        public override double getCost()
        {
            return this._beverage.getCost() + 0.50;
        }

        public override void getDescription()
        {
            throw new NotImplementedException();
        }
    }


}
