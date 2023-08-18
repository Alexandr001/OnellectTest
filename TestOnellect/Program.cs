// See https://aka.ms/new-console-template for more information

using TestOnellect;
using TestOnellect.Services;
using TestOnellect.Services.Implementation;
using TestOnellect.Sorting;

IHttpService httpService = new HttpService();

int[] array = CreateArray();
Settings? settings = Settings.GetSettings();
if (settings == null) {
	Console.WriteLine("Не удалось дессериализовать json!");
	return;
}

Console.WriteLine("Созданный массив:");
PrintArray(array);

ISorting factory = SortFactory.GetSorting();
int[] sortedArray = factory.Sort(array);

Console.WriteLine("Отсортированный массив: ");
PrintArray(sortedArray);

httpService.SendPost(settings.ServerUrl, sortedArray);

int[] CreateArray()
{
	Random random = new();
	int arrayLen = random.Next(Settings.MIN_ARRAY_LENGTH, Settings.MAX_ARRAY_LENGTH);
	
	int[] values = new int[arrayLen];
	for (int i = 0; i < values.Length; i++) {
		values[i] = random.Next(Settings.MIN_VALUE, Settings.MAX_VALUE);
	}
	return values;
}

void PrintArray<T>(T[] arr)
{
	foreach (T value in arr) {
		Console.Write(value + " ");
	}
	Console.WriteLine('\n');
}