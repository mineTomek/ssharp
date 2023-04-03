namespace ssharp.core;

public struct RunResult
{
    public Error? error;
    public string? message;

    public RunResult(string? _message, Error? _error = null)
    {
        error = _error;
        message = _message;
    }

    public override string ToString()
    {
        if (error is null)
        {
            return message!;
        } else
        {
            if (error.Value.location is null)
            {
                return $"{error.Value.name}: {error.Value.message}";
            } else
            {
                return $"{error.Value.name} at {error.Value.location}: {error.Value.message}";
            }
        }
    }
}
