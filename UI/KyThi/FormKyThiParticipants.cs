using BLL;
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
    public partial class FormKyThiParticipants : Form
    {
        private readonly KyThiBLL _bll = new KyThiBLL();
        private readonly int _kyThiId;

        // Designer controls
        private Label lblHeader;
        private DataGridView dgvParticipants;
        private Button btnClose;
        private Panel panelTop;
        public FormKyThiParticipants()
        {
            InitializeComponent();
        }
        public FormKyThiParticipants(int kyThiId)
        {
            _kyThiId = kyThiId;
            InitializeComponent();
            LoadParticipants();
        }

        private void LoadParticipants()
        {
            var list = _bll.GetParticipants(_kyThiId);
            dgvParticipants.DataSource = list.Select(k => new
            {
                k.HoSo.HoSoId,
                MaCongDan = k.HoSo.MaCongDan,
                HoTen = k.HoSo.MaCongDanNavigation?.HoTen,
                k.LanThi,
                Ngày = k.NgayKetLuan
            }).ToList();

            // style grid
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipants.DefaultCellStyle.ForeColor = Color.Black;
            dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 230, 210);
            dgvParticipants.EnableHeadersVisualStyles = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
