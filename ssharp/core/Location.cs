namespace ssharp.core;
public struct Location
{
	public int line;
	public int col;

	public List<string> fileBacktrack = new List<string>();

    public Location(int _line, int _col, List<string> _fileBacktrack)
    {
        line = _line;
        col = _col;
		fileBacktrack = _fileBacktrack;
    }

    public override string ToString()
    {
		string fileBacktrackString = string.Join(" >> ", fileBacktrack);
        return $"{fileBacktrackString} ln: {line} col: {col}";
    }
}

