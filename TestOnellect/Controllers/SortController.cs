using TestOnellect.Services;
using TestOnellect.Services.Implementation;
using TestOnellect.Sorting;

namespace TestOnellect.Controllers;

public class SortController
{
	private readonly IHttpService _httpService;
	private readonly Settings? _settings;
	private readonly ISorting _sorting;

	public SortController()
	{
		_httpService = new HttpService();
		_settings = Settings.GetSettings();
		_sorting = SortFactory.GetRandomSorting();
	}
	
	public async Task Sort()
	{
		if (_settings == null) {
			Console.WriteLine("Не удалось дессериализовать json!");
			return;
		}
		
		int[] array = CreateRandomArray();
		Console.WriteLine("Созданный массив: ");
		PrintArray(array);
		
		int[] sortedArray = await _sorting.Sort(array);
		Console.WriteLine("Отсортированный массив: ");
		PrintArray(sortedArray);

		int sendPost = await _httpService.SendPost(_settings.ServerUrl, sortedArray);
		if (sendPost == 0) {
			Console.WriteLine("Не удалось отправить запрос серверу!");
		}
		Console.WriteLine("Ответ сервера: " + sendPost);
	}
	
	private int[] CreateRandomArray()
	{
		Random random = new();
		int arrayLen = random.Next(Settings.MIN_ARRAY_LENGTH, Settings.MAX_ARRAY_LENGTH);
	
		int[] values = new int[arrayLen];
		for (int i = 0; i < values.Length; i++) {
			values[i] = random.Next(Settings.MIN_VALUE, Settings.MAX_VALUE);
		}
		return values;
	}
	
	private void PrintArray<T>(IEnumerable<T> arr)
	{
		foreach (T value in arr) {
			Console.Write(value + " ");
		}
		Console.WriteLine('\n');
	}
}