namespace TestLogHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWriteLogStart = new System.Windows.Forms.Button();
            this.btnWriteLogStop = new System.Windows.Forms.Button();
            this.btnCreateXml = new System.Windows.Forms.Button();
            this.txtXmlName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReadRootElementName = new System.Windows.Forms.Button();
            this.txtRootElementName = new System.Windows.Forms.TextBox();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.txtAttributeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReadElementValue = new System.Windows.Forms.Button();
            this.btnReadAttributeValue = new System.Windows.Forms.Button();
            this.txtElementValue = new System.Windows.Forms.TextBox();
            this.txtAttributeValue = new System.Windows.Forms.TextBox();
            this.btnWriteElement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWriteAttribute = new System.Windows.Forms.Button();
            this.btnWriteRootElement = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.txtNodeValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWriteNode = new System.Windows.Forms.Button();
            this.btnReadNode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWriteLogStart
            // 
            this.btnWriteLogStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteLogStart.Location = new System.Drawing.Point(24, 24);
            this.btnWriteLogStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteLogStart.Name = "btnWriteLogStart";
            this.btnWriteLogStart.Size = new System.Drawing.Size(121, 39);
            this.btnWriteLogStart.TabIndex = 0;
            this.btnWriteLogStart.Text = "WriteLogStart";
            this.btnWriteLogStart.UseVisualStyleBackColor = true;
            this.btnWriteLogStart.Click += new System.EventHandler(this.btnWriteLogStart_Click);
            // 
            // btnWriteLogStop
            // 
            this.btnWriteLogStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteLogStop.Location = new System.Drawing.Point(194, 24);
            this.btnWriteLogStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteLogStop.Name = "btnWriteLogStop";
            this.btnWriteLogStop.Size = new System.Drawing.Size(121, 39);
            this.btnWriteLogStop.TabIndex = 0;
            this.btnWriteLogStop.Text = "WriteLogStop";
            this.btnWriteLogStop.UseVisualStyleBackColor = true;
            this.btnWriteLogStop.Click += new System.EventHandler(this.btnWriteLogStop_Click);
            // 
            // btnCreateXml
            // 
            this.btnCreateXml.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateXml.Location = new System.Drawing.Point(497, 44);
            this.btnCreateXml.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateXml.Name = "btnCreateXml";
            this.btnCreateXml.Size = new System.Drawing.Size(121, 31);
            this.btnCreateXml.TabIndex = 0;
            this.btnCreateXml.Text = "创建xml文件";
            this.btnCreateXml.UseVisualStyleBackColor = true;
            this.btnCreateXml.Click += new System.EventHandler(this.btnCreateXml_Click);
            // 
            // txtXmlName
            // 
            this.txtXmlName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXmlName.Location = new System.Drawing.Point(17, 46);
            this.txtXmlName.Name = "txtXmlName";
            this.txtXmlName.Size = new System.Drawing.Size(428, 26);
            this.txtXmlName.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(450, 46);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(30, 26);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "...";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReadRootElementName
            // 
            this.btnReadRootElementName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadRootElementName.Location = new System.Drawing.Point(17, 96);
            this.btnReadRootElementName.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadRootElementName.Name = "btnReadRootElementName";
            this.btnReadRootElementName.Size = new System.Drawing.Size(147, 30);
            this.btnReadRootElementName.TabIndex = 0;
            this.btnReadRootElementName.Text = "读取xml根节点名称";
            this.btnReadRootElementName.UseVisualStyleBackColor = true;
            this.btnReadRootElementName.Click += new System.EventHandler(this.btnReadRootElementName_Click);
            // 
            // txtRootElementName
            // 
            this.txtRootElementName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRootElementName.Location = new System.Drawing.Point(169, 98);
            this.txtRootElementName.Name = "txtRootElementName";
            this.txtRootElementName.Size = new System.Drawing.Size(261, 26);
            this.txtRootElementName.TabIndex = 1;
            // 
            // txtElementName
            // 
            this.txtElementName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtElementName.Location = new System.Drawing.Point(124, 144);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(261, 26);
            this.txtElementName.TabIndex = 1;
            // 
            // txtAttributeName
            // 
            this.txtAttributeName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAttributeName.Location = new System.Drawing.Point(124, 319);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new System.Drawing.Size(261, 26);
            this.txtAttributeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "节点名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "属性名称";
            // 
            // btnReadElementValue
            // 
            this.btnReadElementValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadElementValue.Location = new System.Drawing.Point(565, 174);
            this.btnReadElementValue.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadElementValue.Name = "btnReadElementValue";
            this.btnReadElementValue.Size = new System.Drawing.Size(127, 30);
            this.btnReadElementValue.TabIndex = 0;
            this.btnReadElementValue.Text = "读取xml节点值";
            this.btnReadElementValue.UseVisualStyleBackColor = true;
            this.btnReadElementValue.Click += new System.EventHandler(this.btnReadElementValue_Click);
            // 
            // btnReadAttributeValue
            // 
            this.btnReadAttributeValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadAttributeValue.Location = new System.Drawing.Point(565, 346);
            this.btnReadAttributeValue.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadAttributeValue.Name = "btnReadAttributeValue";
            this.btnReadAttributeValue.Size = new System.Drawing.Size(127, 30);
            this.btnReadAttributeValue.TabIndex = 0;
            this.btnReadAttributeValue.Text = "读取xml属性值";
            this.btnReadAttributeValue.UseVisualStyleBackColor = true;
            this.btnReadAttributeValue.Click += new System.EventHandler(this.btnReadAttributeValue_Click);
            // 
            // txtElementValue
            // 
            this.txtElementValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtElementValue.Location = new System.Drawing.Point(124, 176);
            this.txtElementValue.Name = "txtElementValue";
            this.txtElementValue.Size = new System.Drawing.Size(261, 26);
            this.txtElementValue.TabIndex = 1;
            // 
            // txtAttributeValue
            // 
            this.txtAttributeValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAttributeValue.Location = new System.Drawing.Point(124, 351);
            this.txtAttributeValue.Name = "txtAttributeValue";
            this.txtAttributeValue.Size = new System.Drawing.Size(261, 26);
            this.txtAttributeValue.TabIndex = 1;
            // 
            // btnWriteElement
            // 
            this.btnWriteElement.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteElement.Location = new System.Drawing.Point(404, 157);
            this.btnWriteElement.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteElement.Name = "btnWriteElement";
            this.btnWriteElement.Size = new System.Drawing.Size(127, 30);
            this.btnWriteElement.TabIndex = 0;
            this.btnWriteElement.Text = "写入xml节点";
            this.btnWriteElement.UseVisualStyleBackColor = true;
            this.btnWriteElement.Click += new System.EventHandler(this.btnWriteElement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "节点值";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(683, 21);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 39);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "属性值";
            // 
            // btnWriteAttribute
            // 
            this.btnWriteAttribute.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteAttribute.Location = new System.Drawing.Point(404, 331);
            this.btnWriteAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteAttribute.Name = "btnWriteAttribute";
            this.btnWriteAttribute.Size = new System.Drawing.Size(127, 30);
            this.btnWriteAttribute.TabIndex = 0;
            this.btnWriteAttribute.Text = "写入xml属性";
            this.btnWriteAttribute.UseVisualStyleBackColor = true;
            this.btnWriteAttribute.Click += new System.EventHandler(this.btnWriteAttribute_Click);
            // 
            // btnWriteRootElement
            // 
            this.btnWriteRootElement.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteRootElement.Location = new System.Drawing.Point(435, 98);
            this.btnWriteRootElement.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteRootElement.Name = "btnWriteRootElement";
            this.btnWriteRootElement.Size = new System.Drawing.Size(147, 30);
            this.btnWriteRootElement.TabIndex = 0;
            this.btnWriteRootElement.Text = "写入xml根节点名称";
            this.btnWriteRootElement.UseVisualStyleBackColor = true;
            this.btnWriteRootElement.Click += new System.EventHandler(this.btnWriteRootElement_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 429);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtXmlName);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCreateXml);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnReadRootElementName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnWriteRootElement);
            this.tabPage1.Controls.Add(this.txtAttributeName);
            this.tabPage1.Controls.Add(this.btnReadNode);
            this.tabPage1.Controls.Add(this.btnReadElementValue);
            this.tabPage1.Controls.Add(this.txtAttributeValue);
            this.tabPage1.Controls.Add(this.btnWriteNode);
            this.tabPage1.Controls.Add(this.btnWriteElement);
            this.tabPage1.Controls.Add(this.txtNodeValue);
            this.tabPage1.Controls.Add(this.txtElementValue);
            this.tabPage1.Controls.Add(this.txtNodeName);
            this.tabPage1.Controls.Add(this.btnReadAttributeValue);
            this.tabPage1.Controls.Add(this.txtElementName);
            this.tabPage1.Controls.Add(this.btnWriteAttribute);
            this.tabPage1.Controls.Add(this.txtRootElementName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "XmlHelper";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnWriteLogStart);
            this.tabPage3.Controls.Add(this.btnWriteLogStop);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(834, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LogHelper";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNodeName
            // 
            this.txtNodeName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNodeName.Location = new System.Drawing.Point(226, 225);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(261, 26);
            this.txtNodeName.TabIndex = 1;
            // 
            // txtNodeValue
            // 
            this.txtNodeValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNodeValue.Location = new System.Drawing.Point(226, 257);
            this.txtNodeValue.Name = "txtNodeValue";
            this.txtNodeValue.Size = new System.Drawing.Size(261, 26);
            this.txtNodeValue.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(120, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "子节点名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(120, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "子节点值";
            // 
            // btnWriteNode
            // 
            this.btnWriteNode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteNode.Location = new System.Drawing.Point(497, 237);
            this.btnWriteNode.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteNode.Name = "btnWriteNode";
            this.btnWriteNode.Size = new System.Drawing.Size(127, 30);
            this.btnWriteNode.TabIndex = 0;
            this.btnWriteNode.Text = "写入xml子节点";
            this.btnWriteNode.UseVisualStyleBackColor = true;
            this.btnWriteNode.Click += new System.EventHandler(this.btnWriteNode_Click);
            // 
            // btnReadNode
            // 
            this.btnReadNode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadNode.Location = new System.Drawing.Point(658, 254);
            this.btnReadNode.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadNode.Name = "btnReadNode";
            this.btnReadNode.Size = new System.Drawing.Size(127, 30);
            this.btnReadNode.TabIndex = 0;
            this.btnReadNode.Text = "读取xml子节点值";
            this.btnReadNode.UseVisualStyleBackColor = true;
            this.btnReadNode.Click += new System.EventHandler(this.btnReadNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 463);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWriteLogStart;
        private System.Windows.Forms.Button btnWriteLogStop;
        private System.Windows.Forms.Button btnCreateXml;
        private System.Windows.Forms.TextBox txtXmlName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReadRootElementName;
        private System.Windows.Forms.TextBox txtRootElementName;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.TextBox txtAttributeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReadElementValue;
        private System.Windows.Forms.Button btnReadAttributeValue;
        private System.Windows.Forms.TextBox txtElementValue;
        private System.Windows.Forms.TextBox txtAttributeValue;
        private System.Windows.Forms.Button btnWriteElement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWriteAttribute;
        private System.Windows.Forms.Button btnWriteRootElement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNodeValue;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Button btnReadNode;
        private System.Windows.Forms.Button btnWriteNode;
    }
}

