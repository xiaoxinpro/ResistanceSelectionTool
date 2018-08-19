using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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

        /// <summary>
        /// 输出资源文件
        /// </summary>
        /// <param name="path">输出文件路径</param>
        /// <param name="res">资源文件位置“命令空间.文件夹.文件全名”</param>
        /// <param name="isReplace">是否替换已存在文件</param>
        public static void OutputResFile(string path, string res, bool isReplace = false)
        {
            if (File.Exists(path))
            {
                if (isReplace)
                {
                    File.Delete(path);
                }
                else
                {
                    Console.WriteLine("资源文件已存在，取消释放文件。");
                    return;
                }
            }

            Assembly assm = Assembly.GetExecutingAssembly();
            Stream istr = assm.GetManifestResourceStream(res);
            StreamReader sr = new StreamReader(istr);
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.Write(sr.ReadToEnd());
                Console.WriteLine("资源文件释放完成。");
            }
        }
    }
}
