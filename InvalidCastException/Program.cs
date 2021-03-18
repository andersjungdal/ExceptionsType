using System;

namespace InvalidCastException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OneClass oc = new OneClass();
            int y = Convert.ToInt32(oc);
        }
    }

    public class OneClass
    {
    }
}
