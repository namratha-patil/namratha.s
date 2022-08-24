using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class asst2
    { 
        static void Main(string[] args)
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int minNumber;
            if (m<n)
                {
                minNumber = m;
            }
            else
            {
                minNumber = n;
            }
            Console.WriteLine("minimum nuber is:" + minNumber);
            Console.ReadLine();
        }
    }
}

