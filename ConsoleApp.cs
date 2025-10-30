class ConsoleApp
{
  Dictionary<string, Action<string[]>> subCommands = new();

  public void RegisterCommand(string subCommand, Action<string[]> action)
  {
    subCommands.Add(subCommand, action);
  }

  public void Execute(string[] args)
  {
    var subcommand = args.FirstOrDefault("");
    var rest = args.Skip(1).ToArray();

    try
    {
      subCommands[subcommand](rest);
    }
    catch (System.Exception)
    {
      Console.WriteLine("No command found");
    }
  }
}
