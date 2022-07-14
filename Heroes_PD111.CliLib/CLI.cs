namespace Heroes_PD111.CliLib;

public static class CLI
{
    public static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }
    
    public static void PrintLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    public static void PrintInfo(string message)
    {
        PrintLine($"{DateTime.Now.ToString("g")} [INFO]: {message}", ConsoleColor.Blue);
    }
    public static void PrintError(string message)
    {
        PrintLine($"{DateTime.Now.ToString("g")} [ERROR]: {message}", ConsoleColor.Red);
    }
}
