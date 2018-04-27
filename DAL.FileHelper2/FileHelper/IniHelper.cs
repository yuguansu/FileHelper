using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DAL.FileHelper
{
    public class IniHelper
    {
        private string iniFileName;

        public string FileName
        {
            get { return iniFileName; }
            set { iniFileName = value; }
        }

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(
            string lpAppName,
            string lpKeyName,
            int nDefault,
            string lpFileName
            );

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
            );

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName
            );

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="aFileName">Ini文件路径</param>
        public IniHelper(string aFileName)
        {
            this.iniFileName = aFileName;
        }
        public IniHelper()
        {

        }


        /// <summary>
        /// [扩展]读Int数值
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="def">默认值</param>
        /// <returns></returns>
        public int ReadInt(string section, string name, int def)
        {
            return GetPrivateProfileInt(section, name, def, this.iniFileName);
        }

        /// <summary>
        /// [扩展]读取string字符串
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="def">默认值</param>
        /// <returns></returns>
        public string ReadString(string section, string name, string def)
        {
            StringBuilder vRetSb = new StringBuilder(2048);
            GetPrivateProfileString(section, name, def, vRetSb, 2048, this.iniFileName);
            return vRetSb.ToString();
        }

        /// <summary>
        /// [扩展]写入Int数值，如果不存在 节-键，则会自动创建
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="Ival">写入值</param>
        public void WriteInt(string section, string name, int Ival)
        {
            WritePrivateProfileString(section, name, Ival.ToString(), this.iniFileName);
        }

        /// <summary>
        /// [扩展]写入String字符串，如果不存在 节-键，则会自动创建
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="strVal">写入值</param>
        public void WriteString(string section, string name, string value)
        {
            WritePrivateProfileString(section, name, value, this.iniFileName);
        }

        /// <summary>
        /// 删除指定的 节
        /// </summary>
        /// <param name="section"></param>
        public void DeleteSection(string section)
        {
            WritePrivateProfileString(section, null, null, this.iniFileName);
        }

        /// <summary>
        /// 删除全部 节
        /// </summary>
        public void DeleteAllSection()
        {
            WritePrivateProfileString(null, null, null, this.iniFileName);
        }

    }
}
