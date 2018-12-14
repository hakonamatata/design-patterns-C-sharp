using System;
using System.IO;

public class Solution {

  private const string usageText = "Usage: read-arguments.exe input.txt output.txt";

  static int Main(String[] args) {

    if (args.Length < 2) {
      Console.WriteLine(usageText);
      return 1;
    }

    return 0;

  } 

}