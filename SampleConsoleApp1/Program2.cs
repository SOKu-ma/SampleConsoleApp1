using System;
namespace SampleConsoleApp1
{
	/// <summary>
    /// 
    /// </summary>
	public static class Program2
	{
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
            int i = 0;
            bool checkInt = int.TryParse(str, out i);

            // 引数が数値の場合
            if (i != 0)
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

