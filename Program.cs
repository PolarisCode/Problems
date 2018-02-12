using System;

namespace Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseInteger(551);
        }

        public static void ReverseInteger(int input)
        {
            //Given a 32-bit signed integer, reverse digits of an integer.

            int num = input;
            string result = string.Empty;

            while (num > 0)
            {
                result += (num % 10);
                num = num / 10;
            }

            System.Console.WriteLine(input < 0 ? ("-" + result) : result);
        }
    }

}
