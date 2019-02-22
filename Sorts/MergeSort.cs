﻿using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Sorts
{
	class MergeSort
    {
		//Using a list and merge sorting it.
		public List<int> TopDownMergeSort(List<int> list)
		{
			if (list.Count <= 1)
			{
				//There is one/no item in this list.
				return list;
			}

			var leftSide = new List<int>();
			var rightSide = new List<int>();

			//Split the list to two smaller lists
			foreach (var item in list.Select((value, index) => new { index, value }))
			{
				if (item.index < (list.Count() / 2))
				{
					leftSide.Add(item.value);
				}
				else
				{
					rightSide.Add(item.value);
				}
			}

			//Recursively keep splitting the smaller lists
			leftSide = TopDownMergeSort(leftSide);
			rightSide = TopDownMergeSort(rightSide);

			//Merge each iteration
			return Merge(leftSide, rightSide);
		}

		//Merge function for the list mergesort
		public List<int> Merge(List<int> firstList, List<int> secondList)
		{
			var finalList = new List<int>();

			//Compare the first element is each list and the lowest to the new list
			while (firstList.Count > 0 && secondList.Count > 0)
			{
				if (firstList.First() <= secondList.First())
				{
					finalList.Add(firstList.First());
					firstList.Remove(firstList.First());
				}
				else
				{
					finalList.Add(secondList.First());
					secondList.Remove(secondList.First());
				}
			}

			//Any left over from the first list means it was a bigger array
			while (firstList.Count > 0)
			{
				finalList.Add(firstList.First());
				firstList.Remove(firstList.First());
			}

			//Any left over from the second list means it was a bigger array
			while (secondList.Count > 0)
			{
				finalList.Add(secondList.First());
				secondList.Remove(secondList.First());
			}

			return finalList;
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