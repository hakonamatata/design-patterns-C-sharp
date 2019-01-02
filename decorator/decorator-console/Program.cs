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

        protected int _cost = 0;
        protected string _description = "empty";

        public virtual int getCost()
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
    public class BeverageDecorator
    {

    }

    public class Decaf : Beverage
    {

        public override int getCost()
        {
            base._cost = 1;
            return this._cost;
        }

    }

    public class Espresso : Beverage
    {

        public override int getCost()
        {
            base._cost = 3;
            return this._cost;
        }

    }

    // you can rap the Soy or Caramel beverage decorator around Espresso or Decaf
    public class SoyBeverageDecorator
    {

    }

    public class CaramelBeverageDecorator
    {

    }


}
