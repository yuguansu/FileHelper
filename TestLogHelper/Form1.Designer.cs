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
            this.SuspendLayout();
            // 
            // btnWriteLogStart
            // 
            this.btnWriteLogStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteLogStart.Location = new System.Drawing.Point(47, 38);
            this.btnWriteLogStart.Name = "btnWriteLogStart";
            this.btnWriteLogStart.Size = new System.Drawing.Size(139, 41);
            this.btnWriteLogStart.TabIndex = 0;
            this.btnWriteLogStart.Text = "WriteLogStart";
            this.btnWriteLogStart.UseVisualStyleBackColor = true;
            this.btnWriteLogStart.Click += new System.EventHandler(this.btnWriteLogStart_Click);
            // 
            // btnWriteLogStop
            // 
            this.btnWriteLogStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteLogStop.Location = new System.Drawing.Point(47, 106);
            this.btnWriteLogStop.Name = "btnWriteLogStop";
            this.btnWriteLogStop.Size = new System.Drawing.Size(139, 41);
            this.btnWriteLogStop.TabIndex = 0;
            this.btnWriteLogStop.Text = "WriteLogStop";
            this.btnWriteLogStop.UseVisualStyleBackColor = true;
            this.btnWriteLogStop.Click += new System.EventHandler(this.btnWriteLogStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 413);
            this.Controls.Add(this.btnWriteLogStop);
            this.Controls.Add(this.btnWriteLogStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWriteLogStart;
        private System.Windows.Forms.Button btnWriteLogStop;
    }
}

