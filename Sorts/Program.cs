using System;
using System.Collections.Generic;
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



            Console.WriteLine("Hello World!");
        }

		public static List<int> TopDownMergeSort(List<int> list)
		{
			if (list.Count <= 1)
			{
				//There is only one item in this list.
				return list;
			}


			return list;
		}

		public static List<int> BottomUpMergeSort(List<int> list)
		{
			return list;
		}
    }
}
