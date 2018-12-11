namespace TestFileHelper
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnReadIni = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnWriteIni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(34, 26);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(130, 28);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(476, 21);
            this.txtFile.TabIndex = 1;
            // 
            // btnReadIni
            // 
            this.btnReadIni.Location = new System.Drawing.Point(34, 78);
            this.btnReadIni.Name = "btnReadIni";
            this.btnReadIni.Size = new System.Drawing.Size(75, 23);
            this.btnReadIni.TabIndex = 0;
            this.btnReadIni.Text = "ReadIni";
            this.btnReadIni.UseVisualStyleBackColor = true;
            this.btnReadIni.Click += new System.EventHandler(this.btnReadIni_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(130, 80);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(465, 107);
            this.txtValue.TabIndex = 1;
            // 
            // btnWriteIni
            // 
            this.btnWriteIni.Location = new System.Drawing.Point(34, 212);
            this.btnWriteIni.Name = "btnWriteIni";
            this.btnWriteIni.Size = new System.Drawing.Size(75, 23);
            this.btnWriteIni.TabIndex = 0;
            this.btnWriteIni.Text = "WriteIni";
            this.btnWriteIni.UseVisualStyleBackColor = true;
            this.btnWriteIni.Click += new System.EventHandler(this.btnWriteIni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 431);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnWriteIni);
            this.Controls.Add(this.btnReadIni);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnReadIni;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnWriteIni;
    }
}

