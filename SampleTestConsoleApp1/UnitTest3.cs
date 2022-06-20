using SampleConsoleApp1;
using NUnit.Framework;
using System.Linq;

namespace SampleTestConsoleApp3
{
	/// <summary>
    /// 3番目検索問題
    /// </summary>
	public class IncreaseDecreaseManagementTest
	{

		/// <summary>
        /// 初期処理
        /// </summary>
        [SetUp]
		public void setUp()
		{
		}

		/// <summary>
        /// 終了処理
        /// </summary>
        [TearDown]
		public void tearDown()
        {
        }

        /// <summary>
        /// 3番目検索
        /// </summary>
        /// <remarks>
        /// ６つの数値から3番目に大きい数値を出力
        /// </remarks>
        [TestCase(4,18,25,20,9,13)]
        public void increDecreMng(int a, int b, int c, int d, int e, int f)
        {
            Assert.AreEqual(Program3.Main(a,b,c,d,e,f), 13);
        }
	}
}

