using NUnit.Framework;
using SampleConsoleApp1;

namespace SampleTestConsoleApp1
{

    /// <summary>
    /// テストクラス
    /// </summary>
    public class Tests
    {
        /// 定数
        const string Fizz = "Fizz";
        const string Buzz = "Buzz";
        const string FizzBuzz = "FizzBuzz";

        ///// <summary>
        ///// 初期処理
        ///// </summary>
        //[SetUp]
        //public void Setup()
        //{
        //}

        ///// <summary>
        ///// 終了処理
        ///// </summary>
        //[TearDown]
        //public void Final()
        //{
        //}

        /// <summary>
        /// 3で割り切れる数字はFizz
        /// </summary>
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Num3_Fizz(int num)
        {
            string ret = Program.FizzBuzz(num);
            Assert.AreEqual(Fizz, ret);
        }

        /// <summary>
        /// 5で割り切れる数字はBuzz
        /// </summary>
        [TestCase(5)]
        [TestCase(10)]
        public void Num5_Buzz(int num)
        {
            string ret = Program.FizzBuzz(num);
            Assert.AreEqual(Buzz, ret);
        }

        /// <summary>
        /// 15で割り切れる数字はFizzBuzz
        /// </summary>
        [TestCase(15)]
        public void Num15_FizzBuzz(int num)
        {
            string ret = Program.FizzBuzz(num);
            Assert.AreEqual(FizzBuzz, ret);
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
            string ret = Program.FizzBuzz(num);
            Assert.AreEqual(num.ToString(), ret);
        }
    }
}
