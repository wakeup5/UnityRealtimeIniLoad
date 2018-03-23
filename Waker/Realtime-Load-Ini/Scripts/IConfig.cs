public interface IConfig<T, C> where C : IStringConverter<T>, new()
{
	string File { get; set; }
	string Key { get; set; }
	string Path { get; set; }
	string Section { get; set; }
	T Value { get; set; }
}