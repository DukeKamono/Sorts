using System;
using System.Numerics;

namespace Sorts
{
	class MergeSort
    {
		public TimeSpan ResultTime;

		//Sets up the Properties for the MergeSort object
		public int[] RunMergeSort(SetupLists setup)
		{
			//Start time here
			var startTime = DateTime.Now;
			var result = TopDownMergeSort(setup.currentArray);
			var endTime = DateTime.Now - startTime;
			//End time here

			ResultTime = endTime;

			return result;
		}

		//Merge sort but using an array of ints. So we can test really small numbers
		public int[] TopDownMergeSort(int[] array)
		{
			//Array of size 1 or empty.
			if (array.Length <= 1)
			{
				return array;
			}

			var halfOfArrayIndex = array.Length / 2;
			var leftSide = new int[halfOfArrayIndex];
			var rightSide = new int[array.Length - halfOfArrayIndex];
			var leftCounter = 0;
			var rightCounter = 0;

			//Split the array to two smaller arrays
			for (var i = 0; i < array.Length; i++)
			{
				if (i < halfOfArrayIndex)
				{
					leftSide[leftCounter] = array[i];
					leftCounter++;
				}
				else
				{
					rightSide[rightCounter] = array[i];
					rightCounter++;
				}
			}

			//Recursively keep splitting the smaller arrays
			leftSide = TopDownMergeSort(leftSide);
			rightSide = TopDownMergeSort(rightSide);

			//Merge each iteration
			return Merge(leftSide, rightSide);
		}

		//Merge function for the array of ints
		public int[] Merge(int[] firstArray, int[] secondArray)
		{
			var finalArray = new int[firstArray.Length + secondArray.Length];
			var firstArrayCounter = 0;
			var secondArrayCounter = 0;

			//Compare the first element is each array and the lowest to the new array
			for (var i = 0; i < finalArray.Length; i++)
			{
				if (firstArray.Length > firstArrayCounter && secondArray.Length > secondArrayCounter)
				{
					if (firstArray[firstArrayCounter] <= secondArray[secondArrayCounter])
					{
						finalArray[i] = firstArray[firstArrayCounter];
						firstArrayCounter++;
						continue;
					}
					else
					{
						finalArray[i] = secondArray[secondArrayCounter];
						secondArrayCounter++;
						continue;
					}
				}

				//Any left over from the first array means it was a bigger array
				if (firstArray.Length > firstArrayCounter && secondArray.Length <= secondArrayCounter)
				{
					finalArray[i] = firstArray[firstArrayCounter];
					firstArrayCounter++;
					continue;
				}

				//Any left over from the second array means it was a bigger array
				if (firstArray.Length <= firstArrayCounter && secondArray.Length > secondArrayCounter)
				{
					finalArray[i] = secondArray[secondArrayCounter];
					secondArrayCounter++;
					continue;
				}
			}

			return finalArray;
		}

		//Merge sort but using an array of BigInteger. So we can test really big numbers
		public BigInteger[] TopDownMergeSort(BigInteger[] array)
		{
			//Array of size 1 or empty.
			if (array.Length <= 1)
			{
				return array;
			}

			var halfOfArrayIndex = array.Length / 2;
			var leftSide = new BigInteger[halfOfArrayIndex];
			var rightSide = new BigInteger[array.Length - halfOfArrayIndex];
			var leftCounter = 0;
			var rightCounter = 0;

			//Split the array to two smaller arrays
			for (var i = 0; i < array.Length; i++)
			{
				if (i < halfOfArrayIndex)
				{
					leftSide[leftCounter] = array[i];
					leftCounter++;
				}
				else
				{
					rightSide[rightCounter] = array[i];
					rightCounter++;
				}
			}

			//Recursively keep splitting the smaller arrays
			leftSide = TopDownMergeSort(leftSide);
			rightSide = TopDownMergeSort(rightSide);

			//Merge each iteration
			return Merge(leftSide, rightSide);
		}

		//Merge function for the array of BigIntegers
		public BigInteger[] Merge(BigInteger[] firstArray, BigInteger[] secondArray)
		{
			var finalArray = new BigInteger[firstArray.Length + secondArray.Length];
			var firstArrayCounter = 0;
			var secondArrayCounter = 0;

			//Compare the first element is each array and the lowest to the new array
			for (var i = 0; i < finalArray.Length; i++)
			{
				if (firstArray.Length > firstArrayCounter && secondArray.Length > secondArrayCounter)
				{
					if (firstArray[firstArrayCounter] <= secondArray[secondArrayCounter])
					{
						finalArray[i] = firstArray[firstArrayCounter];
						firstArrayCounter++;
						continue;
					}
					else
					{
						finalArray[i] = secondArray[secondArrayCounter];
						secondArrayCounter++;
						continue;
					}
				}

				//Any left over from the first array means it was a bigger array
				if (firstArray.Length > firstArrayCounter && secondArray.Length <= secondArrayCounter)
				{
					finalArray[i] = firstArray[firstArrayCounter];
					firstArrayCounter++;
					continue;
				}

				//Any left over from the second array means it was a bigger array
				if (firstArray.Length <= firstArrayCounter && secondArray.Length > secondArrayCounter)
				{
					finalArray[i] = secondArray[secondArrayCounter];
					secondArrayCounter++;
					continue;
				}
			}

			return finalArray;
		}
	}
}
