namespace ssharp.core;

public struct Error
{
	public string name;
	public string message;
	public Location? location;

	public Error(string _name, string _message, Location? _location = null)
	{
		name = _name;
		message = _message;
		location = _location;
	}
}

