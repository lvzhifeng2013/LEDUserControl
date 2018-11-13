namespace MoveLableDemo
{
    partial class MoveLabelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeftToRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.btnTopToBottom = new System.Windows.Forms.Button();
            this.btnBottomToTop = new System.Windows.Forms.Button();
            this.moveLabel1 = new MoveLableDemo.MoveLabel();
            this.SuspendLayout();
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Location = new System.Drawing.Point(192, 315);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(75, 23);
            this.btnLeftToRight.TabIndex = 1;
            this.btnLeftToRight.Text = "从左向右";
            this.btnLeftToRight.UseVisualStyleBackColor = true;
            this.btnLeftToRight.Click += new System.EventHandler(this.btnLeftToRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(659, 211);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(329, 315);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnRightToLeft.TabIndex = 3;
            this.btnRightToLeft.Text = "从右向左";
            this.btnRightToLeft.UseVisualStyleBackColor = true;
            this.btnRightToLeft.Click += new System.EventHandler(this.btnRightToLeft_Click);
            // 
            // btnTopToBottom
            // 
            this.btnTopToBottom.Location = new System.Drawing.Point(462, 315);
            this.btnTopToBottom.Name = "btnTopToBottom";
            this.btnTopToBottom.Size = new System.Drawing.Size(75, 23);
            this.btnTopToBottom.TabIndex = 4;
            this.btnTopToBottom.Text = "从上至下";
            this.btnTopToBottom.UseVisualStyleBackColor = true;
            this.btnTopToBottom.Click += new System.EventHandler(this.btnTopToBottom_Click);
            // 
            // btnBottomToTop
            // 
            this.btnBottomToTop.Location = new System.Drawing.Point(591, 315);
            this.btnBottomToTop.Name = "btnBottomToTop";
            this.btnBottomToTop.Size = new System.Drawing.Size(75, 23);
            this.btnBottomToTop.TabIndex = 5;
            this.btnBottomToTop.Text = "从下至上";
            this.btnBottomToTop.UseVisualStyleBackColor = true;
            this.btnBottomToTop.Click += new System.EventHandler(this.btnBottomToTop_Click);
            // 
            // moveLabel1
            // 
            this.moveLabel1.IsStart = false;
            this.moveLabel1.Location = new System.Drawing.Point(205, 86);
            this.moveLabel1.MoveInterval = 100;
            this.moveLabel1.MoveStep = 2;
            this.moveLabel1.MoveType = MoveLableDemo.MoveLabel.MoveTypeEnum.FromRightToLeft;
            this.moveLabel1.Name = "moveLabel1";
            this.moveLabel1.Size = new System.Drawing.Size(365, 139);
            this.moveLabel1.TabIndex = 6;
            // 
            // MoveLabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveLabel1);
            this.Controls.Add(this.btnBottomToTop);
            this.Controls.Add(this.btnTopToBottom);
            this.Controls.Add(this.btnRightToLeft);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLeftToRight);
            this.Name = "MoveLabelForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLeftToRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRightToLeft;
        private System.Windows.Forms.Button btnTopToBottom;
        private System.Windows.Forms.Button btnBottomToTop;
        private MoveLabel moveLabel1;
    }
}