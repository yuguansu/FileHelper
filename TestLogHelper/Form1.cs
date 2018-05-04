using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
