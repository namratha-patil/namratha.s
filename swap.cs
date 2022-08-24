

namespace trainee
{
    internal class swap
    {
        static void SwapNum(ref int x, ref int y)
        {

            int tempswap = x;
            x = y;
            y = tempswap;
        }
        public static void Main()
        {

            int x = 10, y = 20;
            Console.WriteLine($"Before swapping{x},{y}");
            SwapNum(ref x, ref y);
            Console.WriteLine($"After swapping{x},{y}");

        }
    }
}
