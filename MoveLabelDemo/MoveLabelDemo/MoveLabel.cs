using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MoveLableDemo
{
    public partial class MoveLabel : UserControl
    {
        #region 字段
        private bool isStart = false;
        private Thread _ThreadShow = null;
        private int moveStep = 2;
        private int moveInterval = 100;
        #endregion

        #region 属性

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }


        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }
        public Label Lable
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }

        public int MoveInterval
        {
            set { moveInterval = value; }
            get { return moveInterval; }

        }
        public int MoveStep
        {
            set { moveStep = value; }
            get { return moveStep; }
        }


        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        public MoveTypeEnum MoveType { get; set; }
        public bool IsStart { get => isStart; set => isStart = value; }
        #endregion

        #region 方法



        public MoveLabel()
        {
            InitializeComponent();
            MoveType = MoveTypeEnum.FromRightToLeft;
            label.Left = 0;

            _ThreadShow = new Thread(MoveText);
            _ThreadShow.Start();
        }
        private void MoveText()
        {
            while (!this.IsDisposed)
            {
                Thread.Sleep(moveInterval);
                if (isStart)
                {
                    try
                    {
                        Invoke((EventHandler)(delegate
                        {
                            StartMove();
                        }));
                    }
                    catch (System.Exception)
                    {
                        return;
                    }
                }
            }
        }
        private void StartMove()
        {
            switch (MoveType)
            {
                case MoveTypeEnum.FromLeftToRight:
                    FromLeftToRight();
                    break;
                case MoveTypeEnum.FromRightToLeft:
                    FromRightToLeft();
                    break;
                case MoveTypeEnum.FromBottomToTop:
                    FromBottomToTop();
                    break;
                case MoveTypeEnum.FromTopToBottom:
                    FromTopToBottom();
                    break;
                default:
                    break;
            }
        }

        void FromLeftToRight()
        {
            label.Left += MoveStep;
            if (label.Left > label.Parent.Size.Width)
            {
                label.Left = 0;
            }
        }
        void FromRightToLeft()
        {
            label.Left -= MoveStep;
            if (label.Right < 0)
            {
                label.Left = this.Width;
            }
        }
        void FromBottomToTop()
        {
            label.Top -= MoveStep;
            if (label.Top < 0)
            {
                label.Top = label.Parent.Height;
            }
        }
        void FromTopToBottom()
        {
            label.Top += MoveStep;
            if (label.Top > label.Parent.Size.Height)
            {
                label.Top = 0;
            }
        }

        /// <summary>
        /// 设置label的位置，使其居中
        /// </summary>
        public void SetLableLocation()
        {
            if (this.InvokeRequired) Invoke(new SetLableLocationDel(SetLableLocation));
            else
            {
                label.Location = new Point((this.Width - label.Width) / 2, (this.Height - label.Height) / 2);
            }
        }


        private delegate void SetLableLocationDel();


        #endregion


        #region 事件
        private void MoveLabel_Resize(object sender, EventArgs e)
        {
            SetLableLocation();
        }

        private void MoveLabel_Load(object sender, EventArgs e)
        {
            SetLableLocation();
        }
        #endregion

        #region 自定义枚举型
        public enum MoveTypeEnum
        {
            FromLeftToRight,
            FromRightToLeft,
            FromBottomToTop,
            FromTopToBottom
        }
        #endregion

    }
}
