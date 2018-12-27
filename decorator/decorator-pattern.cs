using System;

/*

Definition: 

Attach additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for extending functionality. 

*/

public class Solution {


  public static void Main(String[] args) {

    Decaf decaf = new Decaf();
    decaf.getDescription();
    decaf.getCost();


  }

}

public abstract class Beverage {

  protected int _cost = 0;
  protected string _description = "empty";

  public virtual void getCost()  {
    Console.WriteLine("cost: {0}", _cost);
  }

  public virtual void getDescription(){
    Console.WriteLine("description: {0}", _description);
  }

}

public class Decaf : Beverage {

  public override void getCost() {
    base._cost += 1;
    base.getCost();
  }

}

public class Expresso : Beverage {

}