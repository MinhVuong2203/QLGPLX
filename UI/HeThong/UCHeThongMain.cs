using BLL.Utils;
using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UI.Helpers;

namespace UI.HeThong
{
    public partial class UCHeThongMain : UserControl
    {
        private string duongDanAnh = null;
        private string pass = null;
        public UCHeThongMain()
        {
            InitializeComponent();
        }

        private void UCHeThongMain_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadData();
            FormatDataGridView();
        }

        // Load danh sách chức vụ vào ComboBox
        private void LoadChucVu()
        {
            try
            {
                if (DatabaseSession.Context == null)
                {
                    MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var chucVus = DatabaseSession.Context.ChucVus.ToList();
                cboChucVu.DataSource = chucVus;
                cboChucVu.DisplayMember = "TenChucVu";
                cboChucVu.ValueMember = "MaChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chức vụ: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load dữ liệu cán bộ vào DataGridView
        private void LoadData()
        {
            try
            {
                if (DatabaseSession.Context == null)
                {
                    MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var canBos = DatabaseSession.Context.CanBos
                    .Include(c => c.MaChucVuNavigation)
                    .Select(c => new
                    {
                        c.MaCanBo,
                        c.HoTen,
                        ChucVu = c.MaChucVuNavigation.TenChucVu,
                        c.Username,
                        c.Email,
                        c.DienThoai,
                        NgayTao = c.NgayTao.HasValue ? c.NgayTao.Value.ToString("dd/MM/yyyy HH:mm") : "",
                        TrangThai = c.TrangThai ? "Hoạt động" : "Ngưng việc",
                        c.Anh3x4
                    })
                    .OrderByDescending(c => c.MaCanBo)
                    .ToList();

                dgv.DataSource = canBos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Định dạng DataGridView
        private void FormatDataGridView()
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            // Đặt tên cột
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
                dgv.Columns["MaCanBo"].Width = 100;
                dgv.Columns["HoTen"].HeaderText = "Họ và tên";
                dgv.Columns["ChucVu"].HeaderText = "Chức vụ";
                dgv.Columns["Username"].HeaderText = "Tên đăng nhập";
                dgv.Columns["Email"].HeaderText = "Email";
                dgv.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgv.Columns["DienThoai"].Width = 120;
                dgv.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgv.Columns["NgayTao"].Width = 150;
                dgv.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgv.Columns["TrangThai"].Width = 120;
                dgv.Columns["Anh3x4"].Visible = false;

                // Căn giữa một số cột
                dgv.Columns["MaCanBo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["NgayTao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Màu sắc cho trạng thái
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["TrangThai"].Value?.ToString() == "Ngưng việc")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }

                dgv.DefaultCellStyle.ForeColor = Color.Black;
            }

            // Style cho header
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;
        }

        // Khi chọn dòng trong DataGridView
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            this.picAnh.Image = null;
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                try
                {
                    if (DatabaseSession.Context == null) return;

                    int maCanBo = Convert.ToInt32(dgv.CurrentRow.Cells["MaCanBo"].Value);

                    var canBo = DatabaseSession.Context.CanBos
                        .Include(c => c.MaChucVuNavigation)
                        .FirstOrDefault(c => c.MaCanBo == maCanBo);
                    duongDanAnh = canBo.Anh3x4;
                    if (canBo != null)
                    {
                        txtMaCanBo.Text = canBo.MaCanBo.ToString();
                        txtHoTen.Text = canBo.HoTen;
                        txtUsername.Text = canBo.Username;
                        txtPassword.Text = "********";
                        pass = canBo.Password;
                        txtEmail.Text = canBo.Email ?? "";
                        txtDienThoai.Text = canBo.DienThoai ?? "";
                        cboChucVu.SelectedValue = canBo.MaChucVu;
                        chkTrangThai.Checked = canBo.TrangThai;

                        if (!string.IsNullOrEmpty(canBo.Anh3x4))
                        {
                            string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                            string imagePath = Path.Combine(solutionPath, "Resources", canBo.Anh3x4);

                            if (File.Exists(imagePath))
                            {
                                using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                                picAnh.Image = Image.FromStream(stream);
                                picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị thông tin: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Chọn ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (string.IsNullOrWhiteSpace(this.txtHoTen.Text) || string.IsNullOrWhiteSpace(this.txtUsername.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cá nhân trước khi chọn ảnh!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string tenFile = $"AnhCanBo_{txtHoTen.Text}_{txtUsername.Text}";
                string rs = ImageHelper.LuuAnh(picAnh, tenFile);
                if (!string.IsNullOrEmpty(rs))
                {
                    this.duongDanAnh = rs;
                }
            }
        }

        // Validate username (chỉ chứa chữ cái, số, dấu gạch dưới)
        private bool IsValidUsername(string username)
        {
            var regex = new Regex(@"^[a-zA-Z0-9_]{6,100}$");
            return regex.IsMatch(username);
        }

        // Validate dữ liệu nhập với các ràng buộc
        private bool ValidateInput(bool isUpdate = false)
        {
            if (DatabaseSession.Context == null)
            {
                MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            // 2. Kiểm tra username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập username!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (txtUsername.Text.Trim().Length < 6)
            {
                MessageBox.Show("Username phải có ít nhất 6 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (txtUsername.Text.Trim().Length > 100)
            {
                MessageBox.Show("Username không được vượt quá 100 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (!IsValidUsername(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username chỉ được chứa chữ cái, số và dấu gạch dưới (_)!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // 3. Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (txtPassword.Text.Length > 100)
            {
                MessageBox.Show("Mật khẩu không được vượt quá 100 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            // 4. Kiểm tra email (nếu có)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!ValidationHelper.IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không đúng định dạng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            // 5. Kiểm tra số điện thoại (nếu có)
            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                if (!ValidationHelper.IsValidPhone(txtDienThoai.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!\nSố điện thoại phải bắt đầu bằng 0 hoặc +84 và có 10 số.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDienThoai.Focus();
                    return false;
                }
            }

            // 6. Kiểm tra chức vụ
            if (cboChucVu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChucVu.Focus();
                return false;
            }

            // 7. Kiểm tra username đã tồn tại (UNIQUE constraint)
            if (isUpdate)
            {
                int currentId = Convert.ToInt32(txtMaCanBo.Text);
                if (DatabaseSession.Context.CanBos.Any(c => c.Username == txtUsername.Text.Trim() && c.MaCanBo != currentId))
                {
                    MessageBox.Show("Username đã tồn tại trong hệ thống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return false;
                }
            }
            else
            {
                if (DatabaseSession.Context.CanBos.Any(c => c.Username == txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Username đã tồn tại trong hệ thống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return false;
                }
            }

            // 8. Kiểm tra email đã tồn tại (nếu có nhập)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (isUpdate)
                {
                    int currentId = Convert.ToInt32(txtMaCanBo.Text);
                    if (DatabaseSession.Context.CanBos.Any(c => c.Email == txtEmail.Text.Trim() && c.MaCanBo != currentId))
                    {
                        MessageBox.Show("Email đã được sử dụng bởi cán bộ khác!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return false;
                    }
                }
                else
                {
                    if (DatabaseSession.Context.CanBos.Any(c => c.Email == txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Email đã được sử dụng bởi cán bộ khác!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return false;
                    }
                }
            }

            // 9. Kiểm tra trùng sdt
            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                if (isUpdate)
                {
                    int currentId = Convert.ToInt32(txtMaCanBo.Text);
                    if (DatabaseSession.Context.CanBos.Any(c => c.DienThoai == txtDienThoai.Text.Trim() && c.MaCanBo != currentId))
                    {
                        MessageBox.Show("SĐT đã được sử dụng bởi cán bộ khác!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDienThoai.Focus();
                        return false;
                    }
                }
                else
                {
                    if (DatabaseSession.Context.CanBos.Any(c => c.DienThoai == txtDienThoai.Text.Trim()))
                    {
                        MessageBox.Show("SĐT đã được sử dụng bởi cán bộ khác!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDienThoai.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

       
        // Tạo SQL Server Login, User và cấp quyền
        private bool CreateSqlServerLoginAndUser(string username, string password, int maChucVu)
        {
            try
            {
                var connectionString = DatabaseSession.Context.Database.GetConnectionString();
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 1. Kiểm tra login đã tồn tại chưa
                    string checkLoginSql = "SELECT COUNT(*) FROM sys.server_principals WHERE name = @username";
                    using (var checkCmd = new SqlCommand(checkLoginSql, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int loginExists = (int)checkCmd.ExecuteScalar();
                        if (loginExists > 0)
                        {
                            MessageBox.Show($"SQL Server Login '{username}' đã tồn tại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // 2. Tạo LOGIN
                    string createLoginSql = $"CREATE LOGIN [{username}] WITH PASSWORD = '{password}', CHECK_POLICY = OFF";
                    using (var createLoginCmd = new SqlCommand(createLoginSql, connection))
                    {
                        createLoginCmd.ExecuteNonQuery();
                    }

                    // 3. Tạo USER trong database hiện tại
                    string createUserSql = $"CREATE USER [{username}] FOR LOGIN [{username}]";
                    using (var createUserCmd = new SqlCommand(createUserSql, connection))
                    {
                        createUserCmd.ExecuteNonQuery();
                    }

                    // 4. Cấp quyền theo chức vụ
                    if (!GrantPermissionsByRole(connection, username, maChucVu))
                    {
                        // Nếu cấp quyền thất bại, rollback (xóa user và login)
                        try
                        {
                            string dropUserSql = $"DROP USER [{username}]";
                            using (var dropUserCmd = new SqlCommand(dropUserSql, connection))
                            {
                                dropUserCmd.ExecuteNonQuery();
                            }

                            string dropLoginSql = $"DROP LOGIN [{username}]";
                            using (var dropLoginCmd = new SqlCommand(dropLoginSql, connection))
                            {
                                dropLoginCmd.ExecuteNonQuery();
                            }
                        }
                        catch { }

                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo SQL Server Login/User: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Cập nhật mật khẩu SQL Server Login
        private bool UpdateSqlServerLoginPassword(string username, string newPassword)
        {
            try
            {
                var connectionString = DatabaseSession.Context.Database.GetConnectionString();
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string alterLoginSql = $"ALTER LOGIN [{username}] WITH PASSWORD = '{newPassword}'";
                    using (var alterCmd = new SqlCommand(alterLoginSql, connection))
                    {
                        alterCmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật mật khẩu SQL Server Login: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Vô hiệu hóa SQL Server Login
        private bool DisableSqlServerLogin(string username)
        {
            try
            {
                var connectionString = DatabaseSession.Context.Database.GetConnectionString();
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string disableLoginSql = $"ALTER LOGIN [{username}] DISABLE";
                    using (var disableCmd = new SqlCommand(disableLoginSql, connection))
                    {
                        disableCmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi vô hiệu hóa SQL Server Login: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Kích hoạt lại SQL Server Login
        private bool EnableSqlServerLogin(string username)
        {
            try
            {
                var connectionString = DatabaseSession.Context.Database.GetConnectionString();
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string enableLoginSql = $"ALTER LOGIN [{username}] ENABLE";
                    using (var enableCmd = new SqlCommand(enableLoginSql, connection))
                    {
                        enableCmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kích hoạt SQL Server Login: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Thêm cán bộ
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(false))
                return;

            try
            {
                if (DatabaseSession.Context == null)
                {
                    MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                int maChucVu = Convert.ToInt32(cboChucVu.SelectedValue);

                // 1. Tạo SQL Server Login, User và cấp quyền
                if (!CreateSqlServerLoginAndUser(username, password, maChucVu))
                {
                    return;
                }

                // 2. Thêm cán bộ vào database
                var canBo = new CanBo
                {
                    HoTen = txtHoTen.Text.Trim(),
                    Username = username,
                    Password = PasswordHelper.HashPassword(password),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                    DienThoai = string.IsNullOrWhiteSpace(txtDienThoai.Text) ? null : txtDienThoai.Text.Trim(),
                    MaChucVu = maChucVu,
                    TrangThai = chkTrangThai.Checked,
                    NgayTao = DateTime.Now,
                    Anh3x4 = this.duongDanAnh
                };

                DatabaseSession.Context.CanBos.Add(canBo);
                DatabaseSession.Context.SaveChanges();

                string chucVuName = cboChucVu.Text;
                MessageBox.Show($"Thêm cán bộ thành công!\n\n" +
                    $"SQL Server Login: {username}\n" +
                    $"Password: {password}\n" +
                    $"Chức vụ: {chucVuName}\n" +
                    $"Quyền đã được cấp tự động theo chức vụ.",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                FormatDataGridView();
                ClearInputs();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Lỗi cơ sở dữ liệu: {dbEx.InnerException?.Message ?? dbEx.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm cán bộ: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sửa thông tin cán bộ
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCanBo.Text))
            {
                MessageBox.Show("Vui lòng chọn cán bộ cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(true))
                return;

            try
            {
                if (DatabaseSession.Context == null)
                {
                    MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maCanBo = Convert.ToInt32(txtMaCanBo.Text);
                var canBo = DatabaseSession.Context.CanBos.FirstOrDefault(c => c.MaCanBo == maCanBo);

                if (canBo == null)
                {
                    MessageBox.Show("Không tìm thấy cán bộ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string username = txtUsername.Text.Trim();
                string newPasswordInput = txtPassword.Text.Trim();
                string newHashedPassword;
                int newMaChucVu = Convert.ToInt32(cboChucVu.SelectedValue);
                int oldMaChucVu = canBo.MaChucVu;

                var connectionString = DatabaseSession.Context.Database.GetConnectionString();
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 1. Cập nhật mật khẩu nếu có thay đổi
                    string oldHashedPassword = canBo.Password.Trim();


                    if (newPasswordInput == "********" || string.IsNullOrEmpty(newPasswordInput))
                    {
                        newHashedPassword = pass;
                    }
                    else 
                    {
                        newHashedPassword = PasswordHelper.HashPassword(newPasswordInput);
                        if (!UpdateSqlServerLoginPassword(username, newPasswordInput))
                        {
                            return;
                        }
                    }

                    // 2. Xử lý thay đổi chức vụ
                    if (oldMaChucVu != newMaChucVu)
                    {
                        // Thu hồi quyền cũ
                        RevokePermissionsByRole(connection, username, oldMaChucVu);

                        // Cấp quyền mới
                        if (!GrantPermissionsByRole(connection, username, newMaChucVu))
                        {
                            // Nếu cấp quyền mới thất bại, cấp lại quyền cũ
                            GrantPermissionsByRole(connection, username, oldMaChucVu);
                            return;
                        }
                    }

                    // 3. Xử lý thay đổi trạng thái
                    if (canBo.TrangThai != chkTrangThai.Checked)
                    {
                        if (chkTrangThai.Checked)
                        {
                            if (!EnableSqlServerLogin(username))
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (!DisableSqlServerLogin(username))
                            {
                                return;
                            }
                        }
                    }
                }

                // 4. Cập nhật thông tin trong database
                canBo.HoTen = txtHoTen.Text.Trim();
                canBo.Username = username;
                canBo.Password = newHashedPassword;
                canBo.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                canBo.DienThoai = string.IsNullOrWhiteSpace(txtDienThoai.Text) ? null : txtDienThoai.Text.Trim();
                canBo.MaChucVu = newMaChucVu;
                canBo.TrangThai = chkTrangThai.Checked;
                canBo.Anh3x4 = this.duongDanAnh;

                DatabaseSession.Context.SaveChanges();

                string message = "Cập nhật thông tin cán bộ thành công!";
                if (oldMaChucVu != newMaChucVu)
                {
                    message += "\nQuyền đã được cập nhật theo chức vụ mới.";
                }

                MessageBox.Show(message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                FormatDataGridView();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Lỗi cơ sở dữ liệu: {dbEx.InnerException?.Message ?? dbEx.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa thông tin cán bộ: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ngưng việc
        private void btnNgungViec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCanBo.Text))
            {
                MessageBox.Show("Vui lòng chọn cán bộ cần ngưng việc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn cho cán bộ '{txtHoTen.Text}' ngưng việc?\n\n" +
                "Cán bộ sẽ không thể đăng nhập vào hệ thống nữa.\n" +
                "SQL Server Login sẽ bị vô hiệu hóa (DISABLE).",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (DatabaseSession.Context == null)
                    {
                        MessageBox.Show("Chưa kết nối với cơ sở dữ liệu!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int maCanBo = Convert.ToInt32(txtMaCanBo.Text);
                    var canBo = DatabaseSession.Context.CanBos.FirstOrDefault(c => c.MaCanBo == maCanBo);

                    if (canBo == null)
                    {
                        MessageBox.Show("Không tìm thấy cán bộ!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 1. Vô hiệu hóa SQL Server Login
                    if (!DisableSqlServerLogin(canBo.Username))
                    {
                        return;
                    }

                    // 2. Cập nhật trạng thái trong database
                    canBo.TrangThai = false;
                    DatabaseSession.Context.SaveChanges();

                    MessageBox.Show("Đã cho cán bộ ngưng việc!\nSQL Server Login đã bị vô hiệu hóa.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    FormatDataGridView();
                    chkTrangThai.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thực hiện: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Làm mới form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // Xóa các ô nhập liệu
        private void ClearInputs()
        {
            txtMaCanBo.Clear();
            txtHoTen.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            chkTrangThai.Checked = true;
            picAnh.Image = null;
            duongDanAnh = null;

            if (cboChucVu.Items.Count > 0)
                cboChucVu.SelectedIndex = 0;

            txtHoTen.Focus();
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            if (this.IsShowpass)
            {
                ShowPass.Image = UI.Properties.Resources.CloseEyes;

                txtPassword.UseSystemPasswordChar = true;
                this.IsShowpass = false;
            }
            else
            {
                ShowPass.Image = UI.Properties.Resources.OpenEyes;

                txtPassword.UseSystemPasswordChar = false;
                this.IsShowpass = true;
            }
        }

        public bool GrantPermissionsByRole(SqlConnection connection, string username, int maChucVu)
        {
            try
            {
                string grantSql = "";

                switch (maChucVu)
                {
                    case 1: // Admin
                        grantSql = $@"
                    ALTER SERVER ROLE securityadmin ADD MEMBER [{username}];
                ";
                        break;

                    case 2: // Cán bộ Hồ sơ
                        grantSql = $@"
                    GRANT SELECT, INSERT, UPDATE, DELETE ON HoSo TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON CongDan TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON CanBo_HoSo TO [{username}];
                    GRANT SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    GRANT SELECT ON KetQuaThi TO [{username}];
                    GRANT SELECT ON ChucVu TO [{username}];
                    GRANT EXECUTE ON OBJECT::dbo.sp_CongDan_PhuHopTheoHang TO [{username}];
                ";
                        break;

                    case 3: // Kỳ thi sát hạch
                        grantSql = $@"
                    GRANT SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    GRANT SELECT ON dbo.ChucVu TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON KyThi TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON KetQuaChiTiet TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON KetQuaThi TO [{username}];
                    GRANT SELECT ON HoSo TO [{username}];
                    GRANT SELECT, UPDATE ON GiayPhep TO [{username}];
                    GRANT SELECT ON HangGiayPhep TO [{username}];
                    GRANT SELECT ON CongDan TO [{username}];
                    GRANT EXECUTE ON OBJECT::dbo.sp_CapNhatTrangThaiKyThi TO [{username}];
                ";
                        break;

                    case 4: // Cấp GPLX
                        grantSql = $@"
                    GRANT SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    GRANT SELECT ON dbo.ChucVu TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON GiayPhep TO [{username}];
                    GRANT SELECT ON HangGiayPhep TO [{username}];
                    GRANT SELECT ON CongDan TO [{username}];
                ";
                        break;

                    case 5: // Vi phạm
                        grantSql = $@"
                    GRANT SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    GRANT SELECT ON dbo.ChucVu TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON ViPham TO [{username}];
                    GRANT SELECT, INSERT, UPDATE, DELETE ON LoaiViPham TO [{username}];
                    GRANT SELECT, UPDATE ON GiayPhep TO [{username}];
                    GRANT SELECT ON HangGiayPhep TO [{username}];
                    GRANT SELECT ON CongDan TO [{username}];
                ";
                        break;

                    default:
                        MessageBox.Show("Chức vụ không hợp lệ!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                }

                // Thực thi các lệnh GRANT
                if (!string.IsNullOrEmpty(grantSql))
                {
                    using (var cmd = new SqlCommand(grantSql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cấp quyền: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Thu hồi quyền theo chức vụ
        public bool RevokePermissionsByRole(SqlConnection connection, string username, int maChucVu)
        {
            try
            {
                string revokeSql = "";

                switch (maChucVu)
                {
                    case 1: // Admin
                        revokeSql = $@"
                    ALTER SERVER ROLE securityadmin DROP MEMBER [{username}];
                ";
                        break;

                    case 2: // Cán bộ Hồ sơ
                        revokeSql = $@"
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON HoSo TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON CongDan TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON CanBo_HoSo TO [{username}];
                    REVOKE SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    REVOKE SELECT ON KetQuaThi TO [{username}];
                    REVOKE SELECT ON ChucVu TO [{username}];
                    REVOKE EXECUTE ON OBJECT::dbo.sp_CongDan_PhuHopTheoHang TO [{username}];
                ";
                        break;

                    case 3: // Kỳ thi sát hạch
                        revokeSql = $@"
                    REVOKE SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    REVOKE SELECT ON dbo.ChucVu TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON KyThi TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON KetQuaChiTiet TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON KetQuaThi TO [{username}];
                    REVOKE SELECT ON HoSo TO [{username}];
                    REVOKE SELECT, UPDATE ON GiayPhep TO [{username}];
                    REVOKE SELECT ON HangGiayPhep TO [{username}];
                    REVOKE SELECT ON CongDan TO [{username}];
                    REVOKE EXECUTE ON OBJECT::dbo.sp_CapNhatTrangThaiKyThi TO [{username}];
                ";
                        break;

                    case 4: // Cấp GPLX
                        revokeSql = $@"
                    REVOKE SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    REVOKE SELECT ON dbo.ChucVu TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON GiayPhep TO [{username}];
                    REVOKE SELECT ON HangGiayPhep TO [{username}];
                    REVOKE SELECT ON CongDan TO [{username}];
                ";
                        break;

                    case 5: // Vi phạm
                        revokeSql = $@"
                    REVOKE SELECT, UPDATE ON dbo.CanBo TO [{username}];
                    REVOKE SELECT ON dbo.ChucVu TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON ViPham TO [{username}];
                    REVOKE SELECT, INSERT, UPDATE, DELETE ON LoaiViPham TO [{username}];
                    REVOKE SELECT, UPDATE ON GiayPhep TO [{username}];
                    REVOKE SELECT ON HangGiayPhep TO [{username}];
                    REVOKE SELECT ON CongDan TO [{username}];
                ";
                        break;

                    default:
                        return false;
                }

                // Thực thi các lệnh REVOKE
                if (!string.IsNullOrEmpty(revokeSql))
                {
                    using (var cmd = new SqlCommand(revokeSql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thu hồi quyền: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}