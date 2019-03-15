using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingWebSite.Models;

namespace UnitTestProject1
{
	[TestClass]
	public class SortTests
	{
		public int[] InOrder = new int[]
		{
			1,
			2,
			3,
			4,
			5
		};

		public int[] ReverseOrder = new int[]
		{
			5,
			4,
			3,
			2,
			1
		};

		public int[] Random = new int[]
		{
			52,
			77,
			2,
			99,
			43
		};

		public int[] RandomManyDuplicate = new int[]
		{
			123,
			42,
			66,
			42,
			5
		};

		public int[] Duplicate = new int[]
		{
			42,
			42,
			42,
			42,
			42
		};

		[TestMethod]
		public void MergeSortInOrder()
		{
			int[] Expected = new int[]
			{
				1,
				2,
				3,
				4,
				5
			};

			MergeSort mergeSort = new MergeSort();
			SetupList setupList = new SetupList
			{
				currentArray = InOrder
			};

			var result = mergeSort.RunMergeSort(setupList);

			CollectionAssert.AreEqual(Expected, result);
		}

		[TestMethod]
		public void MergeSortReverseOrder()
		{
			int[] Expected = new int[]
			{
				1,
				2,
				3,
				4,
				5
			};

			MergeSort mergeSort = new MergeSort();
			SetupList setupList = new SetupList
			{
				currentArray = ReverseOrder
			};

			var result = mergeSort.RunMergeSort(setupList);

			CollectionAssert.AreEqual(Expected, result);
		}

		[TestMethod]
		public void MergeSortRandom()
		{
			int[] Expected = new int[]
			{
				2,
				43,
				52,
				77,
				99
			};

			MergeSort mergeSort = new MergeSort();
			SetupList setupList = new SetupList
			{
				currentArray = Random
			};

			var result = mergeSort.RunMergeSort(setupList);

			CollectionAssert.AreEqual(Expected, result);
		}

		[TestMethod]
		public void MergeSortRandomManyDuplicate()
		{
			int[] Expected = new int[]
			{
				5,
				42,
				42,
				66,
				123
			};

			MergeSort mergeSort = new MergeSort();
			SetupList setupList = new SetupList();

			setupList.currentArray = RandomManyDuplicate;

			var result = mergeSort.RunMergeSort(setupList);

			CollectionAssert.AreEqual(Expected, result);
		}

		[TestMethod]
		public void MergeSortDuplicate()
		{
			int[] Expected = new int[]
			{
				42,
				42,
				42,
				42,
				42
			};

			MergeSort mergeSort = new MergeSort();
			SetupList setupList = new SetupList();

			setupList.currentArray = Duplicate;

			var result = mergeSort.RunMergeSort(setupList);

			CollectionAssert.AreEqual(Expected, result);
		}

		[TestMethod]
		public void QuickSortInOrder()
		{
			int[] Expected = new int[]
			{
				1,
				2,
				3,
				4,
				5
			};

			QuickSort quickSort = new QuickSort();
			SetupList setupList = new SetupList
			{
				currentArray = InOrder
			};

			quickSort.RunQuickSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void QuickSortReverseOrder()
		{
			int[] Expected = new int[]
			{
				1,
				2,
				3,
				4,
				5
			};

			QuickSort quickSort = new QuickSort();
			SetupList setupList = new SetupList
			{
				currentArray = ReverseOrder
			};

			quickSort.RunQuickSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void QuickSortRandom()
		{
			int[] Expected = new int[]
			{
				2,
				43,
				52,
				77,
				99
			};

			QuickSort quickSort = new QuickSort();
			SetupList setupList = new SetupList
			{
				currentArray = Random
			};

			quickSort.RunQuickSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void QuickSortRandomManyDuplicate()
		{
			int[] Expected = new int[]
			{
				5,
				42,
				42,
				66,
				123
			};

			QuickSort quickSort = new QuickSort();
			SetupList setupList = new SetupList
			{
				currentArray = RandomManyDuplicate
			};

			quickSort.RunQuickSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void QuickSortDuplicate()
		{
			int[] Expected = new int[]
			{
				42,
				42,
				42,
				42,
				42
			};

			QuickSort quickSort = new QuickSort();
			SetupList setupList = new SetupList
			{
				currentArray = Duplicate
			};

			quickSort.RunQuickSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void HeapSortInOrder()
		{
			int[] Expected = new int[]
			{
				1,
				2,
				3,
				4,
				5
			};

			HeapSort heapSort = new HeapSort();
			SetupList setupList = new SetupList
			{
				currentArray = InOrder
			};

			heapSort.RunHeapSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void HeapSortReverseOrder()
		{
			int[] Expected = new int[]
			{
				1,
				2,
				3,
				4,
				5
			};

			HeapSort heapSort = new HeapSort();
			SetupList setupList = new SetupList
			{
				currentArray = ReverseOrder
			};

			heapSort.RunHeapSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void HeapSortRandom()
		{
			int[] Expected = new int[]
			{
				2,
				43,
				52,
				77,
				99
			};

			HeapSort heapSort = new HeapSort();
			SetupList setupList = new SetupList
			{
				currentArray = Random
			};

			heapSort.RunHeapSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void HeapSortRandomManyDuplicate()
		{
			int[] Expected = new int[]
			{
				5,
				42,
				42,
				66,
				123
			};

			HeapSort heapSort = new HeapSort();
			SetupList setupList = new SetupList
			{
				currentArray = RandomManyDuplicate
			};

			heapSort.RunHeapSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}

		[TestMethod]
		public void HeapSortDuplicate()
		{
			int[] Expected = new int[]
			{
				42,
				42,
				42,
				42,
				42
			};

			HeapSort heapSort = new HeapSort();
			SetupList setupList = new SetupList
			{
				currentArray = Duplicate
			};

			heapSort.RunHeapSort(setupList);

			CollectionAssert.AreEqual(Expected, setupList.currentArray);
		}
	}
}
