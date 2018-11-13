using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveLableDemo
{
    public partial class MoveLabelForm : Form
    {
        public MoveLabelForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            moveLabel1.IsStart = true;

        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
            moveLabel1.IsStart = false;
            moveLabel1.SetLableLocation();
        }

        private void btnLeftToRight_Click(object sender, EventArgs e)
        {
            moveLabel1.MoveType = MoveLabel.MoveTypeEnum.FromLeftToRight;
            moveLabel1.IsStart = true;
        }

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            moveLabel1.MoveType = MoveLabel.MoveTypeEnum.FromRightToLeft;
            moveLabel1.IsStart = true;
        }

        private void btnTopToBottom_Click(object sender, EventArgs e)
        {
            moveLabel1.MoveType = MoveLabel.MoveTypeEnum.FromTopToBottom;
            moveLabel1.IsStart = true;
        }

        private void btnBottomToTop_Click(object sender, EventArgs e)
        {
            moveLabel1.MoveType = MoveLabel.MoveTypeEnum.FromBottomToTop;
            moveLabel1.IsStart = true;
        }
    }
}
