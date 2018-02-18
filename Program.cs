using System;
using Problem_Solving.SortingAlgorithms;

namespace Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(ReverseInteger(-1534236469));
            //System.Console.WriteLine(IsPalindrome(-10));


            int[] arr= new int[]{5,1,4,9,3};
            new InsertionSort(arr);
            System.Console.WriteLine(string.Join(",",arr));
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

        public static bool IsPalindrome(int input)
        {
            decimal palindromeVer = 0;

            if (input < 0)
                return false;

            int num = input;

            while (num > 0)
            {
                palindromeVer = num % 10 + palindromeVer * 10;
                num = num / 10;
            }

            return palindromeVer == input;
        }

    }

}
