using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vector3Config : ConfigProxy<Vector3, Vector3StringConverter>
{
	public Vector3Config(string path, string file, string section, string key, Vector3 @default) : base(path, file, section, key, @default)
	{
	}
}

public class Vector3StringConverter : IStringConverter<Vector3>
{
	public Vector3 ConvertTo(string value)
	{
		string s = value;

		if (s.StartsWith("(", System.StringComparison.Ordinal) && s.EndsWith(")", System.StringComparison.Ordinal))
		{
			s = s.Substring(1, s.Length - 2);
		}

		string[] sArray = s.Split(',');

		Vector3 result = new Vector3(float.Parse(sArray[0]), float.Parse(sArray[1]), float.Parse(sArray[2]));

		return result;
	}

	public string ToString(Vector3 obj)
	{
		return obj.ToString();
	}
}