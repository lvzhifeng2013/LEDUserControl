using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DymChangLable
{
    public partial class RollLabel : UserControl
    {

        private PointF _LabelLocation = new PointF();
        private bool bResverDir = false;
        private bool _bStart = false;

        private Thread _ThreadShow = null;

        private int movestep = 10;
        private int moveinterval = 200;
        private string captiontext = "label";


        public  string CaptionText
        {
            get
            {
                return captiontext;
            }
            set
            {
                captiontext = value;
            }
        }
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

        public int MoveInterval
        {
            set { moveinterval = value; }
            get { return moveinterval; }
     
        }
        public int MoveSetp
        {
            set { movestep = value; }
            get { return movestep; }
        }

        public override Color  BackColor
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
    
        public void Start()
        {
            _bStart = true;
        }
        public void Stop()
        {
            _bStart = false;
        }

        public RollLabel()
        {
            InitializeComponent();
       
            _ThreadShow = new Thread(RollText);
            _ThreadShow.Start();
        }

        private void RollText()
        {
            while (!this.IsDisposed)
            {
                Thread.Sleep(moveinterval);
                if (_bStart )
                {
                    try
                    {
                        Invoke((EventHandler)(delegate
                        {
                            Refresh();
                        }));
                    }
                    catch (System.Exception)
                    {
                        return;
                    }
                }
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SizeF s = g.MeasureString(captiontext.ToString(), Font);
            SolidBrush brush = new SolidBrush(ForeColor);
            g.Clear(BackColor);
            if (_LabelLocation.X >= label.Location.X + label.Width - s.Width)
            {
                _LabelLocation = new PointF(_LabelLocation.X - MoveSetp, 0);
                bResverDir = true;
            }
            else if (_LabelLocation.X <= label.Location.X)
            {
                _LabelLocation = new PointF(_LabelLocation.X + MoveSetp, 0);
                bResverDir = false;
            }
            else
            {
                if (bResverDir)
                {
                    _LabelLocation.X -= MoveSetp;
                }
                else
                {
                    _LabelLocation.X += MoveSetp;
                }
            }
            g.DrawString(captiontext.ToString(), Font, brush, _LabelLocation);
        }

    }
}
