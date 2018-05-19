using System;
using System.Linq;
using System.Xml.Linq;

namespace ConfigHelper
{
    public class Linq2XmlUtils
    {
        /// <summary>
        /// Xml文件全名，包含路径
        /// </summary>
        private static string XmlFileName { get; set; }

        /// <summary>
        /// 默认构造函数，默认Xml文件在当前路径下，名为DefaultSetting.xml
        /// </summary>
        public Linq2XmlUtils()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            XmlFileName = path + "DefaultSetting.xml";
        }
        /// <summary>
        /// 构造函数，设置文件名，包含路径
        /// </summary>
        /// <param name="filename">Xml文件全名，包含路径</param>
        public Linq2XmlUtils(string filename)
        {
            XmlFileName = filename;
        }


        /// <summary>
        /// 获取默认xml文件路径名，包含路径，默认xml文件名"DefaultSetting.xml"
        /// </summary>
        /// <returns>默认xml文件路径名"DefaultSetting.xml"，包含路径</returns>
        private static string GetDefaultXmlFileName()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            XmlFileName = path + "DefaultSetting.xml";
            return XmlFileName;
        }
        /// <summary>
        /// 创建默认xml空文件，默认当前路径，文件名=DefaultSetting.xml
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
            XDocument xmldoc = new XDocument();
            xmldoc.Save(fileName);
        }


    }
}
