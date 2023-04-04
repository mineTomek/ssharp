using ssharp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Code: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        string code = Console.ReadLine()!;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Interpreter.Run(code));
        if (code.Length > 0) {
            Main(args);
        }
    }
}