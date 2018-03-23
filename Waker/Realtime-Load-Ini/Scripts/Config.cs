using Realgam;
using System;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Config<T> : Config<T, StringConverter<T>> where T : IConvertible
{
	public Config(string path, string file, string section, string key, T @default) : base(path, file, section, key, @default)
	{
	}
}

[System.Serializable]
public class Config<T, C> : IConfig<T, C> where C : IStringConverter<T>, new()
{
	[SerializeField]
	private string path;

	[SerializeField]
	private string file;

	[SerializeField]
	private string section;

	[SerializeField]
	private string key;

	[SerializeField]
	private T @default;

	private string stringValue = null;
	private T value;
	private IStringConverter<T> converter = new C();

	private IniFile ini;
	private FileSystemWatcher watcher;

	public Config(string path, string file, string section, string key, T @default)
	{
		this.path = path;
		this.file = file;
		this.section = section;
		this.key = key;
		this.@default = @default;
		
		// check exist directory
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}

		// read or write value
		this.ini = new IniFile(path + "/" + file);
		if (!ini.KeyExists(key, section))
		{
			ini.Write(key, @default.ToString(), section);
			SetValue(@default.ToString());
		}
		else
		{
			SetValue(ini.Read(key, section));
		}

		// watching ini file
		this.watcher = new FileSystemWatcher(path, file);
		this.watcher.Changed += OnFileChanged;
		this.watcher.EnableRaisingEvents = true;
	}

	~Config()
	{
		if (watcher != null)
		{
			watcher.Dispose();
		}
	}

	public string Path
	{
		get { return path; }
		set { throw new CannotModifiedException("Path value can not be modified."); }
	}

	public string File
	{
		get { return file; }
		set { throw new CannotModifiedException("File value can not be modified."); }
	}

	public string Key
	{
		get { return key; }
		set { throw new CannotModifiedException("Key value can not be modified."); }
	}

	public string Section
	{
		get { return section; }
		set { throw new CannotModifiedException("Section value can not be modified."); }
	}
	
	public T Value
	{
		get
		{
			return value;
		}
		set
		{
			if (this.value.Equals(value))
			{
				return;
			}

			this.value = value;
			ini.Write(key, this.value.ToString(), section);
		}
	}
	
	private void OnFileChanged(object sender, FileSystemEventArgs e)
	{
		SetValue(ini.Read(key, section));
	}
	
	private void SetValue(string v)
	{
		try
		{
			Value = ConvertTo(v);
		}
		catch (InvalidCastException exception)
		{
			Value = @default;
		}
		catch (OverflowException exception)
		{
			Value = @default;
		}
	}

	protected virtual T ConvertTo(string value)
	{
		return converter.ConvertTo(value);
		//return (T)Convert.ChangeType(value, typeof(T));
	}
}
