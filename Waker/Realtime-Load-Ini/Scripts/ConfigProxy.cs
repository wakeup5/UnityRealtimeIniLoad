using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waker.Configurations
{
	[System.Serializable]
	public class ConfigProxy<T> : ConfigProxy<T, StringConverter<T>> where T : IConvertible
	{
		public ConfigProxy(string path, string file, string section, string key, T @default) : base(path, file, section, key, @default)
		{
		}
	}

	[System.Serializable]
	public class ConfigProxy<T, C> : IConfig<T, C> where C : IStringConverter<T>, new()
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

		private Config<T, C> real = null;

		public ConfigProxy(string path, string file, string section, string key, T @default)
		{
			this.path = path;
			this.file = file;
			this.section = section;
			this.key = key;
			this.@default = @default;
		}

		public string File
		{
			get
			{
				if (real != null)
				{
					return real.File;
				}

				return file;
			}

			set
			{
				if (real != null)
				{
					real.File = value;
				}

				file = value;
			}
		}

		public string Key
		{
			get
			{
				if (real != null)
				{
					return real.Key;
				}

				return key;
			}

			set
			{
				if (real != null)
				{
					real.Key = value;
				}

				key = value;
			}
		}

		public string Path
		{
			get
			{
				if (real != null)
				{
					return real.Path;
				}

				return path;
			}

			set
			{
				if (real != null)
				{
					real.Path = value;
				}

				path = value;
			}
		}

		public string Section
		{
			get
			{
				if (real != null)
				{
					return real.Section;
				}

				return section;
			}

			set
			{
				if (real != null)
				{
					real.Section = value;
				}

				section = value;
			}
		}

		public T Value
		{
			get
			{
				if (real == null)
				{
					real = new Config<T, C>(path, file, section, key, @default);
				}

				return real.Value;
			}

			set
			{
				if (real == null)
				{
					real = new Config<T, C>(path, file, section, key, @default);
				}

				real.Value = value;
			}
		}
	}
}