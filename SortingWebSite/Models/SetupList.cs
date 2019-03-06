using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingWebSite.Models
{
    public class SetupList
    {
		public enum InputTypes
		{
			InOrder,
			ReverseOrder,
			Random,
			RandomManyDuplicates,
			AllDuplicate,
			Error
		}

		public int[] currentArray;

		public void Setup(string typeInput, int inputSize)
		{
			var inputTypes = typeInput.Equals(nameof(InputTypes.InOrder), StringComparison.OrdinalIgnoreCase) || typeInput == "1" ? InputTypes.InOrder
					: typeInput.Equals(nameof(InputTypes.ReverseOrder), StringComparison.OrdinalIgnoreCase) || typeInput == "2" ? InputTypes.ReverseOrder
					: typeInput.Equals(nameof(InputTypes.Random), StringComparison.OrdinalIgnoreCase) || typeInput == "3" ? InputTypes.Random
					: typeInput.Equals(nameof(InputTypes.RandomManyDuplicates), StringComparison.OrdinalIgnoreCase) || typeInput == "4" ? InputTypes.RandomManyDuplicates
					: typeInput.Equals(nameof(InputTypes.AllDuplicate), StringComparison.OrdinalIgnoreCase) || typeInput == "5" ? InputTypes.AllDuplicate
					: InputTypes.Error;

			try
			{
				switch (inputTypes)
				{
					case InputTypes.InOrder:
						currentArray = GetInOrder(inputSize);
						break;
					case InputTypes.ReverseOrder:
						currentArray = GetReverseOrder(inputSize);
						break;
					case InputTypes.Random:
						currentArray = GetRandom(inputSize);
						break;
					case InputTypes.RandomManyDuplicates:
						currentArray = GetRandomManyDuplicates(inputSize);
						break;
					case InputTypes.AllDuplicate:
						currentArray = GetAllDuplicate(inputSize);
						break;
					default:
						throw new Exception("Answer input is wrong.");
				}
			}
			catch (Exception ex)
			{
				//Console.WriteLine("Exception: " + ex);
			}
		}

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
