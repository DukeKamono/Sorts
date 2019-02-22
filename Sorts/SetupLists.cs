using System;
using System.Collections.Generic;
using System.Numerics;

namespace Sorts
{
	class SetupLists
    {
		public int[] currentArray;
		public bool isArray;

		public void Setup(Answers answers)
		{
			try
			{
				isArray = answers.InputList == "Array" ? true : false;

				switch (answers.InputTypes)
				{
					case InputTypes.InOrder:
						currentArray = GetInOrder(answers.InputSize);
						break;
					case InputTypes.ReverseOrder:
						currentArray = GetReverseOrder(answers.InputSize);
						break;
					case InputTypes.Random:
						currentArray = GetRandom(answers.InputSize);
						break;
					case InputTypes.RandomManyDuplicates:
						currentArray = GetRandomManyDuplicates(answers.InputSize);
						break;
					default:
						throw new Exception("Answer input is wrong.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception: " + ex);
			}
		}

		//Returns a list that is in order
		public int[] GetInOrder(int size)
		{
			int[] array = new int[size];

			for (var i = 0; i < size; i++)
			{
				array[i] = i;
			}

			return array;
		}

		//Returns a list that is in order but reversed
		public int[] GetReverseOrder(int size)
		{
			int[] array = new int[size];

			for (var i = size; i > 0; i--)
			{
				array[i - 1] = size - i;
			}

			return array;
		}

		//Returns a random set of data for the given size
		public int[] GetRandom(int size)
		{
			int[] array = new int[size];

			for (var i = 0; i < size; i++)
			{
				array[i] = new Random().Next();
			}

			return array;
		}

		//Same as the GetRandom, but half of the data is the number 42
		public int[] GetRandomManyDuplicates(int size)
		{
			int[] array = new int[size];

			for (var i = 0; i < size; i++)
			{
				//Half of the results will come back as 42
				if (i % 2 == 0)
				{
					array[i] = 42;
				}
				else
				{
					array[i] = new Random().Next();
				}
			}

			return array;
		}

		//Prob don't need this....
		//public List<int> GetInOrderList(int size)
		//{
		//	List<int> list = new List<int>();
		//	var i = 0;

		//	while (i < size)
		//	{
		//		list.Add(i);
		//		i++;
		//	}

		//	return list;
		//}

		//Might not use
		//public BigInteger[] GetInOrderBigArray(BigInteger size)
		//{
		//	BigInteger[] bigIntegerArray = new BigInteger[]
		//	{
		//		1000000,
		//		2000000,
		//		3000000,
		//		4000000,
		//		5000000
		//	};

		//	return bigIntegerArray;
		//}
	}
}
