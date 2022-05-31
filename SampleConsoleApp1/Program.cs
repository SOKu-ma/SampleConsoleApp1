using System;

namespace SampleConsoleApp1
{
    public static class Program
    {
        /// 定数
        const string conFizz = "Fizz";
        const string conBuzz = "Buzz";
        const string conFizzBuzz = "FizzBuzz";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// FizzBuzz問題
        /// </summary>
        /// <remarks>
        /// 3で割り切れる：Fizz
        /// 5で割り切れる：Buzz
        /// 15で割り切れる：FizzBuzz
        /// </remarks>
        /// <param name="num">整数値</param>
        public static String FizzBuzz(int num)
        {
            if (num % 15 == 0)
            {
                return conFizzBuzz;
            }
            else if (num % 5 == 0)
            {
                return conBuzz;
            }
            else
            {
                return conFizz;
            }
        }
    }
}