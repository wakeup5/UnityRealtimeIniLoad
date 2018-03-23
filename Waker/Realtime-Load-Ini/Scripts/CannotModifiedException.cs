using System;

public class CannotModifiedException : Exception
{
	public CannotModifiedException()
		: base()
	{
	}

	public CannotModifiedException(string message)
		: base(message)
	{
	}

	public CannotModifiedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
