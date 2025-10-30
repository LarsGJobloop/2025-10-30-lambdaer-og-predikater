var consoleApp = new ConsoleApp();

consoleApp.RegisterCommand("hello", (args) =>
{
  Console.WriteLine("Hello");

  foreach (var arg in args)
  {
    Console.WriteLine(arg);
  }
});

consoleApp.RegisterCommand("bye", (args) =>
{
  Console.WriteLine("Bye");
});

consoleApp.Execute(args);
