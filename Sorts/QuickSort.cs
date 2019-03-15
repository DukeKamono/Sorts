using System;

namespace Sorts
{
    class QuickSort
    {
        public TimeSpan ResultTime;

        //Sets up the Properties for the QuickSort object
        public int[] RunQuickSort(SetupLists setup)
        {
			int[] list = (int[])setup.currentArray.Clone();
            var left = 0;
            var right = list.Length-1; //The last index

			//Start time here
			var startTime = DateTime.Now;
			HoareQuickSort(list, left, right);
            var endTime = DateTime.Now - startTime;
            //End time here

            ResultTime = endTime;

            return list;
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

				HoareQuickSort(array, left, pivot);
				HoareQuickSort(array, pivot + 1, right);
            }
        }

        public int Partition(int[] array, int left, int right)
        {
            //Make the pivot the first element
            var pivot = array[left];
			var i = left - 1;
			var j = right + 1;

            while (true)
            {
				//Keep moving the right side down until > pivot
				do
				{
					j--;
				}
				while (array[j] > pivot);

				//Keep moving the left side up until < pivot
				do
				{
					i++;
				}
				while (array[i] < pivot);

				if (i >= j)
				{
					return j;
				}

				var temp = array[i];
				array[i] = array[j];
				array[j] = temp;
            }
        }
    }
}