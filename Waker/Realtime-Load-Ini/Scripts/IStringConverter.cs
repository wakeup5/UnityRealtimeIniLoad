using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waker.Configurations
{
	public interface IStringConverter<T>
	{
		string ToString(T obj);
		T ConvertTo(string value);
	}
}