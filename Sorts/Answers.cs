using System;

namespace Sorts
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

	class Answers
    {
		public InputTypes InputTypes;
		public string InputList;
		public int InputSize;
		public int InputRepeat;

		//Asks the user questions to get answers from.
		public void Questions()
		{
			var typeEnumInput = InputTypes.Error;
			while (typeEnumInput == InputTypes.Error)
			{
				Console.WriteLine("What would you like to see?");
				int i = 0;
				foreach (var type in Enum.GetValues(typeof(InputTypes)))
				{
					i++;
					if (!type.Equals(InputTypes.Error))
					{
						Console.WriteLine($"{i}. {type}");
					}
					
				}
				Console.WriteLine();

				var typeInput = Console.ReadLine();

				//If the input is the same name as the enum or the number associated with it, then use that enum
				typeEnumInput = typeInput.Equals(nameof(InputTypes.InOrder), StringComparison.OrdinalIgnoreCase) || typeInput == "1" ? InputTypes.InOrder
					: typeInput.Equals(nameof(InputTypes.ReverseOrder), StringComparison.OrdinalIgnoreCase) || typeInput == "2" ? InputTypes.ReverseOrder
					: typeInput.Equals(nameof(InputTypes.Random), StringComparison.OrdinalIgnoreCase) || typeInput == "3" ? InputTypes.Random
					: typeInput.Equals(nameof(InputTypes.RandomManyDuplicates), StringComparison.OrdinalIgnoreCase) || typeInput == "4" ? InputTypes.RandomManyDuplicates
					: typeInput.Equals(nameof(InputTypes.AllDuplicate), StringComparison.OrdinalIgnoreCase) || typeInput == "5" ? InputTypes.AllDuplicate
					: InputTypes.Error;

				if (typeEnumInput == InputTypes.Error)
				{
					Console.Write("Try again. ");
				}

				InputTypes = typeEnumInput;
			}

			var listInput = string.Empty;
			while (string.IsNullOrWhiteSpace(listInput))
			{
				Console.WriteLine("Do you want to run QuickSort or MergeSort? Merge/Quick/Heap \n");
				listInput = Console.ReadLine();

				listInput = listInput.Equals("Merge", StringComparison.OrdinalIgnoreCase) ? "Merge"
					: listInput.Equals("Quick", StringComparison.OrdinalIgnoreCase) ? "Quick"
					: listInput.Equals("Heap", StringComparison.OrdinalIgnoreCase) ? "Heap"
					: string.Empty;

				if (string.IsNullOrWhiteSpace(listInput))
				{
					Console.Write("Try again. ");
				}
			}

			InputList = listInput;

			var intInput = -1;
			while (intInput < 0)
			{
				Console.WriteLine("Enter a size for the array. example: 10 \n");
				//A simple if/else assignment block would do.... but I was having fun with turnaries :)
				intInput = int.TryParse(Console.ReadLine(), out int outIntInput) ? outIntInput > -1 ? outIntInput : -1 : -1;

				if (intInput < 0)
				{
					Console.Write("Try again. ");
				}
			}

			InputSize = intInput;

			var intRepeat = -1;
			while (intRepeat < 0)
			{
				Console.WriteLine("How many interations? example: 10 \n");
				//A simple if/else assignment block would do.... but I was having fun with turnaries :)
				intRepeat = int.TryParse(Console.ReadLine(), out int outIntInput) ? outIntInput > -1 ? outIntInput : -1 : -1;

				if (intRepeat < 0)
				{
					Console.Write("Try again. ");
				}
			}

			InputRepeat = intRepeat;
		}
	}
}
