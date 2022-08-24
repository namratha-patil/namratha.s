using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class asst1
    {
        public static int mul_num(int num1, int num2, int num3)
        {
           
            return num1 * num2 * num3;
        }
        public static void Main()
        { 
            Console.Write("enter number num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enture number num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enture number to num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);
        }
    }
}
