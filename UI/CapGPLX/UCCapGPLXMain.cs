using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.CapGPLX
{
    public partial class UCCapGPLXMain : UserControl
    {
        public UCCapGPLXMain()
        {
            InitializeComponent();
        }

        private void hồSơCôngDânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadControl(new UCXetDuyetCapGPLX());
        }

        private void cấpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadControl(new UCCapLaiGPLX());
        }
    }
}
