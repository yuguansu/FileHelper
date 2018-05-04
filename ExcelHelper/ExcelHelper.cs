using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHelper
{
    public class ExcelHelper
    {
        #region variables

        #endregion
        
        /// <summary>
        /// 记录日志
        /// </summary>
        public static LogHelper.LogHelper Logs = new LogHelper.LogHelper("ExcelHelper", "ExcelHelper");
        private static Excel.Application excel;

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        /// <summary>
        /// 读取excel中的内容，读取特定的sheet到二维数组中，返回 object[,]
        /// </summary>
        /// <param name="fileExcel">excel文件的完整路径</param>
        /// <param name="sheetIndex">int类型，第sheetIndex个sheet</param>
        /// <returns></returns>
        public static Array ReadExcel(string fileExcel,int sheetIndex)
        {
            excel = new Excel.Application();
            excel.Visible = false;//設false效能會比較好
            Excel._Workbook book = null;//定义工作簿
            Excel._Worksheet sheet = null;//定义worksheet
            //Excel.Range range = null;//定义range

            try
            {
                book = excel.Workbooks.Open(fileExcel, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value);
                
                sheet = (Excel._Worksheet)book.Worksheets.get_Item(sheetIndex);//获得第i个sheet，准备读取
                Logs.WriteLog("sheet name",sheet.Name);//记录sheet名称
                int iRowCount = sheet.UsedRange.Rows.Count;//获取不为空的行数
                int iColCount = sheet.UsedRange.Columns.Count;//获取不为空的列数

                Excel.Range range0 = sheet.Range[sheet.Cells[1, 1], sheet.Cells[iRowCount, iColCount]];//获得区域数据赋值给Array数组，方便读取

                //Array data = (Array)range0;

                object[,] data = range0.Value2;

                return data;
            }
            catch (Exception ex)
            {
                Logs.WriteLog("error",ex.Message);
                return null;
            }
            finally
            {
                book.Close();
                //excel.Quit();//好像无法结束进程
                IntPtr t = new IntPtr(excel.Hwnd);
                int k = 0;
                GetWindowThreadProcessId(t, out k);
                Process p = Process.GetProcessById(k);
                p.Kill();
            }
        }

        /// <summary>
        /// 将DataSet写入excel中，dataset.table的表名作为sheet名，dataset.table的列标题作为每一个sheet的首行
        /// </summary>
        /// <param name="fileExcel"></param>
        /// <param name="dsInfo"></param>
        public static void WriteExcel(string fileExcel, DataSet dsInfo)
        {
            DataTable dt = new DataTable();
            excel = new Excel.Application();
            excel.Visible = false;//不显示excel前台界面
            Excel._Workbook book = null;//定义工作表
            Excel._Worksheet sheet = null;//定义worksheet
            //Excel.Range range = null;//定义range

            //添加内容
            try
            {
                book = excel.Workbooks.Open(fileExcel, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value);
                
                
            }
            catch (Exception ex)
            {
                Logs.WriteLog("error", ex.Message);
                throw;
            }
            finally
            {
                book.Close();
                //excel.Quit();//好像无法结束进程
                IntPtr t = new IntPtr(excel.Hwnd);
                int k = 0;
                GetWindowThreadProcessId(t, out k);
                Process p = Process.GetProcessById(k);
                p.Kill();
            }
        }

    }
}
