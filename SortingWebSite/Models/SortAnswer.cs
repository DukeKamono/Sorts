using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingWebSite.Models
{
    public class SortAnswer
    {
		public double ResultTime;
		public int[] BegginingArray;
		public int[] SortedArray;

		public SortAnswer(double resultTime, int[] begginingArray, int[] sortedArray)
		{
			ResultTime = resultTime;
			BegginingArray = begginingArray;
			SortedArray = sortedArray;
		}
	}
}
