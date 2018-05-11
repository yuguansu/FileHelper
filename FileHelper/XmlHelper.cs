using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ConfigHelper
{
    public class XmlHelper
    {
        /// <summary>
        /// Xml文件全名，包含路径
        /// </summary>
        private static string XmlFileName { get; set; }
        
        /// <summary>
        /// 默认构造函数，默认Xml文件在当前路径下，名为DefaultSetting.xml
        /// </summary>
        public XmlHelper()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            XmlFileName = path + "DefaultSetting.xml";
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filename">Xml文件全名，包含路径</param>
        public XmlHelper(string filename)
        {
            XmlFileName = filename;
        }
        /// <summary>
        /// 获取默认xml文件路径名，包含路径
        /// </summary>
        /// <returns>默认xml文件路径名"DefaultSetting.xml"，包含路径</returns>
        private static string GetDefaultXmlFileName()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            XmlFileName = path + "DefaultSetting.xml";
            return XmlFileName;
        }
        /// <summary>
        /// 创建xml空文件，默认当前路径，文件名=DefaultSetting.xml
        /// </summary>
        public static void CreateXmlFile()
        {
            CreateXmlFile(GetDefaultXmlFileName());
        }
        
        /// <summary>
        /// 创建xml空文件
        /// </summary>
        /// <param name="fileName">xml文件名，包含路径</param>
        public static void CreateXmlFile(string fileName)
        {
            XmlWriter xw = XmlWriter.Create(fileName);
            xw.Flush();
            xw.Close();
        }

        /// <summary>
        /// 写入根节点，默认xml文件=当前路径\DefaultSetting.xml
        /// </summary>
        /// <param name="rootElement">根节点名称</param>
        public static void WriteRootElement(string rootElement)
        {
            WriteRootElement(GetDefaultXmlFileName(), rootElement);
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

        /// <summary>
        /// 获取默认xml文件中的根节点名称，默认xml文件=当前路径\DefaultSetting.xml
        /// </summary>
        /// <returns></returns>
        public static string ReadRootElementName()
        {
            return ReadRootElementName(GetDefaultXmlFileName());
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

        /// <summary>
        /// 新建根节点下的一级节点，默认xml文件=当前路径\DefaultSetting.xml
        /// </summary>
        /// <param name="elementName">节点名称</param>
        /// <param name="innerText">节点值</param>
        public static void CreateElement(string elementName, string innerText)
        {
            CreateElement(GetDefaultXmlFileName(), elementName, innerText);
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
        /// 新建一级节点的属性，默认xml文件=当前路径\DefaultSetting.xml
        /// </summary>
        /// <param name="elementName">一级节点名</param>
        /// <param name="attributeName">属性名</param>
        /// <param name="attributeValue">属性值</param>
        public static void CreateAttribute(string elementName, string attributeName, string attributeValue)
        {
            CreateAttribute(GetDefaultXmlFileName(),elementName,attributeName,attributeValue);
        }
        /// <summary>
        /// 新建一级节点的属性
        /// </summary>
        /// <param name="fileName">xml文件名</param>
        /// <param name="elementName">一级节点名</param>
        /// <param name="attributeName">属性名</param>
        /// <param name="attributeValue">属性值</param>
        public static void CreateAttribute(string fileName,string elementName,string attributeName,string attributeValue)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            xmlDoc.CreateAttribute(attributeName);
            
            xmlDoc.Save(fileName);
        }


    }
}
