using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.HoSo
{
    public partial class UCHoSoMain : UserControl
    {
        public CanBo CanBo { get; set; }
        public UCHoSoMain(CanBo canBo)
        {
            this.CanBo = canBo;
            InitializeComponent();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thêmCôngDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadControl(new HoSo.UCThemCongDan());
        }

        private void thongkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadControl(new HoSo.UCThongKe());
        }

        private void xétDuyệtHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadControl(new HoSo.UCThemHoSo(this.CanBo));
        }

        private void traCứuHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadControl(new HoSo.UCDuyetHoSo(this.CanBo));
        }
    }
}
