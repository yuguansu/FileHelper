using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLogHelper
{
    public partial class Form1 : Form
    {
        LogHelper.LogHelperUtils logs = new LogHelper.LogHelperUtils("TestLogHelper", "Form1");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteLogStart_Click(object sender, EventArgs e)
        {
            logs.WriteLogStart();
        }

        private void btnWriteLogStop_Click(object sender, EventArgs e)
        {
            logs.WriteLogEnd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtXmlName.Text = op.FileName;
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Name.Contains("txt"))
                {
                    this.Controls[i].Text = "";
                }
            }
        }

        private void btnCreateXml_Click(object sender, EventArgs e)
        {
            //创建xml文件
            string filename = txtXmlName.Text.Trim();
            string path;
            
            if (!string.IsNullOrEmpty(filename) && filename.Length > 4 && filename.Substring(filename.Length - 3).ToLower() == "xml")
            {
                path = filename;
            }
            else
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "\\DefaultSetting.xml";
            }
            if (!File.Exists(path))
            {
                ConfigHelper.XmlHelperUtils.CreateXmlFile(path);
            }
            txtXmlName.Text = path;
            
        }

        private void btnWriteRootElement_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRootElementName.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtXmlName.Text.Trim()))
            {
                ConfigHelper.XmlHelperUtils.WriteRootElement(txtRootElementName.Text.Trim());
            }
            else
            {
                ConfigHelper.XmlHelperUtils.WriteRootElement(txtXmlName.Text.Trim(),txtRootElementName.Text.Trim());
            }
            
        }

        private void btnReadRootElementName_Click(object sender, EventArgs e)
        {
            txtRootElementName.Text = ConfigHelper.XmlHelperUtils.ReadRootElementName();
        }

        private void btnWriteElement_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtElementName.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtElementValue.Text.Trim())) return;

            ConfigHelper.XmlHelperUtils.CreateElement(txtElementName.Text, txtElementValue.Text);
        }

        private void btnReadElementValue_Click(object sender, EventArgs e)
        {

        }

        private void btnWriteAttribute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtElementName.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtAttributeName.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtAttributeValue.Text.Trim())) return;
            ConfigHelper.XmlHelperUtils.CreateAttribute(txtElementName.Text, txtAttributeName.Text, txtAttributeValue.Text);
        }

        private void btnReadAttributeValue_Click(object sender, EventArgs e)
        {

        }
    }
}
