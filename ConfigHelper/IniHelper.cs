using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConfigHelper
{
    public class IniHelper
    {
        /// <summary>
        /// 默认文件为AppDomain.CurrentDomain.BaseDirectory + \DefaultSetting
        /// </summary>
        private static string iniFileName = GetDefaultFile();
        
        public static string GetDefaultFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            return path + "\\Default.ini";
        }

        #region 获取int值
        /// <summary>
        /// 获取int值
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="nDefault"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(
            string lpAppName,
            string lpKeyName,
            int nDefault,
            string lpFileName
            );
        #endregion
        #region 获取String值
        /// <summary>
        /// 获取String值
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpDefault"></param>
        /// <param name="lpReturnedString"></param>
        /// <param name="nSize"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
            );
        #endregion
        #region 写入String值
        /// <summary>
        /// 写入String值
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpString"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName
            );
        #endregion
        
        /// <summary>
        /// 默认构造函数，空
        /// </summary>
        public IniHelper()
        {

        }
        
        /// <summary>
        /// [扩展]读Int数值
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static int ReadInt(string section, string key, int defaultValue)
        {
            return ReadInt(iniFileName, section, key, defaultValue);
        }
        /// <summary>
        /// [扩展]读Int数值
        /// </summary>
        /// <param name="sFileName">ini文件全路径</param>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static int ReadInt(string sFileName, string section, string key, int defaultValue)
        {
            return GetPrivateProfileInt(section, key, defaultValue, sFileName);
        }

        /// <summary>
        /// [扩展]读取string字符串
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string ReadString(string section, string key, string defaultValue)
        {
            return ReadString(iniFileName, section, key, defaultValue);
        }
        /// <summary>
        /// [扩展]读取string字符串
        /// </summary>
        /// <param name="sFileName">ini文件全路径</param>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string ReadString(string sFileName,string section, string key, string defaultValue)
        {
            StringBuilder vRetSb = new StringBuilder(2048);
            GetPrivateProfileString(section, key, defaultValue, vRetSb, 2048, sFileName);
            return vRetSb.ToString();
        }

        /// <summary>
        /// [扩展]写入Int数值，如果不存在 节-键，则会自动创建
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="iValue">写入值</param>
        public static void WriteInt(string section, string name, int iValue)
        {
            WriteInt(iniFileName, section, name, iValue);
        }
        /// <summary>
        /// [扩展]写入Int数值，如果不存在 节-键，则会自动创建
        /// </summary>
        /// <param name="sFileName">ini文件全路径</param>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="iValue">写入值</param>
        public static void WriteInt(string sFileName, string section, string name, int iValue)
        {
            WritePrivateProfileString(section, name, iValue.ToString(), sFileName);
        }

        /// <summary>
        /// [扩展]写入String字符串，如果不存在 节-键，则会自动创建
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="strVal">写入值</param>
        public static void WriteString(string section, string name, string value)
        {
            WriteString(iniFileName, section, name, value);
        }
        /// <summary>
        /// [扩展]写入String字符串，如果不存在 节-键，则会自动创建
        /// </summary>
        /// <param name="sFileName">ini文件全路径</param>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="strVal">写入值</param>
        public static void WriteString(string iFileName,string section, string name, string value)
        {
            WritePrivateProfileString(section, name, value, iFileName);
        }

        /// <summary>
        /// 删除指定的 节
        /// </summary>
        /// <param name="section"></param>
        public static void DeleteSection(string section)
        {
            DeleteSection(iniFileName,section );
        }
        /// <summary>
        /// 删除指定的 节
        /// </summary>
        /// <param name="section"></param>
        public static void DeleteSection(string sFileName, string section)
        {
            WritePrivateProfileString(section, null, null, sFileName);
        }
        
        /// <summary>
        /// 删除全部 节
        /// </summary>
        public static void DeleteAllSection()
        {
            DeleteAllSection(iniFileName);
        }
        /// <summary>
        /// 删除全部 节
        /// </summary>
        public static void DeleteAllSection(string sFileName)
        {
            WritePrivateProfileString(null, null, null, sFileName);
        }

    }
}
