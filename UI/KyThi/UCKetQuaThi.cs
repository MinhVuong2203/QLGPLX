using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI.KyThi
{
    public partial class UCKetQuaThi : UserControl
    {
        private readonly KyThiBLL _kyThiBLL = new KyThiBLL();
        private readonly HangGiayPhepBLL _hangGiayPhepBLL = new HangGiayPhepBLL();
        private string maHang = null;

        public UCKetQuaThi()
        {
            InitializeComponent();
            WireEvents();
            LoadCboKyThi();
        }

        private void WireEvents()
        {

        }

        // Load only KyThi that are "Đang diễn ra", format: [KyThiID] - [TenKyThi]
        private void LoadCboKyThi()
        {
            cboKyThi.Items.Clear();
            var list = _kyThiBLL.GetOngoingKyThi();
            foreach (var k in list)
            {
                cboKyThi.Items.Add(new ComboboxItem { Text = $"{k.KyThiId} - {k.TenKyThi}", Value = k.KyThiId });
            }
            if (cboKyThi.Items.Count > 0) cboKyThi.SelectedIndex = 0;
        }

        private void cboKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThiSinh.SelectedIndex = -1;
            cboLanThi.SelectedIndex = -1;
            if (cboKyThi.SelectedItem is ComboboxItem it)
            {
                int kyThiId = (int)it.Value;
                this.maHang = _kyThiBLL.getMaHangByKyThi(kyThiId);
                LoadThiSinhForKyThi(kyThiId);
            }
        }

        // tìm các thí sinh trong kì thi format: [CCCD] - [HoTen]
        private void LoadThiSinhForKyThi(int kyThiId)
        {
            cboThiSinh.Items.Clear();
            var list = _kyThiBLL.GetDistinctParticipantsForKyThi(kyThiId);
            foreach (var k in list)
            {
                var cd = k.HoSo?.MaCongDanNavigation;
                if (cd == null) continue;
                cboThiSinh.Items.Add(new ComboboxItem
                {
                    Text = $"{cd.Cccd} - {cd.HoTen}",
                    Value = new { HoSoId = k.HoSoId, MaCongDan = cd.MaCongDan }
                });
            }
            if (cboThiSinh.Items.Count > 0) cboThiSinh.SelectedIndex = 0;
            else
            {
                cboLanThi.Items.Clear();
                panel1.Enabled = false;
                panel2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void CboThiSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKyThi.SelectedItem is not ComboboxItem kIt || cboThiSinh.SelectedItem == null) return;
            int kyThiId = (int)kIt.Value;
            dynamic val = ((ComboboxItem)cboThiSinh.SelectedItem).Value;
            int hoSoId = (int)val.HoSoId;

            // determine available lan thi (from existing entries)
            var latest = _kyThiBLL.GetLatestKetQuaThi(kyThiId, hoSoId);
            int currentMaxLan = latest?.LanThi ?? 0;

            // clear and populate cboLanThi
            cboLanThi.Items.Clear();
            if (currentMaxLan >= 1)
            {
                for (int i = 1; i <= currentMaxLan; i++)
                {
                    cboLanThi.Items.Add($"Lần thi {i}");
                }
            }
            else
            {
                cboLanThi.Items.Add("Lần thi 1");
            }
            cboLanThi.SelectedIndex = cboLanThi.Items.Count - 1; // select newest by default
        }

        private void CboLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKyThi.SelectedItem is not ComboboxItem kIt || cboThiSinh.SelectedItem == null) return;
            int kyThiId = (int)kIt.Value;
            dynamic val = ((ComboboxItem)cboThiSinh.SelectedItem).Value;
            int hoSoId = (int)val.HoSoId;

            // parse selected lan
            var text = cboLanThi.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(text)) return;
            int lan = 1;
            if (text.StartsWith("Lần thi"))
            {
                var parts = text.Split(' ');
                if (parts.Length >= 3 && int.TryParse(parts[2], out int p)) lan = p;
            }

            // Kiểm tra xem lần này có phải lần mới nhất không
            var latest = _kyThiBLL.GetLatestKetQuaThi(kyThiId, hoSoId);
            int maxLan = latest?.LanThi ?? 1;
            bool isLatestLan = (lan == maxLan);

            // find ket qua for this lan
            var ketQua = DatabaseSession.Context.KetQuaThis
                .Include(k => k.KetQuaChiTiets)
                .FirstOrDefault(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId && k.LanThi == lan);

            if (ketQua != null)
            {
                var ly = ketQua.KetQuaChiTiets.FirstOrDefault(ct => ct.LoaiMon == "Lý thuyết");
                var thuc = ketQua.KetQuaChiTiets.FirstOrDefault(ct => ct.LoaiMon == "Thực hành");

                txtDiemLyThuyet.Text = ly?.Diem.ToString() ?? "";
                txtDiemThucHanh.Text = thuc?.Diem.ToString() ?? "";

                SetResultLabel(lbKetQuaLyThuyet, ly?.KetQua);
                SetResultLabel(lbKetQuaThucHanh, thuc?.KetQua);
                SetResultLabel(lbKetQuaTongHop, ketQua.KetQuaTongHop);

                // === LOGIC MỚI ===
                if (!isLatestLan)
                {
                    // Lần cũ -> disable tất cả
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    // Lần mới nhất -> enable nút Lưu
                    button1.Enabled = true;

                    // Kiểm tra lần trước đó
                    if (lan > 1)
                    {
                        var previousLan = DatabaseSession.Context.KetQuaThis
                            .Include(k => k.KetQuaChiTiets)
                            .FirstOrDefault(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId && k.LanThi == (lan - 1));

                        if (previousLan != null)
                        {
                            var prevLy = previousLan.KetQuaChiTiets.FirstOrDefault(ct => ct.LoaiMon == "Lý thuyết");

                            if (prevLy != null && prevLy.KetQua == "Đạt")
                            {
                                // Lần trước đã đạt lý thuyết -> disable panel1
                                panel1.Enabled = false;
                                panel2.Enabled = true;
                            }
                            else if (ly != null && ly.KetQua == "Đạt")
                            {
                                // Lần hiện tại đã đạt lý thuyết
                                panel1.Enabled = false;
                                panel2.Enabled = true;
                            }
                            else if (ly != null && ly.KetQua == "Không đạt")
                            {
                                // Lần hiện tại rớt lý thuyết
                                panel1.Enabled = true;
                                panel2.Enabled = false;
                            }
                            else
                            {
                                // Chưa có kết quả
                                panel1.Enabled = true;
                                panel2.Enabled = true;
                            }
                        }
                        else
                        {
                            // Không tìm thấy lần trước -> logic bình thường
                            ApplyNormalPanelLogic(ly);
                        }
                    }
                    else
                    {
                        // Lần 1 -> logic bình thường
                        ApplyNormalPanelLogic(ly);
                    }
                }
            }
            else
            {
                // Chưa có dữ liệu cho lần này
                txtDiemLyThuyet.Text = "";
                txtDiemThucHanh.Text = "";
                SetResultLabel(lbKetQuaLyThuyet, null);
                SetResultLabel(lbKetQuaThucHanh, null);
                SetResultLabel(lbKetQuaTongHop, null);

                if (!isLatestLan)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;

                    // Kiểm tra lần trước nếu là lần 2 trở đi
                    if (lan > 1)
                    {
                        var previousLan = DatabaseSession.Context.KetQuaThis
                            .Include(k => k.KetQuaChiTiets)
                            .FirstOrDefault(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId && k.LanThi == (lan - 1));

                        if (previousLan != null)
                        {
                            var prevLy = previousLan.KetQuaChiTiets.FirstOrDefault(ct => ct.LoaiMon == "Lý thuyết");

                            if (prevLy != null && prevLy.KetQua == "Đạt")
                            {
                                // Lần trước đã đạt lý thuyết -> chỉ cho nhập thực hành
                                panel1.Enabled = false;
                                panel2.Enabled = true;
                            }
                            else
                            {
                                // Lần trước chưa đạt hoặc chưa có -> cho nhập cả 2
                                panel1.Enabled = true;
                                panel2.Enabled = true;
                            }
                        }
                        else
                        {
                            panel1.Enabled = true;
                            panel2.Enabled = true;
                        }
                    }
                    else
                    {
                        // Lần 1
                        panel1.Enabled = true;
                        panel2.Enabled = true;
                    }
                }
            }
        }

        // Helper method cho logic panel bình thường
        private void ApplyNormalPanelLogic(KetQuaChiTiet ly)
        {
            if (ly != null && ly.KetQua == "Đạt")
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
            }
            else if (ly != null && ly.KetQua == "Không đạt")
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
            }
        }

        private void SetResultLabel(Label lbl, string result)
        {
            if (string.IsNullOrEmpty(result))
            {
                lbl.Text = "....";
                lbl.ForeColor = SystemColors.ControlText;
                return;
            }
            lbl.Text = result;
            lbl.ForeColor = result.Trim() == "Đạt" ? Color.Green : Color.Red;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cboKyThi.SelectedItem is not ComboboxItem kyIt || cboThiSinh.SelectedItem == null || cboLanThi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn kỳ thi, thí sinh và lần thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kyThiId = (int)kyIt.Value;
            dynamic val = ((ComboboxItem)cboThiSinh.SelectedItem).Value;
            int hoSoId = (int)val.HoSoId;

            var text = cboLanThi.SelectedItem.ToString();
            int lan = 1;
            if (text.StartsWith("Lần thi"))
            {
                var parts = text.Split(' ');
                if (parts.Length >= 3 && int.TryParse(parts[2], out int p)) lan = p;
            }

            decimal? diemLy = null;
            decimal? diemThuc = null;
            if (panel1.Enabled && decimal.TryParse(txtDiemLyThuyet.Text.Trim(), out var dly))
                diemLy = dly;
            if (panel2.Enabled && decimal.TryParse(txtDiemThucHanh.Text.Trim(), out var dth))
                diemThuc = dth;

            try
            {
                _kyThiBLL.SaveOrUpdateResult(kyThiId, hoSoId, lan, diemLy, diemThuc);
                MessageBox.Show("Lưu kết quả thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadThiSinhForKyThi(kyThiId);

                cboThiSinh.SelectedIndex = -1;
                cboLanThi.Items.Clear();
                txtDiemLyThuyet.Text = "";
                txtDiemThucHanh.Text = "";
                lbKetQuaLyThuyet.Text = "_____";
                lbKetQuaLyThuyet.ForeColor = SystemColors.ControlText;
                lbKetQuaThucHanh.Text = "_____";
                lbKetQuaThucHanh.ForeColor = SystemColors.ControlText;
                lbKetQuaTongHop.Text = "....";
                lbKetQuaTongHop.ForeColor = SystemColors.ControlText;
                pictureBox1.Image = null;

                panel1.Enabled = false;
                panel2.Enabled = false;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        private void txtDiemLyThuyet_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiemLyThuyet.Text))
            {
                int diem = int.Parse(txtDiemLyThuyet.Text);
                if (diem < 0 || diem > 25)
                {
                    MessageBox.Show("Điểm thi lý thuyết không hợp lệ (0-25).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiemLyThuyet.Text = "";
                    return;
                }
                HangGiayPhep hgp = _hangGiayPhepBLL.GetHangGiayPhep(maHang);
                int diemDat = (int)(hgp != null ? hgp.DiemDatLyThuyet : 21);

                lbKetQuaLyThuyet.Text = (diem >= diemDat) ? "Đạt" : "Không đạt";
                lbKetQuaLyThuyet.ForeColor = lbKetQuaLyThuyet.Text.Equals("Đạt") ? Color.Green : Color.Red;
                this.panel2.Enabled = lbKetQuaLyThuyet.Text.Equals("Đạt") ? true : false;
            }
        }

        private void txtDiemThucHanh_Leave(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(txtDiemThucHanh.Text))
            {
                int diem = int.Parse(txtDiemThucHanh.Text);
                if (diem < 0 || diem > 100 || diem % 5 != 0)
                {
                    MessageBox.Show("Điểm thi thực hành không hợp lệ (0-100) & bội của 5.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiemThucHanh.Text = "";
                    return;
                }
                HangGiayPhep hgp = _hangGiayPhepBLL.GetHangGiayPhep(maHang);
                int diemDat = (int)(hgp != null ? hgp.DiemDatThucHanh : 80);
                lbKetQuaThucHanh.Text = (diem >= diemDat) ? "Đạt" : "Không đạt";
                lbKetQuaThucHanh.ForeColor = lbKetQuaThucHanh.Text.Equals("Đạt") ? Color.Green : Color.Red;
            }
        }

        private void lbKetQuaLyThuyet_TextChanged(object sender, EventArgs e)
        {
            CapNhatKetQua();
        }

        private void CapNhatKetQua()
        {
            if (!panel1.Enabled && lbKetQuaThucHanh.Text.Trim().Equals("Đạt"))
            {
                lbKetQuaTongHop.Text = "Đạt";
                lbKetQuaTongHop.ForeColor = Color.Green;
                return;
            }
            string a = lbKetQuaLyThuyet.Text.Trim();
            string b = lbKetQuaThucHanh.Text.Trim();
            Debug.WriteLine($"KetQuaLy: {a}, KetQuaThuc: {b}");
            if (a.Equals("Đạt") && b.Equals("Đạt"))
            {
                lbKetQuaTongHop.Text = "Đạt";
                lbKetQuaTongHop.ForeColor = Color.Green;
                return;
            }
            lbKetQuaTongHop.Text = "Không đạt";
            lbKetQuaTongHop.ForeColor = Color.Red;
        }
    }
}