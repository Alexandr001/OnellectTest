using System.Text.Json;

namespace TestOnellect;

public class Settings
{
	private const string PATH_FILE_SETTINGS = "appsettings.json";
	
	public const int MAX_ARRAY_LENGTH = 100;
	public const int MIN_ARRAY_LENGTH = 20;
	public const int MIN_VALUE = -100;
	public const int MAX_VALUE = 100;
	
	
	public string ServerUrl { get; private set; } = string.Empty;

	public static Settings? GetSettings()
	{
		string readAllText = File.ReadAllText(PATH_FILE_SETTINGS);
		return JsonSerializer.Deserialize<Settings>(readAllText);
	}
}