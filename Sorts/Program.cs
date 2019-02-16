﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> firstList = new List<int>
			{
				3,
				2,
				1,
				4
			};

			var test = TopDownMergeSortList(firstList);

            test.ForEach(Console.WriteLine);

			Console.ReadLine();
        }

		public static List<int> TopDownMergeSortList(List<int> list)
		{
			if (list.Count <= 1)
			{
				//There is only one item in this list.
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
			leftSide = TopDownMergeSortList(leftSide);
			rightSide = TopDownMergeSortList(rightSide);

			//Merge each iteration
			return Merge(leftSide, rightSide);
		}

		public static List<int> Merge(List<int> firstList, List<int> secondList)
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

		public static List<int> TopDownMergeSortArray(List<int> list)
		{
			return list;
		}
    }
}
