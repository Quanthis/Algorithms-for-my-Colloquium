using System;
using static System.Console;

namespace PierwszaLorazLLenght
{
    class Program
    {
        static void PierwszaCyfraIDlugoscLiczby(uint a)
        {
            int i = 1;
            while (a >= 10)
            {
                a /= 10;
                i++;
            }
            WriteLine($"Pierwsza cyfra: {a}");
            WriteLine($"Długość liczby: {i}");
        }


        static void Main(string[] args)
        {
            PierwszaCyfraIDlugoscLiczby(555);
        }
    }
}
