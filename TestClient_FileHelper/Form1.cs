using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConfigHelper;

namespace TestFileHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ConfigHelper.IniHelper IniCfg = new ConfigHelper.IniHelper()/*(Environment.CurrentDirectory + "Config.ini")*/;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = op.FileName;
            }
            
        }

        private void btnReadIni_Click(object sender, EventArgs e)
        {
            txtValue.Text = IniHelperUtils.ReadInt("System", "default", 0).ToString();
            txtValue.Text += IniHelperUtils.ReadString("Default", "default", "NA");
        }

        private void btnWriteIni_Click(object sender, EventArgs e)
        {
            IniHelperUtils.WriteInt("System","Default", 2);
            IniHelperUtils.WriteString("Default", "default", "first");
        }
    }
}
