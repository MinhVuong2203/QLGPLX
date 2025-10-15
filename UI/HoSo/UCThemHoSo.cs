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
    public partial class UCThemHoSo : UserControl
    {
        public UCThemHoSo()
        {
            InitializeComponent();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDataCCCD();
        }
    }
}
