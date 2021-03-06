

void Main()
{
	var arr = new[] { 3, 2, 10, 4, 40 };
	int n = arr.Length - 1;
	int x = 4;
	int result = binarySearch(arr, 0, n - 1, x);
	result.Dump();
}
/*
Given an array which is sorted, but after sorting some elements are moved to either of the adjacent positions, i.e.,
arr[i] may be present at arr[i+1] or arr[i-1]. Write an efficient function to search an element in this array. 
Basically the element arr[i] can only be swapped with either arr[i+1] or arr[i-1].

*/
// A recursive binary search based function. It returns index of x in
// given array arr[l..r] is present, otherwise -1
int binarySearch(int[] arr, int l, int r, int x)
{
	if (r >= l)
	{
		int mid = l + (r - l) / 2;

		// If the element is present at one of the middle 3 positions
		if (arr[mid] == x) return mid;
		if (mid > l && arr[mid - 1] == x) return (mid - 1);
		if (mid < r && arr[mid + 1] == x) return (mid + 1);

		// If element is smaller than mid, then it can only be present
		// in left subarray
		if (arr[mid] > x) return binarySearch(arr, l, mid - 2, x);

		// Else the element can only be present in right subarray
		return binarySearch(arr, mid + 2, r, x);
	}

	// We reach here when element is not present in array
	return -1;
}
