using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStringConverter<T>
{
	string ToString(T obj);
	T ConvertTo(string value);
}
