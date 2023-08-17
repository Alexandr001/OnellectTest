// See https://aka.ms/new-console-template for more information

using TestOnellect;
using TestOnellect.Sorting;

Console.WriteLine("Hello, World!");
int[] array = CreateArray();

ISorting factory = SortFactory.FactoryMethod();
factory.Sort(array);




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