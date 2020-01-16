using System;
using static System.Console;

namespace Fibbonaci
{
    class Program
    {
        static long RekursywnyFib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else return (RekursywnyFib(n - 1) + RekursywnyFib(n - 2));
        }

        static long IteracyjnyFib(int n)
        {
            int a = 0;
            int b = 1;
            int temp;

            for (int i=0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            WriteLine($"Wynik dla metody rekurencyjnej: {RekursywnyFib(10)}");
            WriteLine($"Wynik dla metody iteracyjnej: {IteracyjnyFib(10)}");
        }
    }
}
