using NUnit.Framework;
using SampleConsoleApp1;

namespace SampleTestConsoleApp1
{

    /// <summary>
    /// テストクラス
    /// </summary>
    public class Tests1
    {
        /// 定数
        const string FIZZ = "Fizz";
        const string BUZZ = "Buzz";
        const string FIZZBUZZ = "FizzBuzz";

        /// <summary>
        /// 初期処理
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// 終了処理
        /// </summary>
        [TearDown]
        public void Final()
        {
        }

        /// <summary>
        /// 3で割り切れる数字はFizz
        /// </summary>
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Num3_Fizz(int num)
        {
            string ret = FizzBuzz.CheckFizzBuzz(num);
            Assert.AreEqual(FIZZ, ret);
        }

        /// <summary>
        /// 5で割り切れる数字はBuzz
        /// </summary>
        [TestCase(5)]
        [TestCase(10)]
        public void Num5_Buzz(int num)
        {
            string ret = FizzBuzz.CheckFizzBuzz(num);
            Assert.AreEqual(BUZZ, ret);
        }

        /// <summary>
        /// 15で割り切れる数字はFizzBuzz
        /// </summary>
        [TestCase(15)]
        public void Num15_FizzBuzz(int num)
        {
            string ret = FizzBuzz.CheckFizzBuzz(num);
            Assert.AreEqual(FIZZBUZZ, ret);
        }

        /// <summary>
        /// FizzBuzzの数字以外はそのまま返す
        /// </summary>
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        public void Num_FizzBuzz(int num)
        {
            string ret = FizzBuzz.CheckFizzBuzz(num);
            Assert.AreEqual(num.ToString(), ret);
        }
    }
}
