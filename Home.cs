using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIRAMA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int grid = 16;
        int caption = 40;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if (p.Y <= caption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - grid && p.Y >= this.ClientSize.Height - grid)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
                if (p.X <= grid && p.Y>=this.ClientSize.Height - grid)
                {
                    m.Result = (IntPtr)16;
                    return;
                }
                if (p.X <= grid)
                {
                    m.Result = (IntPtr)10;
                    return;
                }
                if (p.X >= ClientSize.Width - grid)
                {
                    m.Result = (IntPtr)11;
                    return;
                }
                if (p.X <= grid)
                {
                    m.Result = (IntPtr)12;
                    return;
                }
                if (p.Y >= ClientSize.Height - grid)
                {
                    m.Result = (IntPtr)15;
                }
            }
            base.WndProc(ref m);
        }
    }
}
