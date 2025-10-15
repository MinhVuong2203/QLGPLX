using DAL;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.Windows.Forms;

namespace UI.HoSo
{
    partial class UCThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label13 = new Label();
            dataGridViewAllCongDan = new DataGridView();
            congDanBindingSource1 = new BindingSource(components);
            label1 = new Label();
            lbTongCongDan = new Label();
            dataGridViewCongDanTheoNgay = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            dtpNgay = new DateTimePicker();
            lbCongDanNgay = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCongDan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)congDanBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCongDanTheoNgay).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 128, 128);
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(1630, 30);
            label13.TabIndex = 1;
            label13.Text = "Thống kê công dân mới";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewAllCongDan
            // 
            dataGridViewAllCongDan.ColumnHeadersHeight = 29;
            dataGridViewAllCongDan.Location = new Point(13, 807);
            dataGridViewAllCongDan.Name = "dataGridViewAllCongDan";
            dataGridViewAllCongDan.RowHeadersWidth = 51;
            dataGridViewAllCongDan.Size = new Size(1602, 538);
            dataGridViewAllCongDan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(13, 757);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 2;
            label1.Text = "Tổng số:";
            // 
            // lbTongCongDan
            // 
            lbTongCongDan.AutoSize = true;
            lbTongCongDan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongCongDan.ForeColor = Color.Red;
            lbTongCongDan.Location = new Point(123, 757);
            lbTongCongDan.Name = "lbTongCongDan";
            lbTongCongDan.Size = new Size(38, 31);
            lbTongCongDan.TabIndex = 3;
            lbTongCongDan.Text = "....";
            // 
            // dataGridViewCongDanTheoNgay
            // 
            dataGridViewCongDanTheoNgay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCongDanTheoNgay.Location = new Point(13, 142);
            dataGridViewCongDanTheoNgay.Name = "dataGridViewCongDanTheoNgay";
            dataGridViewCongDanTheoNgay.RowHeadersWidth = 51;
            dataGridViewCongDanTheoNgay.Size = new Size(1602, 529);
            dataGridViewCongDanTheoNgay.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(615, 702);
            label3.Name = "label3";
            label3.Size = new Size(354, 31);
            label3.TabIndex = 5;
            label3.Text = "DANH SÁCH TẤT CẢ CÔNG DÂN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(585, 52);
            label4.Name = "label4";
            label4.Size = new Size(455, 31);
            label4.TabIndex = 6;
            label4.Text = "DANH SÁCH CÔNG DÂN MỚI THEO NGÀY";
            // 
            // dtpNgay
            // 
            dtpNgay.CalendarFont = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(688, 106);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(203, 27);
            dtpNgay.TabIndex = 7;
            dtpNgay.ValueChanged += dtpNgay_ValueChanged;
            // 
            // lbCongDanNgay
            // 
            lbCongDanNgay.AutoSize = true;
            lbCongDanNgay.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCongDanNgay.ForeColor = Color.Red;
            lbCongDanNgay.Location = new Point(142, 105);
            lbCongDanNgay.Name = "lbCongDanNgay";
            lbCongDanNgay.Size = new Size(38, 31);
            lbCongDanNgay.TabIndex = 9;
            lbCongDanNgay.Text = "....";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(13, 105);
            label6.Name = "label6";
            label6.Size = new Size(99, 31);
            label6.TabIndex = 8;
            label6.Text = "Kết quả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(180, 105);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 11;
            label7.Text = "công dân";
            // 
            // UCThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(label7);
            Controls.Add(lbCongDanNgay);
            Controls.Add(label6);
            Controls.Add(dtpNgay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridViewCongDanTheoNgay);
            Controls.Add(lbTongCongDan);
            Controls.Add(label1);
            Controls.Add(dataGridViewAllCongDan);
            Controls.Add(label13);
            Name = "UCThongKe";
            Size = new Size(1630, 1371);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCongDan).EndInit();
            ((System.ComponentModel.ISupportInitialize)congDanBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCongDanTheoNgay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        public void LoadAllCongDan(DataGridView dgv)
        {
            // 2️⃣ Tạo style
            DataGridViewCellStyle evenStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            DataGridViewCellStyle oddStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.Black
            };
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 100, 100),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                WrapMode = DataGridViewTriState.True
            };
            DataGridViewCellStyle defaultStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True,
                SelectionBackColor = Color.FromArgb(255, 230, 153),
                SelectionForeColor = Color.Black
            };

            // 3️⃣ Cấu hình DataGridView
            dgv.AutoGenerateColumns = true;   // ⚠️ Cho phép tạo cột tự động

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.RowsDefaultCellStyle = evenStyle;
            dgv.AlternatingRowsDefaultCellStyle = oddStyle;
            dgv.DefaultCellStyle = defaultStyle;

            // 4️⃣ Tùy chỉnh kích thước
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 5️⃣ Giao diện
            dgv.GridColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.BackgroundColor = Color.White;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            
        }

        public void setData(DataGridView dgv, object data)
        {
            dgv.DataSource = data;
        }
        public void setLabelSum()
        {
            lbTongCongDan.Text = DatabaseSession.Context.CongDans.Count().ToString();
        }

        public void setLabelSumDate(DateTime date)
        {
            lbCongDanNgay.Text = DatabaseSession.Context.CongDans
                .Where(cd => cd.NgayTao.Date == date.Date)
                .Count().ToString();
        }



        public Object getAllCongDan()
        {
            return DatabaseSession.Context.CongDans.Select(cd => new
            {
                cd.MaCongDan,
                cd.HoTen,
                cd.NgaySinh,
                cd.GioiTinh,
                cd.Cccd,
                cd.DiaChi,
                cd.SoDienThoai,
                cd.Email,
                cd.TinhTrangSucKhoe,
                cd.NgayKhamSucKhoe,
                cd.NgayTao
            }).ToList();
        }

        public Object getCongDanTheoNgay(DateTime date)
        {
            return DatabaseSession.Context.CongDans
                .Where(cd => cd.NgayTao.Date == date.Date)
                .Select(cd => new
                {
                    cd.MaCongDan,
                    cd.HoTen,
                    cd.NgaySinh,
                    cd.GioiTinh,
                    cd.Cccd,
                    cd.DiaChi,
                    cd.SoDienThoai,
                    cd.Email,
                    cd.TinhTrangSucKhoe,
                    cd.NgayKhamSucKhoe,
                    cd.NgayTao
                }).ToList();
        }


        #endregion

        private Label label13;
        private DataGridView dataGridViewAllCongDan;    
        private DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private BindingSource congDanBindingSource1;
        private Label label1;
        private Label lbTongCongDan;
        private DataGridView dataGridViewCongDanTheoNgay;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgay;
        private Label lbCongDanNgay;
        private Label label6;
        private Label label7;
    }
}
