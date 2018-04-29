using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL.FileHelper
{
    public class CSVHelper
    {
        /// <summary>
        /// 将datatable数据全部写入csv中，按逗号分割，列标题作为第一行
        /// </summary>
        /// <param name="dt">datatable数据源</param>
        /// <param name="fullPath">需要写入的csv文件的完整路径</param>
        public static void WriteCSV(DataTable dt,string fullPath)
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
                data += dt.Columns[i].ColumnName.ToString() +",";
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
                    if (str.Contains(',')||str.Contains('"')||str.Contains('\r')||str.Contains('\n'))
                    {
                        str = string.Format("\"{0}\"",str);
                    }
                    data += str + ",";
                }
                sw.WriteLine(data);
            }
            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// 写入一行字符串
        /// </summary>
        /// <param name="sLogInfo">写入信息</param>
        /// <param name="fullPath">csv文件的完整路径</param>
        public static void WriteCSV(string sLogInfo, string fullPath)
        {
            FileInfo file = new FileInfo(fullPath);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            
            sw.WriteLine(sLogInfo);
            
            sw.Close();
            fs.Close();
        }
        
        /// <summary>
        /// 读取csv文件中所有数据到datatable中，第一行为列标题，其余为数据，列数以标题为主，按逗号分割
        /// </summary>
        /// <param name="csvPath">csv文件的完整路径</param>
        /// <returns>返回包含csv数据的datatable，如果错误则返回Null</returns>
        public static DataTable ReadCSV(string csvPath)
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
                    string[] tableHeader = line.Split(',');
                    foreach (var header in tableHeader)
                    {
                        dt.Columns.Add(header.ToString());
                    }
                }
                else
                {
                    string[] data = line.Split(',');
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
        /// <summary>
        /// 读取csv文件中所有数据到datatable中，第一行为列标题，其余为数据，列数以标题为主，按指定分隔符分割
        /// </summary>
        /// <param name="csvPath">csv文件的完整路径</param>
        /// <returns>返回包含csv数据的datatable，如果错误则返回Null</returns>
        public static DataTable ReadCSV(string csvPath,char[] splitChars)
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
        /// <summary>
        /// 读取csv第一行数据，按逗号分割为string数组
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <returns></returns>
        public static string[] ReadFirstLine(string csvFilePath)
        {
            if (!File.Exists(csvFilePath.Trim())) return null;
            var line = File.ReadAllLines(csvFilePath).First();
            return line.Split(',');
        }
        /// <summary>
        /// 读取csv第一行数据，按指定分隔符分割为string数组
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <param name="chrSplit">分隔符</param>
        /// <returns></returns>
        public static string[] ReadFirstLine(string csvFilePath,char chrSplit)
        {
            if (!File.Exists(csvFilePath.Trim())) return null;
            var line = File.ReadAllLines(csvFilePath).First();
            return line.Split(chrSplit);
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
        /// 读取csv第一行数据，按逗号分割为string数组
        /// </summary>
        /// <param name="csvFilePath">csv文件的完整路径</param>
        /// <returns></returns>
        public static string ReadFirstLineString(string csvFilePath)
        {
            if (!File.Exists(csvFilePath.Trim())) return null;
            return File.ReadAllLines(csvFilePath).First();
        }
    }
}
