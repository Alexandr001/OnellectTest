namespace TestOnellect.Sorting.Implementation;

public class QuickSorting : ISorting
{
	public int[] Sort(int[] arr)
	{
		Console.WriteLine(nameof(QuickSorting));
		int[] sortArr = QuickSort(arr, 0, arr.Length - 1);
		return sortArr;
	}

	private int[] QuickSort(int[] arr, int minIndex, int maxIndex)
	{
		int i = minIndex;
		int j = maxIndex;
		int pivot = arr[minIndex];
		while (i <= j) {
			while (arr[i] < pivot) {
				i++;
			}
        
			while (arr[j] > pivot) {
				j--;
			}
			if (i > j) {
				continue;
			}
			(arr[i], arr[j]) = (arr[j], arr[i]);
			i++;
			j--;
		}
    
		if (minIndex < j) {
			QuickSort(arr, minIndex, j);
		}
		if (i < maxIndex) {
			QuickSort(arr, i, maxIndex);
		}
		return arr;
	}
}