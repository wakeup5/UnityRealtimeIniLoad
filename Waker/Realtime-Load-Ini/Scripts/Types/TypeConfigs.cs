[System.Serializable]
public class FloatConfig : ConfigProxy<float>
{
	public FloatConfig(string path, string file, string section, string key, float @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class DoubleConfig : ConfigProxy<double>
{
	public DoubleConfig(string path, string file, string section, string key, double @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class DecimalConfig : ConfigProxy<decimal>
{
	public DecimalConfig(string path, string file, string section, string key, decimal @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class ByteConfig : ConfigProxy<byte>
{
	public ByteConfig(string path, string file, string section, string key, byte @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class SbyteConfig : ConfigProxy<sbyte>
{
	public SbyteConfig(string path, string file, string section, string key, sbyte @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class ShortConfig : ConfigProxy<short>
{
	public ShortConfig(string path, string file, string section, string key, short @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class UshortConfig : ConfigProxy<ushort>
{
	public UshortConfig(string path, string file, string section, string key, ushort @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class IntConfig : ConfigProxy<int>
{
	public IntConfig(string path, string file, string section, string key, int @default) : base(path, file, section, key, @default)
	{
	}
}


[System.Serializable]
public class UintConfig : ConfigProxy<uint>
{
	public UintConfig(string path, string file, string section, string key, uint @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class LongConfig : ConfigProxy<long>
{
	public LongConfig(string path, string file, string section, string key, long @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class UlongConfig : ConfigProxy<ulong>
{
	public UlongConfig(string path, string file, string section, string key, ulong @default) : base(path, file, section, key, @default)
	{
	}
}