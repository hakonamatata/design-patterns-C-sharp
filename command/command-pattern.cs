using System;
using System.Collections.Generic;

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

    // create light
    ReceiverLight light = new ReceiverLight();

    // turn light on
    LightSwichOnCommand onCommand = new LightSwichOnCommand(light);

    // create remote
    InvokerLightRemote remote = new InvokerLightRemote();

    // add command and execute
    remote.execute(onCommand);

    // undo last command
    remote.undo();
    remote.undo();

  }

}

// any command can act upon receiver
// in this example, imagine we are sending commmands to a light switch
class ReceiverLight
{
  public void turnOnLight()
  {
    Console.WriteLine("Light turned on");
  }

  public void turnOffLight()
  {
    Console.WriteLine("Light turned off");
  }
}

// invoker has one to many commands
// invoker act upon receiver via commands (command act as a proxy between invoker and receiver)
// invoker can undo actions, by keeping track of all commands that has been executed, the invoker can trigger undo in reverse order to undo everything. 
class InvokerLightRemote
{

  // commands can be added in a queue, and then executed one at a time or every 5 seconds, or a batch every so often etc
  Queue<ICommand> commands = new Queue<ICommand>();

  public void execute(ICommand c)
  {
    c.execute();
    this.commands.Enqueue(c);
  }

  public void undo() {

    if (this.commands.Count == 0) {
      Console.WriteLine("no more commands exist");
      return;
    }

    ICommand previous = this.commands.Dequeue();
    previous.undo();

  }

  public void undoAll() {
    // loop through all commands in queue and undo
  }

}

interface ICommand
{
  void execute();
  void undo();
}

class LightSwichOnCommand : ICommand
{

  ReceiverLight receiver;

  public LightSwichOnCommand(ReceiverLight r)
  {
    this.receiver = r;
  }

  public void execute()
  {
    this.receiver.turnOnLight();
  }

  public void undo()
  {
    // do the opposite of the execute command
    this.receiver.turnOffLight();
  }

}
