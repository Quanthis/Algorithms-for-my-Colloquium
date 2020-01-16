using System;
using static System.Console;

namespace NWD
{
    class Program
    {
        static int NWD(int a, int b)
        {
            int tmp, d;
            while (b!=0)
            {
                tmp = b;
                b = a % b;
                a = tmp;                
            }
            d = a;
            return d;
        }


        static void Main(string[] args)
        {
            WriteLine(NWD(64, 16));            
        }
    }
}
