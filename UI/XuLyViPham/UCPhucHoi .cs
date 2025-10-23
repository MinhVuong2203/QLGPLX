using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace UI.XuLyViPham
{
    public partial class UCPhucHoi : UserControl
    {
        public UCPhucHoi()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string searchText = "")
        {
            try
            {
                if (DatabaseSession.Context == null)
                {
                    MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var context = DatabaseSession.Context;

                // Lấy danh sách GPLX bị tạm giữ (điểm = 0)
                var query = context.GiayPheps
                    .Include(gp => gp.MaCongDanNavigation)
                    .Include(gp => gp.MaHangNavigation)
                    .Include(gp => gp.ViPhams)
                        .ThenInclude(vp => vp.LoaiViPham)
                    .Where(gp => gp.SoDiem == 0 && gp.TrangThai == "Tạm giữ");

                // Tìm kiếm theo số GPLX
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query = query.Where(gp => gp.SoGiayPhep.Contains(searchText));
                }

                var danhSach = query.ToList();

                // Chuẩn bị dữ liệu hiển thị
                var displayData = danhSach.Select(gp =>
                {
                    var viPhamGanNhat = gp.ViPhams
                        .OrderByDescending(vp => vp.ThoiGianViPham)
                        .FirstOrDefault();

                    DateTime? ngayViPhamGanNhat = viPhamGanNhat?.ThoiGianViPham;
                    int soThangTuViPham = 0;
                    bool duDieuKienPhucHoi = false;

                    if (ngayViPhamGanNhat.HasValue)
                    {
                        TimeSpan khoangCach = DateTime.Now - ngayViPhamGanNhat.Value;
                        soThangTuViPham = (int)(khoangCach.TotalDays / 30);
                        duDieuKienPhucHoi = soThangTuViPham >= 12;
                    }

                    return new
                    {
                        GiayPhepId = gp.GiayPhepId,
                        SoGiayPhep = gp.SoGiayPhep,
                        HoTen = gp.MaCongDanNavigation?.HoTen ?? "",
                        CCCD = gp.MaCongDanNavigation?.Cccd ?? "",
                        HangGPLX = gp.MaHangNavigation?.TenHang ?? "",
                        SoDiem = gp.SoDiem,
                        TrangThai = gp.TrangThai,
                        NgayViPhamGanNhat = ngayViPhamGanNhat,
                        SoThangTuViPham = soThangTuViPham,
                        DuDieuKienPhucHoi = duDieuKienPhucHoi
                    };
                }).ToList();

                // Cấu hình DataGridView
                dgv.AutoGenerateColumns = false;
                dgv.Columns.Clear();
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.MultiSelect = false;
                dgv.RowTemplate.Height = 40;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); 
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);       
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.BackgroundColor = Color.White;

                // Màu nền và chữ cho các ô dữ liệu
                dgv.DefaultCellStyle.BackColor = Color.White;
               
                dgv.DefaultCellStyle.ForeColor = Color.Black;

                // Thêm các cột
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "GiayPhepId",
                    DataPropertyName = "GiayPhepId",
                    HeaderText = "ID",
                    Visible = false
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SoGiayPhep",
                    DataPropertyName = "SoGiayPhep",
                    HeaderText = "Số GPLX",
                    Width = 120,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "HoTen",
                    DataPropertyName = "HoTen",
                    HeaderText = "Họ và Tên",
                    Width = 200,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "CCCD",
                    DataPropertyName = "CCCD",
                    HeaderText = "CCCD",
                    Width = 120,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "HangGPLX",
                    DataPropertyName = "HangGPLX",
                    HeaderText = "Hạng GPLX",
                    Width = 100,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SoDiem",
                    DataPropertyName = "SoDiem",
                    HeaderText = "Số Điểm",
                    Width = 80,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TrangThai",
                    DataPropertyName = "TrangThai",
                    HeaderText = "Trạng Thái",
                    Width = 120,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NgayViPhamGanNhat",
                    DataPropertyName = "NgayViPhamGanNhat",
                    HeaderText = "Ngày Vi Phạm Gần Nhất",
                    Width = 180,
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "dd/MM/yyyy HH:mm"
                    }
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SoThangTuViPham",
                    DataPropertyName = "SoThangTuViPham",
                    HeaderText = "Số Tháng",
                    Width = 100,
                    ReadOnly = true
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DuDieuKienPhucHoi",
                    DataPropertyName = "DuDieuKienPhucHoi",
                    HeaderText = "Đủ Điều Kiện",
                    Visible = false
                });

                // Thêm cột Button
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
                {
                    Name = "btnAction",
                    HeaderText = "Thao Tác",
                    Width = 150,
                    Text = "Action",
                    UseColumnTextForButtonValue = false
                };
                dgv.Columns.Add(btnColumn);

                // Gán dữ liệu
                dgv.DataSource = displayData;

                // Tùy chỉnh button text và màu sắc
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    bool duDieuKien = Convert.ToBoolean(row.Cells["DuDieuKienPhucHoi"].Value);
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["btnAction"];

                    if (duDieuKien)
                    {
                        btnCell.Value = "Phục Hồi";
                        btnCell.Style.BackColor = Color.LightGreen;
                        btnCell.Style.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        btnCell.Value = "Chưa Đến Hạn";
                        btnCell.Style.BackColor = Color.LightGray;
                        btnCell.Style.ForeColor = Color.DarkGray;
                    }
                    btnCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Đăng ký sự kiện click button
                dgv.CellContentClick -= dgv_CellContentClick;
                dgv.CellContentClick += dgv_CellContentClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra có phải click vào button không
            if (e.RowIndex < 0 || e.ColumnIndex != dgv.Columns["btnAction"].Index)
                return;

            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                bool duDieuKien = Convert.ToBoolean(row.Cells["DuDieuKienPhucHoi"].Value);

                if (!duDieuKien)
                {
                    MessageBox.Show("Chưa đủ 12 tháng kể từ lần vi phạm gần nhất!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int giayPhepId = Convert.ToInt32(row.Cells["GiayPhepId"].Value);
                string soGPLX = row.Cells["SoGiayPhep"].Value.ToString();
                string hoTen = row.Cells["HoTen"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn phục hồi GPLX?\n\n" +
                    $"Số GPLX: {soGPLX}\n" +
                    $"Họ tên: {hoTen}\n\n" +
                    $"Điểm sẽ được khôi phục về 12 và trạng thái về 'Còn hiệu lực'.",
                    "Xác Nhận Phục Hồi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PhucHoiGPLX(giayPhepId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PhucHoiGPLX(int giayPhepId)
        {
            try
            {
                if (DatabaseSession.Context == null)
                {
                    MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var context = DatabaseSession.Context;

                // Kiểm tra giấy phép tồn tại
                var giayPhep = context.GiayPheps.Find(giayPhepId);

                if (giayPhep == null)
                {
                    MessageBox.Show("Không tìm thấy giấy phép!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Detach entity để tránh tracking conflict
                context.Entry(giayPhep).State = EntityState.Detached;

                // Phục hồi điểm và trạng thái bằng SQL Raw
                var updateSql = @"UPDATE GiayPhep 
                                 SET SoDiem = 12, 
                                     TrangThai = N'Còn hiệu lực' 
                                 WHERE GiayPhepID = {0}";

                int rowsAffected = context.Database.ExecuteSqlRaw(updateSql, giayPhepId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Phục hồi GPLX thành công!", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu
                    LoadData(txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("Không thể phục hồi GPLX!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phục hồi GPLX: {ex.Message}\n\nChi tiết: {ex.InnerException?.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    
    }
}