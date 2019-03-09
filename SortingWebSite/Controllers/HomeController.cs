using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SortingWebSite.Models;

namespace SortingWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuickSort()
        {
            ViewData["Message"] = "Select a button to run Quick Sort!";

            return View();
        }

        public IActionResult MergeSort()
        {
            ViewData["Message"] = "Select a button to run Merge Sort!";

            return View();
        }

		public IActionResult HeapSort()
		{
			ViewData["Message"] = "Select a button to run Heap Sort!";

			return View();
		}

		//Serialize this data.
		public List<SortAnswer> GetMergeSort(string inputType, int inputSize, int repeatAmount)
		{
			var result = new List<SortAnswer>();
			for (var i = 0; i < repeatAmount; i++)
			{
				SetupList setup = new SetupList();
				setup.Setup(inputType, inputSize);

				var merge = new MergeSort();
				var list = merge.RunMergeSort(setup);
				
				result.Add(new SortAnswer(merge.ResultTime, setup.currentArray, list));
			}

			return result;
		}

		//Should combine later with the other sort function or something
		public List<SortAnswer> GetQuickSort(string inputType, int inputSize, int repeatAmount)
		{
			var result = new List<SortAnswer>();
			//for (var i = 0; i < repeatAmount; i++)
			//{
			//	SetupList setup = new SetupList();
			//	setup.Setup(inputType, inputSize);

			//	var merge = new QuickSort();
			//	var list = merge.RunQuickSort(setup);

			//	result.Add(new SortAnswer(merge.ResultTime, setup.currentArray, list));
			//}

			return result;
		}

		//Should combine later with the other sort function or something
		public List<SortAnswer> GetHeapSort(string inputType, int inputSize, int repeatAmount)
		{
			var result = new List<SortAnswer>();
			for (var i = 0; i < repeatAmount; i++)
			{
				SetupList setup = new SetupList();
				setup.Setup(inputType, inputSize);

				var merge = new HeapSort();

				//This heapsort messes with the acutal data like a sort function should. it does not return a new int[]
				//So I am making a copy of the currentArray before messing with its data.
				int[] list = (int[])setup.currentArray.Clone();
				merge.RunHeapSort(setup);

				result.Add(new SortAnswer(merge.ResultTime, list, setup.currentArray));
			}

			return result;
		}

		public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
