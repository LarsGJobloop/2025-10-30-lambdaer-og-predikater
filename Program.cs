var consoleApp = new ConsoleApp();

consoleApp.Command("", () => Console.WriteLine("Standard"));
consoleApp.Command("hello", () => Console.WriteLine("Hello"));
consoleApp.Command("bye", () => Console.WriteLine("Bye"));

consoleApp.Run();
