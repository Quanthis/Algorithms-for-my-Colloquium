using System;
using static System.Console;

namespace ZapisLiczbyWPostaciBinarnej
{
    class Program
    {
        static void ZapisDwojkowy(int a)
        {
            int b;
            int j = 0;
            int[] d=new int [1000];

            while (a > 1)
            {
                b = a % 2;
                d[a] = b;
                a /= 2;
                j++;
            }

            WriteLine("Zapisa dwójkowy:");
            for (int i=1; i<=j; i++)
            {
                Write(d[i]);
            }
            WriteLine($"Długość: {j}");
        }

        static void Main(string[] args)
        {
            ZapisDwojkowy(10);
        }
    }
}
