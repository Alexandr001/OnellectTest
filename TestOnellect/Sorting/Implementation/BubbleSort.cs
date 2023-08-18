namespace TestOnellect.Sorting.Implementation;

public class BubbleSort : ISorting
{
	public int[] Sort(int[] arr)
	{
		Console.WriteLine(nameof(BubbleSort));
		
		for (int i = 0; i < arr.Length; i++) {
			for (int j = 0; j < arr.Length - i - 1; j++)
			{
				if (arr[j] > arr[j + 1])
				{
					(arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
				}
			}
		}
		return arr;
	}
}