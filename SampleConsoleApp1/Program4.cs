using System;
using System.Collections.Generic;
using System.Linq;
namespace SampleConsoleApp1
{
    public class Program4
    {
        /// <summary>
        /// 重複チェック問題
        /// </summary>
        /// <param name="GetList">数値のリスト</param>
        /// <returns>
        /// 値に重複あり：重複した値、不足の値
        /// 値に重複なし：correct
        /// </returns>
        public static string checkDuplicate(List<String> GetList)
        {

            List<String> list = GetList;

            // リストの２番目から最後まででループ
            for (int i = 1; i < int.Parse(list[0]); i++)
            {
                // リスト2個目以降の値で検索
                if (list.FindAll(x => x == list[i]) != null)
                {
                    return "";
                };
            }

            return "Correct";
        }
    }
}