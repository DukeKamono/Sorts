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
			SetupLists setup = new SetupLists();

			do
			{
				setup.Questions();

				//var result = mergeSort.TopDownMergeSort();

				//foreach (var number in result)
				//{
				//	Console.WriteLine(number);
				//}

			} while(Restart());
		}

		//Asks the user if they want to restart the App.
		public static bool Restart()
		{
			Console.WriteLine("Do you want to restart? Yes/No");
			var input = Console.ReadLine();
			if (input.Equals("No", StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			else if (input.Equals("Yes", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}

			return Restart();
		}
	}
}
