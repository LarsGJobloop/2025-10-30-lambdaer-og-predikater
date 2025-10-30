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

consoleApp.RegisterCommand("sort", (args) =>
{
  var entries = args
    .Select(arg => int.Parse(arg))
    .Order();

  foreach (var entry in entries)
  {
    Console.WriteLine(entry);
  }
});

consoleApp.Execute(args);
