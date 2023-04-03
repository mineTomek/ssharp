using ssharp.core;

namespace ssharp;

public static class Interpreter
{
    public static RunResult Run(string code)
    {
        return new RunResult(code, new Error("Stoopid Error", "Message: " + code, new Location(0, 0, new List<string>(){ "[std]" })));
    }
}
