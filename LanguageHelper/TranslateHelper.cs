using System.Windows.Forms;

namespace LanguageHelper
{
    /// <summary>
    /// 语言翻译工具类
    /// </summary>
    public class TranslateHelper
    {
        #region 属性
        /// <summary>
        /// 翻译文件
        /// </summary>
        private static string TranslateFile { get; set; }
        /// <summary>
        /// 源语言
        /// </summary>
        private static LanguageType SourceLanguage { get; set; }
        /// <summary>
        /// 目标语言
        /// </summary>
        private static LanguageType DestinationLanguage { get; set; }
        /// <summary>
        /// 语言类型，缩写abbr
        /// </summary>
        public enum LanguageType
        {
            /// <summary>
            /// 简体中文
            /// </summary>
            zh_cn,
            /// <summary>
            /// 繁体中文
            /// </summary>
            zh_tw,
            en_us,
            en_gb,
            ja,
            ko,
            de,

        }
        #endregion

        public TranslateHelper()
        {
            //获取默认翻译文件,同路径下程序名称或窗口名称.json
            TranslateFile = "";
            //默认属性
            SourceLanguage = LanguageType.en_us;
            DestinationLanguage = LanguageType.zh_cn;
        }

        #region 获取翻译文件
        /// <summary>
        /// 获取指定翻译文件
        /// </summary>
        /// <param name="FilePath">多语言翻译文件全路径</param>
        private static void GetTranslateFile(string FilePath)
        {
            TranslateFile = FilePath;
        }
        #endregion

        #region 翻译字符串
        /// <summary>
        /// 使用默认翻译文件翻译给定字符串,英文->简体中文
        /// </summary>
        /// <param name="sourcestring">原始字符串</param>
        /// <returns></returns>
        public static string Translate_en_2_cn(string sourcestring)
        {
            return Translate(sourcestring, SourceLanguage, DestinationLanguage);
        }
        /// <summary>
        /// 使用默认翻译文件翻译给定字符串
        /// </summary>
        /// <param name="sourcestring">原始字符串</param>
        /// <param name="SourceLanguage">源语言</param>
        /// <param name="DestinationLanguage">目标语言</param>
        /// <returns></returns>
        public static string Translate(string sourcestring, LanguageType SourceLanguage, LanguageType DestinationLanguage)
        {
            string result = null;

            TranslateDetail(sourcestring, TranslateFile, SourceLanguage, DestinationLanguage, ref result);

            return result;
        }
        /// <summary>
        /// 使用指定翻译文件翻译给定字符串
        /// </summary>
        /// <param name="sourcestring">原始字符串</param>
        /// <param name="TranslateFile">翻译文件全路径</param>
        /// <param name="SourceLanguage">源语言</param>
        /// <param name="DestinationLanguage">目标语言</param>
        /// <returns></returns>
        public static string Translate(string sourcestring, string TranslateFile, LanguageType SourceLanguage, LanguageType DestinationLanguage)
        {
            string result = null;

            GetTranslateFile(TranslateFile);
            TranslateDetail(sourcestring, TranslateFile, SourceLanguage, DestinationLanguage, ref result);

            return result;
        }
        #endregion

        #region 翻译控件
        /// <summary>
        /// 翻译winform中的控件显示文字，英语->简体中文
        /// </summary>
        /// <param name="f"></param>
        public static void TranslateControlsInWinform(Form f)
        {
            f.Text = Translate_en_2_cn(f.Text);
            foreach (Control control in f.Controls)
            {
                TranslateControl_Recursion(control);
            }
        }
        /// <summary>
        /// 翻译控件显示文字,递归
        /// </summary>
        /// <param name="c"></param>
        public static void TranslateControl_Recursion(Control c)
        {
            c.Text = Translate_en_2_cn(c.Text);
            foreach (Control control in c.Controls)
            {
                TranslateControl_Recursion(control);
            }
        }
        public static void TranslateControlDetail(Control control)
        {
            TranslateControlDetail(c);
            if (control is TextBox txt)
            {
                txt.Text = Translate_en_2_cn(txt.Text);
            }
            else if (control is Label lbl)
            {
                lbl.Text = Translate_en_2_cn(lbl.Text);
            }
            else if (control is Button btn)
            {
                btn.Text = Translate_en_2_cn(btn.Text);
            }
            else if (control is RichTextBox rtx)
            {
                rtx.Text = Translate_en_2_cn(rtx.Text);
            }
            else if (control is GroupBox grp)
            {
                grp.Text = Translate_en_2_cn(grp.Text);
            }
            else if (control is TabControl tab)
            {
                for (int i = 0; i < tab.TabPages.Count; i++)
                {
                    tab.TabPages[i].Text = Translate_en_2_cn(tab.TabPages[i].Text);
                }
            }
            else if (control is MenuStrip menu)
            {
                foreach (ToolStripMenuItem subitem in menu.Items)
                {
                    TranslateMenuStrip_Recursion(subitem);
                }
            }
            else if (control is DataGridView dgv)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    dgv.Columns[i].HeaderText = Translate_en_2_cn(dgv.Columns[i].HeaderText);
                }
            }
            else if (control is TreeView tree)
            {
                foreach (TreeNode treeNode in tree.Nodes)
                {
                    TranslateTreeView_Recursion(treeNode);
                }
            }
        }
        /// <summary>
        /// 翻译menustrip控件,递归
        /// </summary>
        /// <param name="toolStripMenuItem"></param>
        private static void TranslateMenuStrip_Recursion(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripMenuItem.Text = Translate_en_2_cn(toolStripMenuItem.Text);
            foreach (ToolStripMenuItem subitem in toolStripMenuItem.DropDownItems)
            {
                subitem.Text = Translate_en_2_cn(subitem.Text);
                TranslateMenuStrip_Recursion(subitem);
            }
        }
        /// <summary>
        /// 翻译TreeView控件,递归
        /// </summary>
        /// <param name="treenode"></param>
        private static void TranslateTreeView_Recursion(TreeNode treenode)
        {
            treenode.Text = Translate_en_2_cn(treenode.Text);
            foreach (TreeNode node in treenode.Nodes)
            {
                node.Text = Translate_en_2_cn(node.Text);
                TranslateTreeView_Recursion(node);
            }
        }
        
        #endregion

        #region 翻译细节
        /// <summary>
        /// 使用文件翻译字符串
        /// </summary>
        /// <param name="SourceString">原始字符串</param>
        /// <param name="TranslateFile">翻译文件</param>
        /// <param name="SourceLanguage">源语言</param>
        /// <param name="DestinationLanguage">目标语言</param>
        /// <param name="DestinationString">翻译结果</param>
        private static void TranslateDetail(string SourceString, string TranslateFile, LanguageType SourceLanguage, LanguageType DestinationLanguage, ref string DestinationString)
        {
            //打开文件

            //读取翻译列表

            //检查是否有源语言SourceLanguage和源字段SourceString

            //检查是否有目标语言DestinationLanguage、目标字段DestinationString是否有内容

            //返回目标字段内容
            DestinationString = SourceString;
        }
        #endregion
    }
}
