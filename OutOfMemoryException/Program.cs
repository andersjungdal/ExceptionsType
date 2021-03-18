using System;

namespace OutOfMemoryException
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 8754;
            int a = 8754;
            int b = 8754;
            int w = 8754;
            int t = 8754;
            int h = 8754;
            int y = 8754;
            int j = 8754;
            int k = 8754;
            while (true)
            {
                g *= 10005;
                Console.WriteLine(g);
                a *= 10005;
                Console.WriteLine(g);
                b *= 10005;
                Console.WriteLine(g);
                w *= 10005;
                Console.WriteLine(g);
                t *= 10005;
                Console.WriteLine(g);
                h *= 10005;
                Console.WriteLine(g);
                y *= 10005;
                Console.WriteLine(g);
                j *= 10005;
                Console.WriteLine(g);
                k *= 10005;
                Console.WriteLine(g);
            }

        }
    }
}
