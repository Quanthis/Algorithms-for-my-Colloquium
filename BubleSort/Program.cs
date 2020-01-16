using System;
using static System.Console;

namespace BubleSort
{
    class Program
    {

        static void BubbleSort(int [] d, int n)
        {
            int tmp;

            do
            {
                for (int i = 0; i < n; i++)
                {
                    if (d[i] > d[i + 1])
                    {
                        tmp = d[i];
                        d[i] = d[i + 1];
                        d[i + 1] = tmp;
                    }
                    n--;
                }
            } while (n > 1);
        }

        static void Main(string[] args)
        {            
            WriteLine("Podaj liczbę elementów tablicy:");
            int n=Convert.ToInt32(ReadLine());
            int[] d = new int[n];
            Write("Podaj elementy tablicy:");
            for (int k = 0; k < n; k++)
            {
                d[k] = Convert.ToInt32(ReadLine());
            }
            BubbleSort(d, n);
            foreach(int elem in d)
            {
                Write(elem);
            }
        }
    }
}
