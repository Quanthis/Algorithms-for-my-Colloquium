using System;

namespace SymbolNewtona
{
    class Program
    {
        static long SymbolNewtona(int n, int k)
        {
            long w = 1;
            for (int i=1; i<=k; i++)
            {
                w = w * (n - i + 1) / i;
            }
            return w;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SymbolNewtona(5, 3));
        }
    }
}
