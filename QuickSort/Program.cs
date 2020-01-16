using System;
using static System.Console;

namespace QuickSort
{
    class Program
    {
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int temp;

            while (true)
            {
                while(arr[left]<pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else return right;
            }
        }

        static void Quick_Sort(int[] arr, int left, int right)
        {
            int pivot = Partition(arr, left, right);

            if (left < right)
            {
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 5, 3, 9 };
            Quick_Sort(arr, 0, arr.Length - 1);
            WriteLine("Posortowany ciąg:");
            foreach(var item in arr)
            {
                Write(" " + item);
            }
            ReadKey();
        }
    }
}
