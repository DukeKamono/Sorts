using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Sorts
{
	class Program
	{
		static void Main(string[] args)
		{
			MergeSort mergeSort = new MergeSort();

			List<int> firstList = new List<int>
			{
				3,
				2,
				1,
				5,
				4
			};

			var listResult = mergeSort.TopDownMergeSort(firstList);

			listResult.ForEach(Console.WriteLine);

			double[] firstArray = new double[]
			{
				3,
				2,
				1,
				5,
				4
			};

			var arrayResult = mergeSort.TopDownMergeSort(firstArray);

			arrayResult.ToList().ForEach(Console.WriteLine);

			BigInteger[] bigIntegerArray = new BigInteger[]
			{
				3000000,
				2000000,
				1000000,
				5000000,
				4000000
			};

			var bigIntegerArrayResult = mergeSort.TopDownMergeSort(bigIntegerArray);

			foreach (var number in bigIntegerArrayResult)
			{
				Console.WriteLine(number);
			}

			Console.ReadLine();
		}
	}
}
