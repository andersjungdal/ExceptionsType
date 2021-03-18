using System;

namespace DivideByZeroException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SomeClass sc = new SomeClass();
            int q = sc.DivideByZero();
            Console.WriteLine(q);
        }
    }

    class SomeClass
    {
        public int h { get; set; } = 0;

        public int DivideByZero()
            => SomeOtherClass.w / h;
    }

    static class SomeOtherClass
    {
        public static int w = 67;
    }
}
