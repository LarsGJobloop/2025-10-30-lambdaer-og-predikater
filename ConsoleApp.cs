class ConsoleApp
{
  Dictionary<string, Delegate> subCommands = new();

  public void RegisterCommand(string subCommand, Delegate action)
  {
    subCommands.Add(subCommand, action);
  }

  public void Execute(string arg)
  {
    subCommands[arg].DynamicInvoke();
  }
}