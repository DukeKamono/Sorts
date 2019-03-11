using System;
using System.Collections.Generic;

namespace Sorts
{
	class Program
	{
		static void Main(string[] args)
		{
			MergeSort mergeSort = new MergeSort();
            QuickSort quickSort = new QuickSort();
			SetupLists setup = new SetupLists();
			Answers answers = new Answers();
			var resultList = new List<string>();

			do
			{
				//All the qestions for the console app.
				answers.Questions();
				//Takes the answers to get the right list.
				setup.Setup(answers);

				var result = new int[answers.InputSize];

				if (answers.InputList == "Quick")
				{
                    for (var i = 0; i < answers.InputRepeat; i++)
                    {
                        //Quick sort stuff here
                        if (setup.currentArray.Length <= 1)
                        {
                            result = setup.currentArray;
                        }
                        else
                        {
                            result = quickSort.RunQuickSort(setup);
                        }
                        Console.WriteLine($"\nTime: {quickSort.ResultTime}");
                        resultList.Add($"Time: {quickSort.ResultTime}");
                    }
				}
				else
				{
					for (var i = 0; i < answers.InputRepeat; i++)
					{
						//Update the MergeSort Object with the values from the SetupLists object
						result = mergeSort.RunMergeSort(setup);
						Console.WriteLine($"\nTime: {mergeSort.ResultTime}");
						resultList.Add($"Time: {mergeSort.ResultTime}");
					}
				}

				Console.WriteLine("Results:");
				resultList.Add("Results:");
				foreach (var number in result)
				{
					resultList.Add(number.ToString());
					Console.WriteLine(number);
				}

				//Save to file Sorts\bin\Debug
				var FilePath = @"..\Results" + DateTime.Now.ToString("yyyyddM--HH-mm-ss") + ".txt";
				System.IO.File.WriteAllLines(FilePath, resultList);

			} while(Restart());
		}

		//Asks the user if they want to restart the App.
		public static bool Restart()
		{
			Console.WriteLine("\nDo you want to restart? Yes/No \n");
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
