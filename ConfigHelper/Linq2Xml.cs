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
        /// 默认:当前路径\Default.xml
        /// </summary>
        public static string xmlFileName = GetDefaultXmlFileName();
        /// <summary>
        /// 获取默认xml文件路径名，包含路径
        /// 默认:当前路径\Default.xml
        /// </summary>
        /// <returns>默认xml文件路径名"DefaultSetting.xml"，包含路径</returns>
        public static string GetDefaultXmlFileName()
        {
            return xmlFileName = AppDomain.CurrentDomain.BaseDirectory + "\\Default.xml";
        }
        #endregion

        public static string root = "configuration";
        public enum AddElementType
        {
            
        }

        #region 创建空xml文件，带默认根节点 configuration
        /// <summary>
        /// 创建默认xml空文件
        /// 默认:当前路径\Default.xml
        /// </summary>
        public static void CreateXmlFile()
        {
            CreateXmlFile(xmlFileName);
        }
        /// <summary>
        /// 创建xml空文件，默认根节点:configuration
        /// </summary>
        /// <param name="sFileName">xml文件名，包含路径</param>
        public static void CreateXmlFile(string sFileName)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes")
                , new XElement(root)
                , new XComment("settings of program")
                );
            xml.Save(sFileName);
        }
        #endregion

        #region 写入节点
        /// <summary>
        /// 写入节点，
        /// </summary>
        /// <param name="sFileName">xml文件，含路径</param>
        /// <param name="sElementName">要添加的新节点</param>
        /// <param name="sElementValue">要添加的新节点值</param>
        public static void CreateElement(string sFileName , string sElementName ,string sElementValue)
        {

        }

        /// <summary>
        /// 在指定节点前后添加新节点
        /// </summary>
        /// <param name="sFileName"></param>
        /// <param name="sOldElementName">指定已有节点</param>
        /// <param name="sNewElementName">要添加的新节点</param>
        /// <param name="sNewElementValue">要添加的新节点值</param>
        public static void CreateElement(string sFileName,string sOldElementName ,string sNewElementName,string sNewElementValue)
        {

        }
        #endregion

        #region 写入属性

        #endregion

        #region 读取编码格式

        #endregion

        #region 读取节点
        /// <summary>
        /// 读取节点值，仅匹配第一个sElementName中的值
        /// </summary>
        /// <param name="sFileName"></param>
        /// <param name="sElementName"></param>
        /// <returns></returns>
        public static string ReadElement(string sFileName,string sElementName)
        {
            XElement xele = XElement.Load(sFileName);
            XElement xele1 = xele.Element(sElementName);
            return xele1.Value.ToString();
        }
        #endregion

        #region 读取属性

        #endregion

        #region 监听XML文件更改

        #endregion

    }
}
