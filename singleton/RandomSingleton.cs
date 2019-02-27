using System;

/*

Definition: 

Ensure a class has only one instance and provide a global point of access to it. 

Random class

Represents a pseudo-random number generator, 
which is a device that produces a sequence of numbers that meet certain statistical requirements for randomness.

The current implementation of the Random class is based on a modified version of Donald E. Knuth's subtractive random number generator algorithm

*/
class RandomSingleton : Random
{

  private static RandomSingleton _instance;

  // Constructor is protected, no other class can create a new RandomSingleton instance using the new keyword
  protected RandomSingleton()
  {

  }

  // instead of using the constructor, call RandomSingleton.Instance() 
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

// example
public class Solution
{

  static void Main(String[] args)
  {

    while (true)
    {
      Console.WriteLine(RandomSingleton.Instance.Next());
      Console.ReadKey();
    }

  }

}
