using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class Program
    {
        static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = unsorted.Count / 2;

            for (int i=0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i=middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);

        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> Result = new List<int>();
            while(left.Count>0 || right.Count > 0)
            {
                if ((left.Count > 0) && (right.Count > 0))
                {
                    if (left.First() <= right.First())
                    {
                        Result.Add(right.First());
                        right.Remove(right.First());
                    }
                    else
                    {
                        Result.Add(left.First());
                        left.Remove(left.First());
                    }

                }
                else if (left.Count > 0)
                {
                    Result.Add(left.First());
                    left.Remove(left.First());

                }
                else if (right.Count > 0)
                {
                    Result.Add(right.First());
                    right.Remove(right.First());

                }

            }
            return Result;
        }

        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();
            WriteLine("Oryginalny ciąg:");
            for (int i=0; i<10; i++)
            {
                unsorted.Add(random.Next(1, 100));
                Write(unsorted[i] + " ");
            }
            WriteLine();

            sorted = MergeSort(unsorted);

            WriteLine("Posortowany ciąg:");
            foreach(int x in sorted)
            {
                Write(x+" ");
            }
            ReadKey();
        }
    }
}
