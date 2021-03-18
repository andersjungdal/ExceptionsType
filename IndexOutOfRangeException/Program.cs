using System;

namespace IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Method();
        }

        static void Method()
        {
            int[] ar = new int[12];
            for (int i = 0; i <= ar.Length; i++)
            {
                ar[i] = i;
                Console.WriteLine(i);
            }
        }
    }
}
