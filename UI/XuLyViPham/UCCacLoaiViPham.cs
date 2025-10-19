using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.XuLyViPham
{
    public partial class UCCacLoaiViPham : UserControl
    {
        public UCCacLoaiViPham()
        {
            InitializeComponent();
            Load();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var filtered = _listViPham
                .Where(k =>
                    k.TenViPham.ToLower().Contains(keyword) ||
                    k.MoTa.ToLower().Contains(keyword) ||
                    k.DiemTru.ToString().Contains(keyword) ||
                    k.MucPhatTu.ToString().Contains(keyword) ||
                    k.MucPhatDen.ToString().Contains(keyword))
                .Select(k => new
                {
                    k.LoaiViPhamId,
                    k.TenViPham,
                    k.DiemTru,
                    k.MucPhatTu,
                    k.MucPhatDen,
                    k.MoTa
                })
                .ToList();

            dgv.DataSource = filtered;
        }
    }
}
