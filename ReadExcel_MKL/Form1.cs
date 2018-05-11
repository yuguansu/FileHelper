using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelHelper;

namespace ReadExcel_MKL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sExcelPath;
        string sCSVPath;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "";
            //opFile.Filter = "*.csv|All files(*.*)";
            if (file.ShowDialog() == DialogResult.OK)
            {
                sExcelPath = txtExcelFile.Text = file.FileName;
                sCSVPath = txtCSVFile.Text = sExcelPath.Replace("xlsx", "csv");
            }
        }

        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sExcelPath)) return;
            if (!File.Exists(sExcelPath)) return;

            Array arr = ExcelHelper.ExcelHelperUtils.ReadExcel (sExcelPath,1);

            //string[][] data = new string[arr.GetLength(0)][];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        data[i][j] = arr.GetValue(i+1, j+1).ToString() ;
            //    }
            //}

            DataTable dt = new DataTable("data");
            if (arr!=null)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    DataColumn dc = new DataColumn("column_" + i);
                    dt.Columns.Add(dc);
                }

                ///测试数据中，只保留每一个工步的开始和结束步骤。
                /// 检查上一行和当前行的工步是否相同并且均不为空：
                ///     如果均为空，记录当前新行。
                ///     如果不都为空则：
                ///         如果相同则不处理
                ///         
                ///     1.删除旧行2.将新行赋值给旧行3.删除新行
                ///是否为测试数据行
                bool isData = false;
                ///是否为测试数据标题行
                bool isDataTitle = false;
                DataRow drOld = dt.NewRow();
                DataRow drNew = dt.NewRow();
                
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        drNew["column_" + j] = ((arr.GetValue(i + 1, j + 1) == null) ? "" : arr.GetValue(i + 1, j + 1).ToString());
                    }
                    //检查是否是数据标题行
                    if ((!isDataTitle && !isData && drNew["column_0"].ToString()=="序号"))
                    {
                        isDataTitle = true;
                    }
                    //检查是否是数据行
                    if (isDataTitle && !isData && (drNew["column_0"].ToString() != "序号"))
                    {
                        isDataTitle = false;
                        isData = true;
                    }
                    //标题行的处理
                    if (isDataTitle)
                    {
                        //记录需要处理的列，待增加功能

                        dt.Rows.Add(drNew);
                    }
                    //数据行的处理
                    else if (isData)
                    {
                        if (drOld["column_6"].ToString() != drNew["column_6"].ToString())
                        {
                            dt.Rows.Add(drNew);
                        }
                    }
                    //其他行的处理
                    else
                    {
                        dt.Rows.Add(drNew);
                    }

                    drOld = drNew;
                    drNew = dt.NewRow();
                }
            }
            
            if (dt != null)
            {
                dgvData.DataSource = dt;
            }
        }

        private void WriteMsg(string info,TextBox textbox)
        {
            textbox.Text += info + Environment.NewLine;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
