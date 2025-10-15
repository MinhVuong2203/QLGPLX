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
    public partial class UCThongKe : UserControl
    {
        public UCThongKe()
        {
            InitializeComponent();
            LoadAllCongDan(this.dataGridViewAllCongDan);
            setData(this.dataGridViewAllCongDan, this.getAllCongDan());
            setLabelSum();
            LoadAllCongDan(this.dataGridViewCongDanTheoNgay);
            setData(this.dataGridViewCongDanTheoNgay, this.getCongDanTheoNgay(this.dtpNgay.Value));
            setLabelSumDate(this.dtpNgay.Value);
        }

        private void dataGridViewAllCongDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            setLabelSumDate(this.dtpNgay.Value);
            setData(this.dataGridViewCongDanTheoNgay, this.getCongDanTheoNgay(this.dtpNgay.Value));
        }
    }
}
