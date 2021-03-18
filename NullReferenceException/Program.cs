using System;
using System.Collections.Generic;

namespace NullReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            NullReference.function();
        }

    }
    public static class NullReference
    {
        static List<int> l;

        public static void function()
        {
            l.Add(3);
        }
    }

}
