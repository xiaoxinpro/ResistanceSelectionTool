using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ResistanceSelectionTool
{
    public static class ListFileHelper
    {
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="dic">数据</param>
        public static void WriteFile(string path, Dictionary<string, string> dic)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (KeyValuePair<string, string> item in dic)
                {
                    sw.WriteLine(item.Key + "," + item.Value);
                }
            }
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="dic">数据</param>
        public static void ReadFile(string path, Dictionary<string, string> dic)
        {
            dic.Clear();
            if (!File.Exists(path))
            {
                return;
            }
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string[] arrData = sr.ReadLine().Trim().ToString().Split(',');
                    if (arrData.Length >= 2)
                    {
                        dic.Add(arrData[0], arrData[1]);
                    }
                }
            }
        }
    }
}
