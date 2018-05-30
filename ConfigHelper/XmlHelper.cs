using System;
using System.IO;
using System.Xml;

namespace ConfigHelper
{
    public class XmlHelperUtils
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public XmlHelperUtils()
        {

        }

        /// <summary>
        /// Xml文件全名，包含路径
        /// </summary>
        private static string XmlFileName = GetDefaultXmlFileName();

        /// <summary>
        /// 获取默认xml文件路径名，包含路径
        /// </summary>
        /// <returns>默认xml文件路径名"Default.xml"，包含路径</returns>
        private static string GetDefaultXmlFileName()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            XmlFileName = path + "\\Default.xml";
            return XmlFileName;
        }

        #region 创建XML
        /// <summary>
        /// 创建xml文件，默认当前路径，文件名=Default.xml
        /// </summary>
        public static void CreateXmlFile()
        {
            CreateXmlFile(XmlFileName);
        }
        /// <summary>
        /// 创建xml空文件，写入根节点configuration
        /// </summary>
        /// <param name="fileName">xml文件名，包含路径</param>
        public static void CreateXmlFile(string fileName)
        {
            FileInfo f = new FileInfo(fileName);
            if (!f.Exists)
            {
                XmlWriter xw = XmlWriter.Create(fileName);
                xw.Flush();
                xw.Close();
                WriteRootElement(fileName, "configuration");
            }
        }
        #endregion

        #region 写入根节点
        /// <summary>
        /// 写入根节点，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="rootElement">根节点名称</param>
        public static void WriteRootElement(string rootElement)
        {
            WriteRootElement(XmlFileName, rootElement);
        }
        /// <summary>
        /// 写入根节点
        /// </summary>
        /// <param name="fileName">xml文件名</param>
        /// <param name="rootElement">根节点名称</param>
        public static void WriteRootElement(string fileName,string rootElement)
        {
            XmlDocument xml = new XmlDocument();
            //创建类型声明节点    
            XmlNode node = xml.CreateXmlDeclaration("1.0", "utf-8", "");
            xml.AppendChild(node);
            //创建根节点    
            XmlNode root = xml.CreateElement(rootElement);
            xml.AppendChild(root);
            xml.Save(fileName);
        }
        #endregion

        #region 读取节点
        /// <summary>
        /// 读取一级节点列表
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static XmlNodeList ReadElementNames(string fileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            return xmlDoc.DocumentElement.ChildNodes;
        }

        /// <summary>
        /// 获取默认xml文件中的根节点名称，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <returns></returns>
        public static string ReadRootElementName()
        {
            return ReadRootElementName(XmlFileName);
        }
        /// <summary>
        /// 获取指定xml文件中的根节点名称
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ReadRootElementName(string fileName)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(fileName);
            return xml.DocumentElement.Name;
        }
        #endregion

        /// <summary>
        /// 新建根节点下的一级节点，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="elementName">节点名称</param>
        /// <param name="innerText">节点值</param>
        public static void CreateElement(string elementName, string innerText)
        {
            CreateElement(XmlFileName, elementName, innerText);
        }
        /// <summary>
        /// 新建根节点下的一级节点
        /// </summary>
        /// <param name="fileName">xml文件名，包含路径</param>
        /// <param name="elementName">节点名称</param>
        /// <param name="innerText">节点值</param>
        public static void CreateElement(string fileName,string elementName,string innerText)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(fileName);

            XmlNode newNode = xml.CreateNode(XmlNodeType.Element, elementName, "");
            newNode.InnerText = innerText;

            //添加为根元素的第一层子结点
            XmlElement root = xml.DocumentElement;
            root.AppendChild(newNode);
            xml.Save(fileName);
        }

        /// <summary>
        /// 修改一级节点的属性，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="elementName">一级节点名</param>
        /// <param name="attributeName">属性名</param>
        /// <param name="attributeValue">属性值</param>
        public static void CreateAttribute(string elementName, string attributeName, string attributeValue)
        {
            CreateAttribute(XmlFileName,elementName,attributeName,attributeValue);
        }
        /// <summary>
        /// 修改一级节点的属性
        /// </summary>
        /// <param name="fileName">xml文件名</param>
        /// <param name="elementName">一级节点名</param>
        /// <param name="attributeName">属性名</param>
        /// <param name="attributeValue">属性值</param>
        public static void CreateAttribute(string fileName,string elementName,string attributeName,string attributeValue)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            XmlNodeList nodelist = xmlDoc.ChildNodes;
            foreach (XmlNode node in nodelist)
            {
                XmlElement xe = (XmlElement)node;
                
            }
            xmlDoc.Save(fileName);
        }
        
    }
}
