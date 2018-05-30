using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace ConfigHelper
{
    /// <summary>
    /// 写入文本文件
    /// </summary>
    public class CSVHelper
    {
        /// <summary>
        /// 默认csv文件全路径：当前路径\\Default.csv
        /// </summary>
        public static string csvFullPath = GetDefaultPathCSV();
        public static string GetDefaultPathCSV()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            return path + "\\Default.csv";
        }

        #region 将datatable写入csv文本文件
        /// <summary>
        /// 将datatable数据全部写入csv中，按逗号分割，列标题作为第一行
        /// 默认路径：当前路径\\Default.csv
        /// </summary>
        /// <param name="dt">datatable数据源</param>
        public static void WriteCSV(DataTable dt)
        {
            WriteCSV(dt, csvFullPath, ',');
        }
        /// <summary>
        /// 将datatable数据全部写入csv中，按逗号分割，列标题作为第一行
        /// </summary>
        /// <param name="dt">datatable数据源</param>
        /// <param name="fullPath">需要写入的csv文件的完整路径</param>
        public static void WriteCSV(DataTable dt, string fullPath)
        {
            WriteCSV(dt, fullPath, ',');
        }
        /// <summary>
        /// 将datatable数据全部写入csv中，按指定分隔符分割，列标题作为第一行
        /// </summary>
        /// <param name="dt">datatable数据源</param>
        /// <param name="fullPath">需要写入的csv文件的完整路径</param>
        public static void WriteCSV(DataTable dt, string fullPath, char chr)
        {
            FileInfo file = new FileInfo(fullPath);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            string data = "";
            //写列名
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName.ToString() + ",";
            }
            sw.WriteLine(data);
            //写数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string str = dt.Rows[i][j].ToString();
                    str = str.Replace("\"", "\"\"");
                    if (str.Contains(',') || str.Contains('"') || str.Contains('\r') || str.Contains('\n'))
                    {
                        str = string.Format("\"{0}\"", str);
                    }
                    data += str + chr;
                }
                sw.WriteLine(data);
            }
            sw.Close();
            fs.Close();
        }
        #endregion

        #region 读取csv文件到datatable

        /// <summary>
        /// 读取默认csv文件中所有数据到datatable中，第一行为列标题，其余为数据，列数以标题为主，按逗号分割
        /// 默认路径：当前路径\\Default.csv
        /// </summary>
        /// <returns>返回包含csv数据的datatable，如果错误则返回Null</returns>
        public static DataTable ReadCSV()
        {
            return ReadCSV(csvFullPath, ',');
        }
        /// <summary>
        /// 读取csv文件中所有数据到datatable中，第一行为列标题，其余为数据，列数以标题为主，按逗号分割
        /// </summary>
        /// <param name="csvPath">csv文件的完整路径</param>
        /// <returns>返回包含csv数据的datatable，如果错误则返回Null</returns>
        public static DataTable ReadCSV(string csvPath)
        {
            return ReadCSV(csvPath, ',');
        }
        /// <summary>
        /// 读取csv文件中所有数据到datatable中，第一行为列标题，其余为数据，列数以标题为主，按指定分隔符分割
        /// </summary>
        /// <param name="csvPath">csv文件的完整路径</param>
        /// <returns>返回包含csv数据的datatable，如果错误则返回Null</returns>
        public static DataTable ReadCSV(string csvPath, char chr)
        {
            char[] chrlist = new char[1] { chr };
            return ReadCSV(csvPath, chrlist);
        }
        /// <summary>
        /// 读取csv文件中所有数据到datatable中，第一行为列标题，其余为数据，列数以标题为主，按指定分隔符分割
        /// </summary>
        /// <param name="csvPath">csv文件的完整路径</param>
        /// <returns>返回包含csv数据的datatable，如果错误则返回Null</returns>
        public static DataTable ReadCSV(string csvPath, char[] splitChars)
        {
            if (!File.Exists(csvPath.Trim())) return null;

            DataTable dt = new DataTable();
            bool isFirst = true;

            var lines = File.ReadAllLines(csvPath);

            foreach (var line in lines)
            {
                if (isFirst)
                {
                    isFirst = false;
                    string[] tableHeader = line.Split(splitChars);
                    foreach (var header in tableHeader)
                    {
                        dt.Columns.Add(header.ToString());
                    }
                }
                else
                {
                    string[] data = line.Split(splitChars);
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dr[i] = data[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        #endregion

        #region 读取一行数据

        /// <summary>
        /// 读取csv第一行数据，按逗号分割为string数组
        /// 默认路径：当前路径\\Default.csv
        /// </summary>
        /// <returns></returns>
        public static string[] ReadFirstLine()
        {
            return ReadFirstLine(csvFullPath);
        }
        /// <summary>
        /// 读取csv第一行数据，按逗号分割为string数组
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <returns></returns>
        public static string[] ReadFirstLine(string csvFilePath)
        {
            return ReadFirstLine(csvFilePath, ',');
        }
        /// <summary>
        /// 读取csv第一行数据，按指定分隔符分割为string数组
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <param name="chrSplit">分隔符</param>
        /// <returns></returns>
        public static string[] ReadFirstLine(string csvFilePath, char chrSplit)
        {
            char[] chrlist = new char[1] { chrSplit };
            return ReadFirstLine(csvFilePath, chrlist);
        }
        /// <summary>
        /// 读取csv第一行数据，按多个指定分隔符分割为string数组
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <param name="chrSplit">分隔符列表</param>
        /// <returns></returns>
        public static string[] ReadFirstLine(string csvFilePath, char[] chrSplit)
        {
            if (!File.Exists(csvFilePath.Trim())) return null;
            var line = File.ReadAllLines(csvFilePath).First();
            return line.Split(chrSplit);
        }
        /// <summary>
        /// 读取csv第一行数据
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <returns></returns>
        public static string ReadFirstLineString(string csvFilePath)
        {
            if (!File.Exists(csvFilePath.Trim())) return null;
            return File.ReadAllLines(csvFilePath).First();
        }
        #endregion

        #region 写入字符串数据
        /// <summary>
        /// 写入一行字符串
        /// 默认路径：当前路径\\Default.csv
        /// </summary>
        /// <param name="sLogInfo">写入信息</param>
        public static void WriteCSV(string sLogInfo)
        {
            WriteCSV(sLogInfo, csvFullPath);
        }
        /// <summary>
        /// 写入一行字符串
        /// </summary>
        /// <param name="sLogInfo">写入信息</param>
        /// <param name="fullPath">csv文件的完整路径</param>
        public static void WriteCSV(string sLogInfo, string fullPath)
        {
            string[] strlist = new string[1] { sLogInfo };
            WriteCSV(strlist, fullPath);
        }
        /// <summary>
        /// 写入多行字符串
        /// 默认路径：当前路径\\Default.csv
        /// </summary>
        /// <param name="sLogInfo">写入信息</param>
        public static void WriteCSV(string[] sLogInfo)
        {
            WriteCSV(sLogInfo,csvFullPath);
        }
        /// <summary>
        /// 写入多行字符串
        /// </summary>
        /// <param name="sLogInfo">写入信息</param>
        /// <param name="fullPath">csv文件的完整路径</param>
        public static void WriteCSV(string[] sLogInfo, string fullPath)
        {
            FileInfo file = new FileInfo(fullPath);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            foreach (var item in sLogInfo)
            {
                sw.WriteLine(item);
            }
            sw.Close();
            fs.Close();
        }
        #endregion
    }
}
