namespace TestOnellect;

public class Settings
{
	public const int MAX_ARRAY_LENGTH = 100;
	public const int MIN_ARRAY_LENGTH = 20;
	public const int MIN_VALUE = -100;
	public const int MAX_VALUE = 100;
	
	
	public string ServerUrl { get; set; } = string.Empty;
	public int MaxArrayLength { get; set; }
	public int MinArrayLength { get; set; }
	public int MinValue { get; set; }
	public int MaxValue { get; set; }
}