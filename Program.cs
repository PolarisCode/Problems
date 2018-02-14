using System;

namespace Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(ReverseInteger(-1534236469));
        }

        public static int ReverseInteger(int input)
        {
            //Given a 32-bit signed integer, reverse digits of an integer.
            try
            {
                int num = Math.Abs(input);
                int result = 0;

                while (num > 0)
                {
                    result = checked((num % 10) + result * 10);
                    num = num / 10;
                }

                return (input < 0 ? (-1 * result) : result);
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }

}
