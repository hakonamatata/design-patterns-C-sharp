# Design Patterns and snippets in C#
Sample implementation of different common design patterns and useful snippets for future reference.
Written in C#


## List of implemented Patterns

* Decorator pattern 
* Observer pattern 
* ingleton pattern 
* Strategy pattern 
* Factory Method Pattern


## List of Snippets

* Read arguments from Main
* Read console input


## HOW TO RUN

I have for the most part written everything in a single .cs file to make it as easy as possible. 

To compile and run the strategy pattern example (assumes you have the csc compiler installed and added as a enviroment variable)
Go to the correct folder, compile the .cs file to a runnable exe and run the program from the command line. 

Compile and run
```
cd .\strategy\
csc .\strategy-pattern.cs
.\strategy-pattern.exe
```

Some projects have been made in Visual Studio. One for a simple console application and one xunit project to run test cases.

Test project
```
cd .\decorator\
dotnet test

Starting test execution, please wait...

Total tests: 5. Passed: 5. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2,2019 Seconds

```


