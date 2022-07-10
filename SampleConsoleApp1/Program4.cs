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

            List<String> list = new List<string>();

            var duplicate = list.GroupBy(l => l)
                .Where(l => l.Count() > 1)
                .Select(group => group.Key)
                .ToList();

            Console.WriteLine(duplicate);

            return "";
        }
    }
}