using ProjectA;
using System;

namespace ProjectC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new StringProvider().Provide());
        }
    }
}
