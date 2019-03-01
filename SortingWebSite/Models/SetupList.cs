using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingWebSite.Models
{
    public class SetupList
    {
		public int[] currentArray;

		//public void Setup(Answers answers)
		//{
		//	try
		//	{
		//		switch (answers.InputTypes)
		//		{
		//			case InputTypes.InOrder:
		//				currentArray = GetInOrder(answers.InputSize);
		//				break;
		//			case InputTypes.ReverseOrder:
		//				currentArray = GetReverseOrder(answers.InputSize);
		//				break;
		//			case InputTypes.Random:
		//				currentArray = GetRandom(answers.InputSize);
		//				break;
		//			case InputTypes.RandomManyDuplicates:
		//				currentArray = GetRandomManyDuplicates(answers.InputSize);
		//				break;
		//			case InputTypes.AllDuplicate:
		//				currentArray = GetAllDuplicate(answers.InputSize);
		//				break;
		//			default:
		//				throw new Exception("Answer input is wrong.");
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine("Exception: " + ex);
		//	}
		//}

		//Returns a array that is in order
		public int[] GetInOrder(int size)
		{
			int[] array = new int[size];

			for (var i = 0; i < size; i++)
			{
				array[i] = i;
			}

			return array;
		}

		//Returns a array that is in order but reversed
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

		//Returns a array that is in order
		public int[] GetAllDuplicate(int size)
		{
			int[] array = new int[size];

			for (var i = 0; i < size; i++)
			{
				array[i] = 42;
			}

			return array;
		}
	}
}
