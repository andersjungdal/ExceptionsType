using System;
using System.Collections.Generic;
using System.IO;

namespace ArgumentOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> l = new List<int>();
            Meth(15, l);
        }

        static void Meth(int b, List<int> t)
        {
            for (int i = 0; i < b; i++)
            {
                t[i] = i;
            }
        }
    }
}
