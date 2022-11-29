# ConsoleLog-Module
A custom console log module for any app or project
Usage:
```csharp
//Set the name of your Application
CustomLog.AppName = "MyApp";

//Log to console
CustomLog.Log(Colors.Blue, "Hello World!");

//Send a message, choose whether to print time, type your string
CustomLog.Msg(Colors.Blue, true, "Hello World!");
CustomLog.Msg(Colors.Blue, false, "Hello World!");

//Send a warning
CustomLog.Warn(Colors.Blue, "Hello World??");

//Send an error
CustomLog.Error(Colors.Blue, "Uh Oh!");

//Send a beep and choose how many beeps
CustomLog.Beep(1);
```
