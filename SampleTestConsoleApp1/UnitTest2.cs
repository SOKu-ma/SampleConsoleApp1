using NUnit.Framework;
using SampleConsoleApp1;

namespace SampleTestConsoleApp2
{
	/// <summary>
    /// 2倍チェック問題
    /// </summary>
	public class Tests2
	{
		/// <summary>
        /// 
        /// </summary>
        [SetUp]
		public void setUp()
		{
		}

		/// <summary>
        /// 
        /// </summary>
		[TearDown]
		public void Final()
        {
        }

        /// <summary>
        /// 正常系
        /// </summary>
        /// <remarks>
        /// 数字3桁：入力値の2倍の値を出力
        /// </remarks>
        [TestCase("678")]
        public void inputNum(string strNum)
        {
            // 入力値の2倍と2倍チェックメソッドの返り値を比較
            Assert.AreEqual((int.Parse(strNum) * 2).ToString(), Program2.chekcNum(strNum));
        }

        /// <summary>
        /// 異常系
        /// </summary>
        /// <remarks>
        /// アルファベット3文字："error"を出力
        /// </remarks>
        [TestCase("abc")]
        public void inputAlphabet(string str)
        {
            // 2倍チェックメソッドの返り値が"error"であることを確認
            Assert.AreEqual("error", Program2.chekcNum(str));
        }

        /// <summary>
        /// 異常系
        /// </summary>
        /// <remarks>
        /// 数字と英小文字が混ざった値:"error"を出力
        /// </remarks>
        [TestCase("0x8")]
        public void inputNumAndStr(string str)
        {
            // 2倍チェックメソッドの返り値が"error"であることを確認
            Assert.AreEqual("error", Program2.chekcNum(str));
        }

        /// <summary>
        /// 正常系
        /// </summary>
        /// <remarks>
        /// 数字3桁（0始まり）：入力値の2倍の値を出力
        /// </remarks>
        [TestCase("024")]
        public void inputZeroNum(string strNum)
        {
            // 入力値の2倍と2倍チェックメソッドの返り値を比較
            Assert.AreEqual((int.Parse(strNum) * 2).ToString(), Program2.chekcNum(strNum));
        }

        /// <summary>
        /// 正常系
        /// </summary>
        /// <remarks>
        /// 0：0を出力
        /// </remarks>
        [TestCase("0")]
        public void inputZero(string strNum)
        {
            // 入力値の2倍と2倍チェックメソッドの返り値を比較
            Assert.AreEqual(0.ToString(), Program2.chekcNum(strNum));
        }
    }
}