using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
	public interface IAlgorithm
	{
		public  int[] MergeSort(int[] A, int a, int b);
		public int[] QuickSort(int[] A, int a, int b);
		public int[] BubbleSort(int[] A);
	}
}
