using System.Collections.Generic;
using System;

namespace SampleConsoleApp1
{
	public class Program3
	{
        /// <summary>
        /// 3番目検索問題
        /// </summary>
        /// <param name="strNums"></param>
        public static int IncreDecreMng(string strNums)
        {
            // 文字列の変換
            // 半角スペース区切りでSplitした文字列を配列に格納
            String[] arrNums = strNums.Split(" ");
            List<int> listNums = new List<int>();

            // パラメータの数値は6つで固定
            for (int i = 0; i < arrNums.Length; i++)
            {
                // 配列中の文字列を数値に変換してList<Int>に格納
                listNums.Add(int.Parse(arrNums[i]));
            }
            listNums.Sort();

            // ソート結果後の3番目の値を返す
            return listNums[2];
        }

        /// <summary>
        /// 3番目検索問題
        /// </summary>
        /// <remarks>
        /// 提出用
        /// </remarks>
        public static void Main3()
        {
            // 文字列の変換
            // 半角スペース区切りでSplitした文字列を配列に格納
            String[] arrNums = Console.ReadLine().Split(' ');
            List<int> listNums = new List<int>();

            // パラメータの数値は6つで固定
            for (int i = 0; i < arrNums.Length; i++)
            {
                // 配列中の文字列を数値に変換してList<Int>に格納
                listNums.Add(int.Parse(arrNums[i]));
            }
            listNums.Sort();

            // ソート結果後の3番目の値を返す
            Console.WriteLine(listNums[2]);
        }
    }
}