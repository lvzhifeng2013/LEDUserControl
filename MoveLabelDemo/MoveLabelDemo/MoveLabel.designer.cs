namespace MoveLableDemo
{
    partial class MoveLabel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(5, 41);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 20);
            this.label.TabIndex = 1;
            this.label.Text = "label";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MoveLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Name = "MoveLabel";
            this.Size = new System.Drawing.Size(365, 139);
            this.Load += new System.EventHandler(this.MoveLabel_Load);
            this.Resize += new System.EventHandler(this.MoveLabel_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
    }
}
