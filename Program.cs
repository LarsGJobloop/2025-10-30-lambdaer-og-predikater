var consoleApp = new ConsoleApp();

consoleApp.RegisterCommand("", () => Console.WriteLine("Standard"));
consoleApp.RegisterCommand("hello", () => Console.WriteLine("Hello"));
consoleApp.RegisterCommand("bye", () => Console.WriteLine("Bye"));

consoleApp.Execute(args[0]);
