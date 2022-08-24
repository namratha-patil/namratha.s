using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class inout
    {
        public static void APlusB(ref int a, int b)
        {
            a += b;
        }
        public static void Main()
        {
            int a = 10;
            int b = 20;
            APlusB(ref a , b);
            Console.WriteLine($"a={a}, {b}");
        }
    }
}
