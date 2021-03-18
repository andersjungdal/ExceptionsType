using System;

namespace StackOverflowException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RecursionFunction1(0);
        }

        public static int RecursionFunction1(int i)
        {
            NestedRecursionFunction(i);
            if (i == 10)
                return 1;
            return RecursionFunction1(i + 1);
        }

        public static int NestedRecursionFunction(int j)
        {
            if (j.Equals(5))
                return 0;
            Console.WriteLine(j);
            return NestedRecursionFunction(j + 1);
        }

    }
}
