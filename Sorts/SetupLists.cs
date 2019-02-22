using System;
using System.Collections.Generic;
using System.Numerics;

namespace Sorts
{
	class SetupLists
    {
		private enum InputTypes
		{
			InOrder,
			ReverseOrder,
			Random,
			RandomManyDuplicates

		}

		public SetupLists()
		{

		}

		public void Questions()
		{
			var typeInput = string.Empty;
			while (string.IsNullOrWhiteSpace(typeInput))
			{
				Console.WriteLine("What would you like to see?");
				foreach (var type in Enum.GetValues(typeof(InputTypes)))
				{
					Console.WriteLine(type);
				}
				typeInput = Console.ReadLine();

				typeInput = typeInput.Equals(nameof(InputTypes.InOrder), StringComparison.OrdinalIgnoreCase) ? "InOrder"
					: typeInput.Equals(nameof(InputTypes.ReverseOrder), StringComparison.OrdinalIgnoreCase) ? "ReverseOrder"
					: typeInput.Equals(nameof(InputTypes.Random), StringComparison.OrdinalIgnoreCase) ? "Random"
					: typeInput.Equals(nameof(InputTypes.RandomManyDuplicates), StringComparison.OrdinalIgnoreCase) ? "RandomManyDuplicates"
					: string.Empty;

				if (string.IsNullOrWhiteSpace(typeInput))
				{
					Console.Write("Try again. ");
				}
			}

			var listInput = string.Empty;
			while (string.IsNullOrWhiteSpace(listInput))
			{
				Console.WriteLine("Do you want a List or an Array? List/Array");
				listInput = Console.ReadLine();

				listInput = listInput.Equals("List", StringComparison.OrdinalIgnoreCase) ? "List"
					: listInput.Equals("Array", StringComparison.OrdinalIgnoreCase) ? "Array"
					: string.Empty;

				if (string.IsNullOrWhiteSpace(listInput))
				{
					Console.Write("Try again. ");
				}
			}

			var intInput = -1;
			while (intInput < 0)
			{
				Console.WriteLine("Enter a size for the array. example: 10");
				//A simple if/else assignment block would do.... but I was having fun with turnaries :)
				intInput = int.TryParse(Console.ReadLine(), out int outIntInput) ? outIntInput > -1 ? outIntInput : -1 : -1;

				if (intInput < 0)
				{
					Console.Write("Try again. ");
				}
			}
		}

		public List<int> GetInOrderList(int size)
		{
			List<int> list = new List<int>();
			var i = 0;

			while (i < size)
			{
				list.Add(i);
				i++;
			}

			return list;
		}

		public int[] GetInOrderArray(int size)
		{
			int[] array = new int[size - 1];

			for (var i = 0; i < 51; i++)
			{
				array[i] = i;
			}

			return array;
		}

		//Might not use
		public BigInteger[] GetInOrderBigArray(BigInteger size)
		{
			BigInteger[] bigIntegerArray = new BigInteger[]
			{
				1000000,
				2000000,
				3000000,
				4000000,
				5000000
			};

			return bigIntegerArray;
		}
	}
}
