using System;
using System.Collections.Generic;
using NUnit.Framework;
using SampleConsoleApp1;

namespace SampleTestConsoleApp4
{
    /// <summary>
    /// 重複検査確認テストクラス
    /// </summary>
    /// <remarks>
    /// 重複している数値があればその数値を返す
    /// 重複している数値がなければ"Correct"の文字列を返す
    /// </remarks>
    public class CheckDuplicateTest
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
        /// 重複ありのケース
        /// </summary>
        /// <remarks>
        /// 重複した数値が返ることを確認
        /// 先頭データ：数値の数
        /// 2〜N行目：数値
        /// </remarks>
        [Test]
        public void checkDupli()
        {
            // テストデータ
            List<String> list = new List<string> { "6", "1", "5", "6", "3", "2", "6" };

            // 重複データ：6
            // 不足データ：4
            Assert.AreEqual(Program4.checkDuplicate(list), "6 4");
        }

        /// <summary>
        /// 重複なしのケース
        /// </summary>
        /// <remarks>
        /// 文字列"Correct"が返ることを確認
        /// </remarks>
        [Test]
        public void checkNotDupli()
        {
            // テストデータ
            List<String> list = new List<string> { "7", "5", "4", "3", "2", "7", "6", "1" };

            // 重複データ：なし
            // 返り値：correct
            Assert.AreEqual(Program4.checkDuplicate(list), "correct");
        }

    }
}

