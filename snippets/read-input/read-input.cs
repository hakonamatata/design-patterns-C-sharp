using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

  static void Main(String[] args)
  {

    // read console input 
    List<string> input = new List<string>();

    string line;
    while ((line = Console.ReadLine()) != null && line != "")
    {
      input.Add(line);
    }

    // print console input 
    foreach (string l in input)
    {
      Console.WriteLine(l);
    }


  }

}