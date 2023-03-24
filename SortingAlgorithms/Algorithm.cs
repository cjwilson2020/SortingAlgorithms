using System;
using System.Reflection;

namespace SortingAlgorithms
{
	public class Algorithm : IAlgorithm
	{
		public static void Main(string[] args)
		{
			Algorithm alg = new Algorithm();
			// MergeSort
			Console.WriteLine("MergeSort:");
			int[] A = new[] { 8, 3, 20, 1, 9, 15, 18, 6, 2, 13, 11 };
			foreach (int element in A)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine();
			int a = 0;
			int b = A.Length - 1;
			alg.MergeSort(A, a, b);

			foreach (int element in A)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine();

			// QuickSort
			Console.WriteLine("QuickSort:");
			A = new[] { 8, 3, 20, 1, 9, 15, 18, 6, 2, 13, 11 };
			foreach (int element in A)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine();
			a = 0;
			b = A.Length - 1;
			alg.QuickSort(A, a, b);

			foreach (int element in A)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine();

			// BubbleSort
			Console.WriteLine("BubbleSort:");
			A = new[] { 8, 3, 20, 1, 9, 15, 18, 6, 2, 13, 11 };
			foreach (int element in A)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine();

			A = alg.BubbleSort(A);

			foreach (int element in A)
			{
				Console.Write($"{element} ");
			}
			Console.WriteLine();
		}

		public int[] MergeSort(int[] A, int a, int b)
		{
			if (b > a)
			{
				int m = (a + b) / 2;
				MergeSort(A, a, m);
				MergeSort(A, m + 1, b);
				Merge(A, a, m, b);
			}
			return A;
		}

		private void Merge(int[] A, int a, int m, int b)
		{
			int[] B = new int[A.Length];
			int i = 0;
			int j = 0;

			var leftALength = m - a + 1;
			var rightALength = b - m;
			var leftTempA = new int[leftALength];
			var rightTempA = new int[rightALength];

			//Fill temp As
			for (i = 0; i < leftALength; ++i)
				leftTempA[i] = A[a + i];
			for (j = 0; j < rightALength; ++j)
				rightTempA[j] = A[m + 1 + j];

			i = 0;
			j = 0;
			int k = a; // k from a to b (leftA + rightA length )

			while (i < leftALength && j < rightALength)
			{
				if (leftTempA[i] <= rightTempA[j])
				{
					A[k++] = leftTempA[i++];
				}
				else
				{
					A[k++] = rightTempA[j++];
				}
			}

			while (i < leftALength)
			{
				A[k++] = leftTempA[i++];
			}
			while (j < rightALength)
			{
				A[k++] = rightTempA[j++];
			}
		}

		public int[] QuickSort(int[] A, int a, int b)
		{
			var i = a;
			var j = b;
			var pivot = A[a];
			while (i <= j)
			{
				while (A[i] < pivot)
				{
					i++;
				}

				while (A[j] > pivot)
				{
					j--;
				}
				if (i <= j)
				{
					int temp = A[i];
					A[i] = A[j];
					A[j] = temp;
					i++;
					j--;
				}
			}

			if (a < j)
				QuickSort(A, a, j);
			if (i < b)
				QuickSort(A, i, b);
			return A;
		}

		public int[] BubbleSort(int[] A)
		{
			var n = A.Length;

			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (A[j] > A[j + 1])
					{
						var temp = A[j];
						A[j] = A[j + 1];
						A[j + 1] = temp;
					}
				}
			}
			return A;
		}
	}
}