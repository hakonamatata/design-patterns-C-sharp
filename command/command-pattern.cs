using System;

/*

Encapsulate a command that is sent between objects. 

Allow easily undo and redo functionality, by adding undo function to command.  
Allows for batching multple commands / actions by executing a command that consist of multiple commands.

*/

public class Program
{

  static void Main(string[] args)
  {
    Console.WriteLine("Hello world");
  }

}

// any command can act upon receiver
class Receiver
{

}

// invoker has one to many commands
// invoker act upon receiver via commands
class Invoker
{
  ICommand[] commands;

  void setCommand(ICommand c)
  {

  }

}

interface ICommand
{
  void execute();
  void undo();
}

class Command : ICommand
{

}