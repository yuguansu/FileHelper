using System;
using System.IO;
using System.Xml;

namespace ConfigHelper
{
    public class XmlHelperUtils
    {
        #region 构造函数
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public XmlHelperUtils()
        {

        }
        #endregion

        #region  xmlFileName
        /// <summary>
        /// Xml文件全名，包含路径
        /// </summary>
        public static string xmlFileName = GetDefaultXmlFileName();        
        /// <summary>
        /// 获取默认xml文件路径名，包含路径
        /// </summary>
        /// <returns>默认xml文件路径名"Default.xml"，包含路径</returns>
        private static string GetDefaultXmlFileName()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            xmlFileName = path + "\\Default.xml";
            return xmlFileName;
        }
        #endregion

        #region 创建XML
        /// <summary>
        /// 创建xml文件，默认当前路径，文件名=Default.xml
        /// </summary>
        public static void CreateXmlFile()
        {
            CreateXmlFile(xmlFileName);
        }
        /// <summary>
        /// 创建xml空文件，写入根节点configuration
        /// </summary>
        /// <param name="sFileName">xml文件名，包含路径</param>
        public static void CreateXmlFile(string sFileName)
        {
            FileInfo f = new FileInfo(sFileName);
            if (!f.Exists)
            {
                XmlWriter xw = XmlWriter.Create(sFileName);
                xw.Flush();
                xw.Close();
                WriteRootElement(sFileName, "root");
            }
        }
        #endregion

        #region 读取根节点名称
        /// <summary>
        /// 获取默认xml文件中的根节点名称，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <returns></returns>
        public static string ReadRootElementName()
        {
            return ReadRootElementName(xmlFileName);
        }
        /// <summary>
        /// 获取指定xml文件中的根节点名称
        /// </summary>
        /// <param name="sFileName"></param>
        /// <returns></returns>
        public static string ReadRootElementName(string sFileName)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(sFileName);
            return xml.DocumentElement.Name;
        }
        #endregion

        #region 写入根节点
        /// <summary>
        /// 写入根节点
        /// 默认xml文件：当前路径\Default.xml
        /// 默认根节点名：root
        /// </summary>
        /// <param name="rootElement">根节点名称</param>
        public static void WriteRootElement()
        {
            WriteRootElement(xmlFileName, "root");
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
        
        #region 读取根节点下的一级节点列表
        /// <summary>
        /// 读取一级节点列表
        /// 默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static XmlNodeList ReadElementNames()
        {
            return ReadElementNames(xmlFileName);
        }
        /// <summary>
        /// 读取一级节点列表
        /// </summary>
        /// <param name="sFileName"></param>
        /// <returns></returns>
        public static XmlNodeList ReadElementNames(string sFileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(sFileName);
            return xmlDoc.DocumentElement.ChildNodes;
        }
        #endregion

        #region 读取任意节点值
        /// <summary>
        /// 读取任意节点的值
        /// </summary>
        /// <param name="sElement">节点名称，包含根节点</param>
        /// <returns></returns>
        public static string ReadElement( string sElement)
        {
            return ReadElement(xmlFileName, sElement);
        }
        /// <summary>
        /// 读取任意节点的值
        /// </summary>
        /// <param name="sFileName">xml文件名，包含路径</param>
        /// <param name="sElement">节点名称，包含根节点</param>
        /// <returns></returns>
        public static string ReadElement(string sFileName, string sElement)
        {
            var xml = new XmlDocument();
            xml.Load(sFileName);
            return xml.SelectSingleNode(sElement).InnerText;
        }

        #endregion

        #region 新建一级节点
        /// <summary>
        /// 新建根节点下的一级节点
        /// 默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="elementName">节点名称</param>
        /// <param name="innerText">节点值</param>
        public static void CreateElementToRoot(string elementName, string innerText)
        {
            CreateElementToRoot(xmlFileName, elementName, innerText);
        }
        /// <summary>
        /// 新建根节点下的一级节点
        /// </summary>
        /// <param name="sFileName">xml文件名，包含路径</param>
        /// <param name="elementName">节点名称</param>
        /// <param name="innerText">节点值</param>
        public static void CreateElementToRoot(string sFileName, string elementName,string innerText)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(sFileName);

            XmlNode newNode = xml.CreateNode(XmlNodeType.Element, elementName, "");
            newNode.InnerText = innerText;

            //添加为根元素的第一层子结点
            XmlElement root = xml.DocumentElement;
            root.AppendChild(newNode);
            xml.Save(sFileName);
        }
        #endregion

        #region 写入子节点
        /// <summary>
        /// 向指定父节点写入子节点
        /// 默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="elementName"></param>
        /// <param name="innerText"></param>
        public static void CreateNode(string parentNode, string elementName, string innerText)
        {
            CreateNode(xmlFileName, parentNode, elementName, innerText);
        }
        /// <summary>
        /// 向指定父节点写入子节点
        /// </summary>
        /// <param name="sFileName">xml文件名，包含路径</param>
        /// <param name="parentNode"></param>
        /// <param name="elementName"></param>
        /// <param name="innerText"></param>
        public static void CreateNode(string sFileName,string parentNode,string elementName,string innerText)
        {
            //open file
            XmlDocument xml = new XmlDocument();
            xml.Load(sFileName);

            //select parent node
            XmlNode oldNode = xml.DocumentElement.SelectSingleNode(parentNode);

            //new node
            XmlElement newElement = xml.CreateElement(elementName);
            newElement.InnerText = innerText;

            //add node
            oldNode.AppendChild(newElement);

            //save file
            xml.Save(sFileName);
        }

        #endregion

        #region 修改节点属性
        /// <summary>
        /// 修改一级节点的属性，默认xml文件=当前路径\Default.xml
        /// </summary>
        /// <param name="elementName">一级节点名</param>
        /// <param name="attributeName">属性名</param>
        /// <param name="attributeValue">属性值</param>
        public static void CreateAttribute(string elementName, string attributeName, string attributeValue)
        {
            CreateAttribute(xmlFileName,elementName,attributeName,attributeValue);
        }
        /// <summary>
        /// 修改一级节点的属性
        /// </summary>
        /// <param name="fileName">xml文件名</param>
        /// <param name="elementName">一级节点名</param>
        /// <param name="attributeName">属性名</param>
        /// <param name="attributeValue">属性值</param>
        public static void CreateAttribute(string sFileName, string elementName,string attributeName,string attributeValue)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(sFileName);

            XmlElement xe = (XmlElement)xml.SelectSingleNode(elementName);
            xe.SetAttribute(attributeName, attributeValue);

            xml.Save(sFileName);
        }
        #endregion
    }
}
