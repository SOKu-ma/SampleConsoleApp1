using System;
namespace SampleConsoleApp1
{
    /// <summary>
    /// 2倍チェック問題
    /// </summary>
    public static class Program2
	{

        /// <summary>
        /// 提出版
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static void TestAtCoder()
        {

            // インプット値を取得
            String str = Console.ReadLine().ToString();
            int i = 0;
            bool checkInt = int.TryParse(str, out i);

            // 整数値の場合
            if (checkInt)
            {
                // 0の場合は0を返す
                if (int.Parse(str) == 0)
                {
                    Console.WriteLine(0.ToString());
                }
                else
                {
                    Console.WriteLine((int.Parse(str) * 2).ToString());
                }
            }
            // 数値以外（文字列含む）
            else
            {
                Console.WriteLine("error");
            }

            //// インプット値を取得
            //String str = Console.ReadLine().ToString();

            //int i = 0;
            //bool checkInt = int.TryParse(str, out i);

            //// 整数値の場合
            //if (i != 0)
            //{
            //    // インプット値の2倍の数値を出力
            //    Console.WriteLine((int.Parse(str) * 2).ToString());
            //}
            //// 数値以外（数字含む文字列も含む）の場合
            //else
            //{
            //    Console.WriteLine("error");
            //}
        }

        /// <summary>
        /// Mainメソッド
        /// </summary>
        /// <param name="args"></param>
        public static void Main2(string[] args)
		{
			Console.WriteLine("2倍チェック問題");
		}

		/// <summary>
        /// 2倍チェック問題
        /// </summary>
        /// <returns>
        /// 数字のみ（0始まり含む）：引数の2倍の値
        /// 英字、英数字："error"
        /// </returns>
		public static String chekcNum(string str)
        {
            // 引数を判定
            // 数値の場合はそのまま
            //int i = 0;
            bool checkInt = int.TryParse(str, out int i);

            // 引数が数値の場合
            if (checkInt)
            {
                return (int.Parse(str) * 2).ToString();
            }
            // 引数が英数字の場合
            else
            {
                return "error";
            }
        }
	}
}

