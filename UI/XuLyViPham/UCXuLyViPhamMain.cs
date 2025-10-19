using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CapGPLX;

namespace UI.XuLyViPham
{
    public partial class UCXuLyViPhamMain : UserControl
    {
        public UCXuLyViPhamMain()
        {
            InitializeComponent();
        }

        private void cácLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UCCacLoaiViPham());
        }

        private void thôngTinCôngDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UCGhiNhan());
        }
    }
}
