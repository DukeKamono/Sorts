using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingWebSite.Models
{
    public class SortAnswer
    {
		public TimeSpan ResultTime;
		public int[] BegginingArray;
		public int[] SortedArray;

		public SortAnswer(TimeSpan resultTime, int[] begginingArray, int[] sortedArray)
		{
			ResultTime = resultTime;
			BegginingArray = begginingArray;
			SortedArray = sortedArray;
		}
	}
}
