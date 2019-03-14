using System;

namespace Sorts
{
	class HeapSort
	{
		public TimeSpan ResultTime;

		//Sets up the Properties for the HeapSort object
		public int[] RunHeapSort(SetupLists setup)
		{
			int[] list = (int[])setup.currentArray.Clone();
			//Start time here
			var startTime = DateTime.Now;
			HeapSortSiftDown(list, list.Length);
			var endTime = DateTime.Now - startTime;
			//End time here

			ResultTime = endTime;

			return list;
		}

		//Heap Sort using an array of ints.
		public void HeapSortSiftDown(int[] array, int length)
		{
			array = HeapifySiftDown(array, length);

			var end = length - 1;
			while (end > 0)
			{
				var temp = array[end];
				array[end] = array[0];
				array[0] = temp;

				end--;

				array = SiftDown(array, 0, end);
			}
		}

		public int[] HeapifySiftDown(int[] array, int length)
		{
			//ugggghhh why to a double .net.....??
			int start = (int)Math.Floor((((double)length - 1) - 1) / 2);

			while (start >= 0)
			{
				array = SiftDown(array, start, length - 1);

				start--;
			}
			return array;
		}

		public int[] SiftDown(int[] array, int start, int end)
		{
			while (2 * start + 1 <= end)
			{
				var child = 2 * start + 1;

				var swap = start;

				if (array[swap] < array[child])
				{
					swap = child;
				}
				if (child + 1 <= end && array[swap] < array[child + 1])
				{
					swap = child + 1;
				}
				if (swap == start)
				{
					return array;
				}
				else
				{
					var temp = array[start];
					array[start] = array[swap];
					array[swap] = temp;

					start = swap;
				}
			}
			return array;
		}
	}
}
