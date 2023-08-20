using System.Runtime.CompilerServices;

namespace TestOnellect.Sorting.Implementation;

public class SelectionSort : ISorting
{
	public async Task<int[]> Sort(int[] arr)
	{
		Console.WriteLine(nameof(SelectionSort));
		
		for (int i = 0; i < arr.Length; i++) {
			
			int indx = FindIndexMinElement(arr, i);
			
			if (arr[indx] == arr[i]) {
				continue;
			}
			(arr[i], arr[indx]) = (arr[indx], arr[i]);
		}
		return arr;
	}

	private int FindIndexMinElement(int[] arr, int i)
	{
		for (int j = i; j < arr.Length; j++) {
			if (arr[j] < arr[i]) {
				i = j;
			}
		}
		return i;
	}
}