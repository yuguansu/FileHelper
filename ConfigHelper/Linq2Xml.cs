using System;
using System.Linq;
using System.Xml.Linq;

namespace ConfigHelper
{
    public class Linq2XmlUtils
    {
        #region 构造函数
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Linq2XmlUtils()
        {
            
        }
        #endregion

        #region xmlFileName = 当前路径\Default.xml
        /// <summary>
        /// Xml文件全名，包含路径
        /// </summary>
        private static string xmlFileName = GetDefaultXmlFileName();
        /// <summary>
        /// 获取默认xml文件路径名，包含路径
        /// 默认:当前路径\Default.xml
        /// </summary>
        /// <returns>默认xml文件路径名"DefaultSetting.xml"，包含路径</returns>
        private static string GetDefaultXmlFileName()
        {
            return xmlFileName = AppDomain.CurrentDomain.BaseDirectory + "\\Default.xml";
        }
        #endregion

        #region 创建空xml文件
        /// <summary>
        /// 创建默认xml空文件
        /// 默认:当前路径\Default.xml
        /// </summary>
        public static void CreateXmlFile()
        {
            CreateXmlFile(xmlFileName);
        }
        /// <summary>
        /// 创建xml空文件
        /// </summary>
        /// <param name="sFileName">xml文件名，包含路径</param>
        public static void CreateXmlFile(string sFileName)
        {
            XDocument xmldoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XElement("configuration"));
            xmldoc.Save(sFileName);
        }
        #endregion

        #region 读取根节点名称
        /// <summary>
        /// 获取默认xml文件中的根节点名称，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <returns></returns>
        //public static string ReadRootElementName()
        //{
        //    return ReadRootElementName(xmlFileName);
        //}
        /// <summary>
        /// 获取指定xml文件中的根节点名称
        /// </summary>
        /// <param name="sFileName"></param>
        /// <returns></returns>
        //public static string ReadRootElementName(string sFileName)
        //{
        //    XDocument xml = new XDocument();
            
        //}
        #endregion

    }
}
