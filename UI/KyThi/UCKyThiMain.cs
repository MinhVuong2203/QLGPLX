using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.KyThi
{
    public partial class UCKyThiMain : UserControl
    {
        public UCKyThiMain()
        {
            InitializeComponent();
        }

        private void thôngTinCôngDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UCKyThi());
        }

        private void hồSơCôngDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UCKetQua());
        }
    }
}
