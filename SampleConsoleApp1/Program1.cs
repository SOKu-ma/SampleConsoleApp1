using System;

namespace SampleConsoleApp1
{
    /// <summary>
    /// FizzBuzzクラス
    /// </summary>
    public static class FizzBuzz
    {
        /// 定数
        const string conFizz = "Fizz";
        const string conBuzz = "Buzz";
        const string conFizzBuzz = "FizzBuzz";

        /// <summary>
        /// Mainメソッド
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz問題");
        }

        /// <summary>
        /// FizzBuzz問題
        /// </summary>
        /// <remarks>
        /// 3で割り切れる：Fizz
        /// 5で割り切れる：Buzz
        /// 15で割り切れる：FizzBuzz
        /// 上記以外：そのままの数
        /// </remarks>
        /// <param name="num">整数値</param>
        public static String CheckFizzBuzz(int num)
        {
            // 15で割り切れる
            if (num % 15 == 0)
            {
                return conFizzBuzz;
            }
            // 5で割り切れる
            else if (num % 5 == 0)
            {
                return conBuzz;
            }
            // 3で割り切れる
            else if (num % 3 == 0)
            {
                return conFizz;
            }
            // それ以外はそのまま返す
            else
            {
                return num.ToString();
            }
        }
    }
}