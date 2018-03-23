using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringConverter<T> : IStringConverter<T> where T : IConvertible
{
	public T ConvertTo(string value)
	{
		return (T)Convert.ChangeType(value, typeof(T));
	}

	public string ToString(T obj)
	{
		return obj.ToString();
	}
}
