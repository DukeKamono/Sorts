using System;

namespace SortingWebSite.Models
{
	class QuickSort
	{
		public TimeSpan ResultTime;

		//Sets up the Properties for the MergeSort object
		public void RunQuickSort(SetupList setup)
		{
			//Start time here
			var startTime = DateTime.Now;
			var left = 0;
			var right = setup.currentArray.Length - 1; //The last index     
			HoareQuickSort(setup.currentArray, left, right);
			var endTime = DateTime.Now - startTime;
			//End time here

			ResultTime = endTime;
		}

		//Quicksort using Hoare's algorithm. Takes an array, using the first element as the pivot
		//Then takes the element after it and the last element and compares them to the pivot
		public void HoareQuickSort(int[] array, int left, int right)
		{

			//If the left element is less than the right element...
			if (left < right)
			{
				//Partition the array
				var pivot = Partition(array, left, right);

				if (pivot > 1)
				{
					HoareQuickSort(array, left, pivot - 1);
				}
				if (pivot + 1 < right)
				{
					HoareQuickSort(array, pivot + 1, right);
				}

			}
		}

		public int Partition(int[] array, int left, int right)
		{
			//Make the pivot the first element
			var pivot = array[left];

			while (true)
			{
				//Keep moving the left side up until >= pivot
				while (array[left] < pivot)
				{
					left++;
				}

				//Keep moving the right side down until <= pivot
				while (array[right] > pivot)
				{
					right--;
				}

				if (left < right)
				{
					//Perform a swap here
					int temp = array[left];
					array[left] = array[right];
					array[right] = temp;

					//Duplicate encountered, so move the left side up
					if (array[left] == array[right])
					{
						left++;
					}


				}
				else
				{
					return right;
				}
			}

		}
	}
}
