CREATE QLGPLX;
USE QLGPLX;


-- === Công dân ===
CREATE TABLE CongDan (
    MaCongDan INT IDENTITY(1000,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL CHECK (NgaySinh >= '1900-01-01'),
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam',N'Nữ')),
    CCCD VARCHAR(20) UNIQUE NOT NULL,
    DiaChi NVARCHAR(255),
    SoDienThoai VARCHAR(15) UNIQUE CHECK (SoDienThoai LIKE '0%' AND LEN(SoDienThoai)=10),
    Email VARCHAR(100) UNIQUE,
    TinhTrangSucKhoe NVARCHAR(50) DEFAULT N'Khỏe mạnh',
    NgayKhamSucKhoe DATE NULL,
    GiayKhamSucKhoe VARCHAR(50) NULL,
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),
    Anh3x4 NVARCHAR(255) NULL
);

CREATE TABLE HangGiayPhep (
    MaHang VARCHAR(10) PRIMARY KEY,
    TenHang NVARCHAR(50) NOT NULL,
    MoTa NVARCHAR(255) NULL,
    DoTuoiToiThieu INT NOT NULL DEFAULT 18,
    SoCauThiLyThuyet INT NULL,
    ThoiGianThiLyThuyet INT NULL,
    DiemDatLyThuyet DECIMAL(5,2) NULL,
    DiemDatThucHanh DECIMAL(5,2) NULL
);


-- === Hồ sơ đăng ký thi ===
CREATE TABLE HoSo (
    HoSoID INT IDENTITY(1000,1) PRIMARY KEY,
    MaCongDan INT NOT NULL FOREIGN KEY REFERENCES CongDan(MaCongDan),
    MaHang VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES HangGiayPhep(MaHang),
    NgayNop DATE NOT NULL DEFAULT GETDATE(),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đang xử lý' CHECK (TrangThai IN (N'Đang xử lý',N'Đủ điều kiện',N'Không đủ điều kiện')),
    TrangThaiThanhToan BIT NOT NULL DEFAULT 0,
    GhiChu NVARCHAR(255)
);

CREATE TABLE KyThi (
    KyThiID INT IDENTITY(1000,1) PRIMARY KEY,
    TenKyThi NVARCHAR(150) NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NULL,
    GioBatDau TIME(0) NULL,
    DiaDiem NVARCHAR(255) NULL,
    MaHang VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES HangGiayPhep(MaHang),
    SoLuongToiDa INT NULL,
    TrangThai NVARCHAR(30) DEFAULT N'Sắp diễn ra'
);


-- Bảng KẾT QUẢ (tổng hợp theo lần thi: HoSo + KyThi + LanThi)
CREATE TABLE KetQuaThi (
    KetQuaID INT IDENTITY(1,1) PRIMARY KEY,
    HoSoID INT NOT NULL FOREIGN KEY REFERENCES HoSo(HoSoID),
    KyThiID INT NOT NULL FOREIGN KEY REFERENCES KyThi(KyThiID),
    KetQuaTongHop NVARCHAR(20) NOT NULL CHECK (KetQuaTongHop IN (N'Đạt', N'Không đạt', N'Chưa thi')),
    NgayKetLuan DATETIME NOT NULL DEFAULT GETDATE(),
	LanThi INT NOT NULL DEFAULT 1,
    GhiChu NVARCHAR(255) NULL,
    CONSTRAINT UQ_KetQuaThi UNIQUE (HoSoID, KyThiID, LanThi)  -- 1 bản ghi tổng hợp/mỗi lần thi
);


-- Bảng CHI TIẾT KẾT QUẢ (mỗi phần thi 1 dòng)
CREATE TABLE KetQuaChiTiet (
    ChiTietID INT IDENTITY(1,1) PRIMARY KEY,
    KetQuaID INT NOT NULL FOREIGN KEY REFERENCES KetQuaThi(KetQuaID) ON DELETE CASCADE,
    LoaiMon NVARCHAR(20) NOT NULL CHECK (LoaiMon IN (N'Lý thuyết', N'Thực hành')),
    Diem DECIMAL(5,2) NULL,
	ThoiGianBatDau DATETIME NULL,
    KetQua NVARCHAR(20) NOT NULL CHECK (KetQua IN (N'Đạt', N'Không đạt', N'Vắng')),
    GhiChu NVARCHAR(255) NULL,
    CONSTRAINT UQ_KetQuaChiTiet UNIQUE (KetQuaID, LoaiMon)  -- tránh trùng 1 môn/lần thi
);

CREATE TABLE GiayPhep (
    GiayPhepID INT IDENTITY(1,1) PRIMARY KEY,
    MaCongDan INT NOT NULL FOREIGN KEY REFERENCES CongDan(MaCongDan),
    MaHang VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES HangGiayPhep(MaHang),
    SoGiayPhep VARCHAR(20) UNIQUE NOT NULL,
    NgayCap DATE NOT NULL,
    NgayHetHan DATE NULL,                 -- A1/A có thể NULL (vĩnh viễn)
	SoDiem INT DEFAULT(12),
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Còn hiệu lực' CHECK (TrangThai IN (N'Còn hiệu lực', N'Hết hạn', N'Bị thu hồi', N'Tạm giữ', N'Chờ xét duyệt')),
    GhiChu NVARCHAR(255) NULL,  
);

-- === Danh mục & ghi nhận vi phạm ===
CREATE TABLE LoaiViPham (
    LoaiViPhamID INT IDENTITY(1,1) PRIMARY KEY,
    TenViPham NVARCHAR(255) NOT NULL,
    DiemTru INT NOT NULL DEFAULT 0 CHECK (DiemTru BETWEEN 0 AND 12),
    MucPhatTu DECIMAL(18,2) NULL,
    MucPhatDen DECIMAL(18,2) NULL,
    MoTa NVARCHAR(500) NULL
);

CREATE TABLE ViPham (
    ViPhamID INT IDENTITY(1,1) PRIMARY KEY,
    GiayPhepID INT NOT NULL FOREIGN KEY REFERENCES GiayPhep(GiayPhepID),
    LoaiViPhamID INT NOT NULL FOREIGN KEY REFERENCES LoaiViPham(LoaiViPhamID),
    ThoiGianViPham DATETIME NOT NULL DEFAULT GETDATE(),
    DiaDiem NVARCHAR(255) NULL,
    BienKiemSoat NVARCHAR(20) NULL,
    MucPhat DECIMAL(18,2) NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa xử lý'
        CHECK (TrangThai IN (N'Chưa xử lý', N'Đã xử phạt', N'Đã nộp phạt', N'Đang khiếu nại')),
    GhiChu NVARCHAR(500) NULL
);

INSERT INTO LoaiViPham (TenViPham, DiemTru, MucPhatTu, MucPhatDen, MoTa) VALUES
(N'Không đội mũ bảo hiểm (người điều khiển)',              2,   200000,   400000, N'Đi mô tô/xe máy không đội mũ hoặc đội không đúng quy cách'),
(N'Chở người ngồi sau không đội mũ bảo hiểm',             1,   200000,   400000, N'Chở người không đội mũ/đội không đúng'),
(N'Vượt đèn đỏ/đèn vàng (không đúng quy định)',           3,   600000,  1000000, N'Không chấp hành tín hiệu đèn giao thông'),
(N'Đi sai làn/đường quy định',                            2,   400000,   800000, N'Đi vào làn/đường không dành cho xe máy'),
(N'Đi ngược chiều',                                       3,   800000,  1500000, N'Đi vào đường ngược chiều, trừ đường một chiều có phân cách'),
(N'Quay đầu xe nơi cấm quay đầu',                         2,   300000,   600000, N'Quay đầu tại nơi có biển cấm'),
(N'Rẽ không bật tín hiệu',                                1,   200000,   400000, N'Không có tín hiệu báo hướng rẽ/chuyển làn'),
(N'Không nhường đường cho người đi bộ/xe ưu tiên',        2,   400000,   800000, N'Không nhường đường đúng quy định'),
(N'Chạy quá tốc độ 05–10 km/h',                           1,   200000,   400000, N'Vượt tốc độ mức 1'),
(N'Chạy quá tốc độ 10–20 km/h',                           2,   400000,   800000, N'Vượt tốc độ mức 2'),
(N'Chạy quá tốc độ >20 km/h',                             4,  1500000,  3000000, N'Vượt tốc độ mức 3'),
(N'Điện thoại khi đang lái xe',                           2,   600000,  1000000, N'Sử dụng điện thoại khi điều khiển'),
(N'Không có GPLX/không mang theo GPLX',                   4,  1200000,  3000000, N'Không có hoặc không xuất trình GPLX hợp lệ'),
(N'Không mang đăng ký xe',                                1,   200000,   400000, N'Không mang giấy đăng ký xe'),
(N'Không mang/không có BHDS bắt buộc',                    2,   200000,   400000, N'Bảo hiểm TNDS hết hạn/không có'),
(N'Xe không gương chiếu hậu bên trái',                    1,   100000,   200000, N'Thiếu gương chiếu hậu bắt buộc'),
(N'Không bật đèn khi trời tối/đường hầm',                 1,   200000,   400000, N'Không sử dụng đèn chiếu sáng đúng quy định'),
(N'Dừng/đỗ sai quy định',                                 1,   300000,   500000, N'Dừng, đỗ nơi cấm hoặc gây cản trở giao thông'),
(N'Đỗ xe trên phần đường người đi bộ/vạch qua đường',     2,   400000,   800000, N'Dừng/đỗ lấn chiếm lối qua đường'),
(N'Không chấp hành hiệu lệnh CSGT',                       5,  2000000,  4000000, N'Không tuân thủ kiểm tra/xử lý'),
(N'Nồng độ cồn: có nồng độ (mức 1)',                      6,  2000000,  4000000, N'Có nồng độ cồn mức thấp'),
(N'Nồng độ cồn: cao (mức 2)',                             8,  4000000,  6000000, N'Nồng độ cồn mức cao'),
(N'Chất ma túy trong cơ thể',                            12,  6000000, 10000000, N'Sử dụng chất ma túy khi điều khiển'),
(N'Không giữ khoảng cách an toàn',                        1,   200000,   400000, N'Bám đuôi, không giữ khoảng cách tối thiểu'),
(N'Bấm còi, rú ga, nẹt pô gây ồn',                         1,   200000,   400000, N'Gây mất trật tự, tiếng ồn'),
(N'Chở quá số người quy định',                            1,   200000,   400000, N'Chở 3 người trở lên trên xe máy (trừ TH đặc biệt)'),
(N'Chở hàng cồng kềnh, vượt quá kích thước',              2,   400000,   800000, N'Hàng hóa cồng kềnh nguy hiểm'),
(N'Đi vào đường cấm/khu vực cấm',                         3,   800000,  1500000, N'Vào đường/khu vực cấm theo biển báo'),
(N'Vượt xe không đúng quy định',                          2,   400000,   800000, N'Vượt tại nơi cấm, không đảm bảo an toàn'),
(N'Không nhường đường tại nơi giao nhau',                  2,   400000,   800000, N'Ưu tiên không đúng tại nút giao'),
(N'Không thắt dây an toàn (xe ô tô)',                      1,   300000,   500000, N'Áp dụng cho ô tô; để demo cross-type'),
(N'Đi xe trên vỉa hè (không được phép)',                  2,   400000,   800000, N'Chạy xe trên hè phố'),
(N'Đua xe trái phép/biểu diễn nguy hiểm',                12, 10000000, 20000000, N'Đua xe, bốc đầu, lạng lách'),
(N'Lấn làn, vượt vạch liền',                              2,   400000,   800000, N'Không tuân thủ vạch kẻ đường'),
(N'Không bật đèn báo dừng khẩn cấp khi cần',              1,   200000,   400000, N'Không cảnh báo nguy hiểm'),
(N'Chạy xe không có/mờ biển số',                          3,   800000,  1500000, N'Không gắn, gắn sai quy cách, che biển số'),
(N'Xe thay đổi kết cấu trái phép',                        3,  1000000,  3000000, N'Tự ý độ xe, ống xả, đèn…'),
(N'Không nhường đường xe ưu tiên (cứu thương, PCCC)',     4,  2000000,  4000000, N'Không nhường đường xe ưu tiên');



-- Bộ phận nội bộ
CREATE TABLE ChucVu (
    MaChucVu INT IDENTITY(1,1) PRIMARY KEY,
    TenChucVu NVARCHAR(50) UNIQUE NOT NULL,
);
INSERT INTO ChucVu(TenChucVu)
VALUES (N'Quản lý'), (N'Cán bộ hồ sơ'), (N'Cán bộ sát hạch'), (N'Cán bộ Cấp GPLX'), (N'Cán bộ xử lý vi phạm');
-- === Cán bộ / tài khoản / vai trò ===
CREATE TABLE CanBo (
    MaCanBo INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    MaChucVu INT NOT NULL FOREIGN KEY REFERENCES ChucVu(MaChucVu),     -- Hồ sơ / Sát hạch / Cấp / Vi phạm
    Email VARCHAR(120) NULL,
    DienThoai VARCHAR(15) NULL,
	NgayTao DATETIME DEFAULT GETDATE(),
	Username VARCHAR(100) UNIQUE NOT NULL CHECK (LEN(Username) >= 6),
	[Password] VARCHAR(100),
	Anh3x4 NVARCHAR(256),
    TrangThai BIT NOT NULL DEFAULT 1, -- Hoạt động / Khóa
);


DROP TABLE CanBo_HoSo
DROP TABLE CanBo
-- INSERT INTO (N'Nguyễn Tình', 2, ''

-- để xem xét xe hồ sơ do cán bộ nào duyệt
CREATE TABLE CanBo_HoSo(
	MaCanBo INT NOT NULL FOREIGN KEY REFERENCES CanBo(MaCanBo),
	HoSoID INT NOT NULL FOREIGN KEY REFERENCES HoSo(HoSoID),
	ThoiGian DATETIME NOT NULL DEFAULT GETDATE(),
	TrangThaiDuyet NVARCHAR(50) CHECK (TrangThaiDuyet IN (N'Đang xử lý',N'Đủ điều kiện',N'Không đủ điều kiện',N'Hoàn tất')),
	PRIMARY KEY (MaCanBo, HoSoID, ThoiGian)
)


-- Tạo cán bộ ở cấp server
CREATE LOGIN AdminVuong WITH PASSWORD = 'admin@123', CHECK_POLICY = OFF;
CREATE LOGIN NguyenTinh WITH PASSWORD = 'hoso@123', CHECK_POLICY = OFF; -- Cán bộ hồ sơ

-- Map login với databasee QLGPLX
USE QLGPLX
Go
CREATE USER AdminVuong FOR LOGIN AdminVuong;
CREATE USER NguyenTinh FOR LOGIN NguyenTinh;

-- Cấp quyền theo vai trò thực tế
 --1: admin: 
	ALTER ROLE db_owner ADD MEMBER AdminVuong;
	ALTER SERVER ROLE securityadmin ADD MEMBER AdminVuong;
 -- 2: Cán bộ Hồ sơ:
	GRANT SELECT, INSERT, UPDATE, DELETE ON HoSo TO NguyenTinh;
	GRANT SELECT, INSERT, UPDATE, DELETE ON CongDan TO NguyenTinh;
	GRANT SELECT, INSERT, UPDATE, DELETE ON CanBo_HoSo TO NguyenTinh;
	GRANT SELECT, UPDATE ON dbo.CanBo TO NguyenTinh;
	GRANT SELECT ON KetQuaThi TO NguyenTinh;
	GRANT SELECT ON ChucVu TO NguyenTinh;
	GRANT EXECUTE ON OBJECT::dbo.sp_CongDan_PhuHopTheoHang TO NguyenTinh;

	REVOKE SELECT, INSERT, UPDATE, DELETE ON HoSo TO NguyenTinh;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON CongDan TO NguyenTinh;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON CanBo_HoSo TO NguyenTinh;
	REVOKE SELECT, UPDATE ON dbo.CanBo TO NguyenTinh;
	REVOKE SELECT ON KetQuaThi TO NguyenTinh;
	REVOKE SELECT ON ChucVu TO NguyenTinh;
	REVOKE EXECUTE ON OBJECT::dbo.sp_CongDan_PhuHopTheoHang TO NguyenTinh;
	
	-- 3: Kỳ thi sách hạch
	REVOKE SELECT, UPDATE ON dbo.CanBo TO ThuThao;
	REVOKE SELECT ON dbo.ChucVu TO ThuThao;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON KyThi TO ThuThao;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON KetQuaChiTiet TO ThuThao;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON KetQuaThi TO ThuThao;
	REVOKE SELECT ON HoSo TO ThuThao;
	REVOKE SELECT, UPDATE ON GiayPhep TO ThuThao;
	REVOKE SELECT ON HangGiayPhep TO ThuThao;
	REVOKE SELECT ON CongDan TO ThuThao; 
	REVOKE EXECUTE ON OBJECT::dbo.sp_CapNhatTrangThaiKyThi TO ThuThao;

	GRANT SELECT, UPDATE ON dbo.CanBo TO ThuThao;
	GRANT SELECT ON dbo.ChucVu TO ThuThao;
	GRANT SELECT, INSERT, UPDATE, DELETE ON KyThi TO ThuThao;
	GRANT SELECT, INSERT, UPDATE, DELETE ON KetQuaChiTiet TO ThuThao;
	GRANT SELECT, INSERT, UPDATE, DELETE ON KetQuaThi TO ThuThao;
	GRANT SELECT ON HoSo TO ThuThao;
	GRANT SELECT, UPDATE ON GiayPhep TO ThuThao;
	GRANT SELECT ON HangGiayPhep TO ThuThao;
	GRANT SELECT ON CongDan TO ThuThao; 
	GRANT EXECUTE ON OBJECT::dbo.sp_CapNhatTrangThaiKyThi TO ThuThao;

	--4:  Cấp GPLX
	GRANT SELECT, UPDATE ON dbo.CanBo TO ThuThao;
	GRANT SELECT ON dbo.ChucVu TO ThuThao;
	GRANT SELECT, INSERT, UPDATE, DELETE ON GiayPhep TO ThuThao;
	GRANT SELECT ON HangGiayPhep TO ThuThao;
	GRANT SELECT ON CongDan TO ThuThao; 

	REVOKE SELECT, UPDATE ON dbo.CanBo TO ThuThao;
	REVOKE SELECT ON dbo.ChucVu TO ThuThao;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON GiayPhep TO ThuThao;
	REVOKE SELECT ON HangGiayPhep TO ThuThao;
	REVOKE SELECT ON CongDan TO ThuThao; 
	

	--5: Vi phạm
	GRANT SELECT, UPDATE ON dbo.CanBo TO ThuThao;
	GRANT SELECT ON dbo.ChucVu TO ThuThao;
	GRANT SELECT, INSERT, UPDATE, DELETE ON ViPham TO ThuThao;
	GRANT SELECT, INSERT, UPDATE, DELETE ON LoaiViPham TO ThuThao;
	GRANT SELECT, UPDATE ON GiayPhep TO ThuThao;
	GRANT SELECT ON HangGiayPhep TO ThuThao;
	GRANT SELECT ON CongDan TO ThuThao; 

	REVOKE SELECT, UPDATE ON dbo.CanBo TO ThuThao;
	REVOKE SELECT ON dbo.ChucVu TO ThuThao;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON ViPham TO ThuThao;
	REVOKE SELECT, INSERT, UPDATE, DELETE ON LoaiViPham TO ThuThao;
	REVOKE SELECT, UPDATE ON GiayPhep TO ThuThao;
	REVOKE SELECT ON HangGiayPhep TO ThuThao;
	REVOKE SELECT ON CongDan TO ThuThao; 



-- Thêm lưu trữ cán bộ vào database
INSERT INTO CanBo(HoTen, MaChucVu, Email, DienThoai, Username, Password)
VALUES (N'Nguyễn Minh Vương', 1, 'vuonghihihihi@gmail.com', '0818214849', 'AdminVuong', 'admin@123');


INSERT INTO CongDan(HoTen, NgaySinh, GioiTinh, CCCD, DiaChi, SoDienThoai, Email, TinhTrangSucKhoe, NgayKhamSucKhoe, GiayKhamSucKhoe, NgayTao, Anh3x4)
VALUES (N'Nguyễn Văn Bình', '2002-10-20', N'Nam', '087304004321', N'An Long', '0599599876', 'binh@gmail.com' ,N'Khỏe mạnh', '2025-07-06', './src/', '2025-10-07' , './src/');


INSERT INTO HangGiayPhep(MaHang, TenHang, MoTa, DoTuoiToiThieu, SoCauThiLyThuyet, ThoiGianThiLyThuyet, DiemDatLyThuyet, DiemDatThucHanh)
VALUES ('A1', N'Hạng A1', N'Xe mô tô đến 125cc', 18, 25, 21, 80, 80),
	   ('A', N'Hạng A', N'Xe mô tô trên 125cc', 18, 25, 21, 80, 80);

INSERT INTO HoSo(MaCongDan, MaHang)
VALUES (1000, 'A1') -- Mọi thứ mặc định ngày hôm nay, trạng thái Đang xử lý, Chưa thanh toán

INSERT INTO KyThi (TenKyThi, NgayBatDau, GioBatDau, NgayKetThuc,DiaDiem, MaHang, SoLuongToiDa, TrangThai)
VALUES (N'Đợt thi A1 - 05/2025', '2025-05-20', '2025-05-20','08:00:00', N'TT Sát hạch Q.9', 'A1', 200, N'Đã kết thúc');

INSERT INTO KetQuaThi(HoSoID, KyThiID, KetQuaTongHop, NgayKetLuan, LanThi, GhiChu)
VALUES (1001, 1000, N'Không đạt', '2025-10-08', 1, N'Rớt lý thuyết');

INSERT INTO KetQuaChiTiet(KetQuaID, LoaiMon, Diem, ThoiGianBatDau, KetQua, GhiChu)
VALUES (2, N'Lý thuyết', 19, '2025-10-08', N'Không đạt', 'Rớt')




-- Chỉ mục gợi ý
CREATE INDEX IX_HoSo_CongDan ON HoSo(MaCongDan);
CREATE INDEX IX_KQMon_HoSo ON KetQuaMonThi(HoSoID);
CREATE INDEX IX_KQMon_KyThi ON KetQuaMonThi(KyThiID);
CREATE INDEX IX_GPLX_CongDan ON GiayPhep(CongDanID);
CREATE INDEX IX_ViPham_GiayPhep ON ViPham(GiayPhepID);


-- XÓA
DROP TABLE [dbo].[ViPham]
DROP TABLE [dbo].[LoaiViPham]
DROP TABLE [dbo].[GiayPhep]
DROP TABLE [dbo].[KetQuaMonThi]
DROP TABLE [dbo].[MonThi]
DROP TABLE [dbo].[HoSo]
DROP TABLE [dbo].[KyThi]
DROP TABLE [dbo].[HangGiayPhep]
DROP TABLE [dbo].[CongDan]


-- TRIGGER
-- Tự động cập nhật kết quả bảng Kết quả chi tiết dựa vào điểm thi

CREATE OR ALTER TRIGGER trg_CapNhatKetQuaChiTiet
ON KetQuaChiTiet
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Compute KetQua for inserted/updated rows based on HangGiayPhep thresholds
    ;WITH ins AS (
        SELECT i.ChiTietID, i.KetQuaID, i.LoaiMon, i.Diem
        FROM inserted i
    ),
    ketqua_with_hang AS (
        SELECT 
            ins.ChiTietID,
            ins.KetQuaID,
            ins.LoaiMon,
            ins.Diem,
            kt.MaHang,
            CASE 
                WHEN ins.LoaiMon = N'Lý thuyết' THEN hg.DiemDatLyThuyet
                WHEN ins.LoaiMon = N'Thực hành' THEN hg.DiemDatThucHanh
                ELSE NULL
            END AS DiemChuan
        FROM ins
        JOIN KetQuaThi kqt ON kqt.KetQuaID = ins.KetQuaID
        JOIN KyThi kt ON kt.KyThiID = kqt.KyThiID
        LEFT JOIN HangGiayPhep hg ON hg.MaHang = kt.MaHang
    )
    UPDATE kqct
    SET KetQua = CASE 
                    WHEN kwh.Diem IS NULL THEN N'Vắng'
                    WHEN kwh.Diem >= ISNULL(kwh.DiemChuan, 0) THEN N'Đạt'
                    ELSE N'Không đạt'
                 END
    FROM KetQuaChiTiet kqct
    JOIN ketqua_with_hang kwh ON kqct.ChiTietID = kwh.ChiTietID
    WHERE ISNULL(kqct.KetQua, N'') <> 
          CASE 
            WHEN kwh.Diem IS NULL THEN N'Vắng'
            WHEN kwh.Diem >= ISNULL(kwh.DiemChuan, 0) THEN N'Đạt'
            ELSE N'Không đạt'
          END;
END;

-- Set-based version with NOCOUNT ON, computes final result using latest per subject
CREATE OR ALTER TRIGGER trg_CapNhatKetQuaTongHop
ON KetQuaChiTiet
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Danh sách KetQuaID bị ảnh hưởng bởi INSERT/UPDATE
    ;WITH affected AS (
        SELECT DISTINCT i.KetQuaID
        FROM inserted i
    ),
    -- Lấy tất cả bản ghi chi tiết kèm thông tin kỳ thi, thứ tự LanThi giảm dần
    all_ct AS (
        SELECT 
            kqt.KetQuaID,
            kqt.HoSoID,
            kqt.KyThiID,
            kqt.LanThi,
            kqct.LoaiMon,
            kqct.KetQua,
            ROW_NUMBER() OVER (PARTITION BY kqt.HoSoID, kqt.KyThiID, kqct.LoaiMon
                               ORDER BY kqt.LanThi DESC) AS rn
        FROM KetQuaChiTiet kqct
        JOIN KetQuaThi kqt ON kqt.KetQuaID = kqct.KetQuaID
    ),
    -- Chỉ giữ bản ghi mới nhất (rn = 1) cho mỗi (HoSoID, KyThiID, LoaiMon)
    latest_by_subject AS (
        SELECT HoSoID, KyThiID, LoaiMon, KetQua
        FROM all_ct
        WHERE rn = 1
    ),
    -- Pivot thành 1 hàng chứa kết quả Lý/Thực mới nhất cho mỗi (HoSoID, KyThiID)
    latest AS (
        SELECT 
            HoSoID,
            KyThiID,
            MAX(CASE WHEN LoaiMon = N'Lý thuyết' THEN KetQua END) AS KetQuaLy,
            MAX(CASE WHEN LoaiMon = N'Thực hành' THEN KetQua END) AS KetQuaThuc
        FROM latest_by_subject
        GROUP BY HoSoID, KyThiID
    )
    -- Cập nhật KetQuaThi cho những KetQuaID bị ảnh hưởng
    UPDATE kqt
    SET 
        KetQuaTongHop = CASE 
            WHEN l.KetQuaLy = N'Đạt' AND l.KetQuaThuc = N'Đạt' THEN N'Đạt'
            WHEN l.KetQuaLy IS NULL AND l.KetQuaThuc IS NULL THEN kqt.KetQuaTongHop
            ELSE N'Không đạt'
        END,
        NgayKetLuan = CASE 
            WHEN (l.KetQuaLy IS NOT NULL OR l.KetQuaThuc IS NOT NULL) THEN GETDATE()
            ELSE kqt.NgayKetLuan
        END,
        GhiChu = CASE
            WHEN l.KetQuaLy = N'Đạt' AND l.KetQuaThuc = N'Đạt' THEN N'Đạt cả 2 môn'
            WHEN l.KetQuaLy = N'Vắng' OR l.KetQuaThuc = N'Vắng' THEN N'Vắng thi'
            WHEN l.KetQuaLy IS NOT NULL AND l.KetQuaThuc IS NOT NULL AND l.KetQuaLy <> N'Đạt' AND l.KetQuaThuc <> N'Đạt' THEN N'Rớt cả 2 môn'
            WHEN l.KetQuaLy IS NOT NULL AND l.KetQuaLy <> N'Đạt' THEN N'Rớt lý thuyết'
            WHEN l.KetQuaThuc IS NOT NULL AND l.KetQuaThuc <> N'Đạt' THEN N'Rớt thực hành'
            ELSE kqt.GhiChu
        END
    FROM KetQuaThi kqt
    INNER JOIN affected a ON a.KetQuaID = kqt.KetQuaID
    LEFT JOIN latest l ON l.HoSoID = kqt.HoSoID AND l.KyThiID = kqt.KyThiID;
END;

-- Kiểm tra số lượng thí sinh đăng ký kỳ thi
DROP TRIGGER trg_KiemTraSoLuongKyThi
CREATE TRIGGER trg_KiemTraSoLuongKyThi
ON KetQuaThi
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @KyThiID INT, @SoLuongToiDa INT, @SoLuongHienTai INT;
    
    SELECT @KyThiID = KyThiID FROM inserted;
    
    SELECT @SoLuongToiDa = SoLuongToiDa FROM KyThi WHERE KyThiID = @KyThiID;
    
    SELECT @SoLuongHienTai = COUNT(*) 
    FROM KetQuaThi 
    WHERE KyThiID = @KyThiID;
    
    IF @SoLuongToiDa IS NOT NULL AND @SoLuongHienTai >= @SoLuongToiDa
    BEGIN
        RAISERROR(N'Kỳ thi đã đủ số lượng thí sinh!', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        INSERT INTO KetQuaThi (HoSoID, KyThiID, KetQuaTongHop, NgayKetLuan, LanThi, GhiChu)
        SELECT HoSoID, KyThiID, KetQuaTongHop, NgayKetLuan, LanThi, GhiChu
        FROM inserted;
    END
END;


-- Tự động tạo giấy phép khi thí sinh đạt kỳ thi
CREATE TRIGGER trg_TaoGiayPhepTuDong
ON KetQuaThi
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF UPDATE(KetQuaTongHop)
    BEGIN
        DECLARE @HoSoID INT, @MaCongDan INT, @MaHang VARCHAR(10), @KetQuaTongHop NVARCHAR(20);
        
        SELECT @HoSoID = i.HoSoID, @KetQuaTongHop = i.KetQuaTongHop
        FROM inserted i;
        
        IF @KetQuaTongHop = N'Đạt'
        BEGIN
            -- Lấy thông tin từ hồ sơ
            SELECT @MaCongDan = h.MaCongDan, @MaHang = h.MaHang
            FROM HoSo h
            WHERE h.HoSoID = @HoSoID;
            
            -- Kiểm tra chưa có giấy phép
            IF NOT EXISTS (
                SELECT 1 FROM GiayPhep 
                WHERE MaCongDan = @MaCongDan AND MaHang = @MaHang
            )
            BEGIN
                DECLARE @SoGiayPhep VARCHAR(20);
                SET @SoGiayPhep = @MaHang + FORMAT(GETDATE(), 'yyyyMMdd') + FORMAT(@MaCongDan, '0000');
                
                -- Tạo giấy phép mới
                INSERT INTO GiayPhep (MaCongDan, MaHang, SoGiayPhep, NgayCap, NgayHetHan, SoDiem, TrangThai)
                VALUES (@MaCongDan, @MaHang, @SoGiayPhep, GETDATE(), NULL, 12, N'Chờ xét duyệt');
            END
        END
    END
END;

-- Tự động tạm giữ GPLX khi điểm = 0
CREATE OR ALTER TRIGGER trg_UpdateTrangThaiGPLX
ON GiayPhep
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
	IF TRIGGER_NESTLEVEL() > 1 RETURN;
    UPDATE g
    SET g.TrangThai = N'Tạm giữ'
    FROM GiayPhep g
    INNER JOIN inserted i ON g.GiayPhepID = i.GiayPhepID
    WHERE i.SoDiem = 0
      AND g.TrangThai <> N'Tạm giữ';  -- chỉ đổi nếu chưa là tạm giữ
    UPDATE g
    SET g.TrangThai = N'Còn hiệu lực'
    FROM GiayPhep g
    INNER JOIN inserted i ON g.GiayPhepID = i.GiayPhepID
    WHERE i.SoDiem > 0
      AND g.TrangThai = N'Tạm giữ';
END;
GO


-- PROCEDURE
-- Lấy ra danh sách công dân chưa đăng ký hồ sơ
CREATE OR ALTER PROCEDURE sp_CongDan_PhuHopTheoHang
    @MaHang VARCHAR(10)  
AS
BEGIN
    SET NOCOUNT ON;

    IF (@MaHang = 'A1')
    BEGIN    
        SELECT cd.MaCongDan, cd.HoTen, cd.NgaySinh, cd.GioiTinh,
               cd.CCCD, cd.SoDienThoai, cd.DiaChi, cd.Email, cd.Anh3x4,
               cd.TinhTrangSucKhoe, cd.GiayKhamSucKhoe, cd.NgayKhamSucKhoe, cd.NgayTao
        FROM CongDan cd
        WHERE NOT EXISTS (
            SELECT 1
            FROM HoSo hs
            WHERE hs.MaCongDan = cd.MaCongDan
              AND hs.MaHang = 'A1'
        )
        ORDER BY cd.NgayTao DESC, cd.MaCongDan DESC;
        RETURN;
    END

    IF (@MaHang IN ('A','A2'))
    BEGIN
        SELECT cd.MaCongDan, cd.HoTen, cd.NgaySinh, cd.GioiTinh,
               cd.CCCD, cd.SoDienThoai, cd.DiaChi, cd.Email, cd.Anh3x4,
               cd.TinhTrangSucKhoe, cd.GiayKhamSucKhoe, cd.NgayKhamSucKhoe, cd.NgayTao
        FROM CongDan cd
        WHERE
            EXISTS (
                SELECT 1
                FROM HoSo hA1
                JOIN KetQuaThi kq ON kq.HoSoID = hA1.HoSoID
                WHERE hA1.MaCongDan = cd.MaCongDan
                  AND hA1.MaHang = 'A1'
                  AND kq.KetQuaTongHop = N'Đạt'
            )
            -- Chưa có hồ sơ cho @MaHang (A/A2)
            AND NOT EXISTS (
                SELECT 1
                FROM HoSo hs
                WHERE hs.MaCongDan = cd.MaCongDan
                  AND hs.MaHang = @MaHang
            )
        ORDER BY cd.NgayTao DESC, cd.MaCongDan DESC;
        RETURN;
    END

    -- Trường hợp khác (fallback): trả về công dân chưa có hồ sơ cho đúng hạng @MaHang
    SELECT cd.MaCongDan, cd.HoTen, cd.NgaySinh, cd.GioiTinh,
           cd.CCCD, cd.SoDienThoai, cd.DiaChi, cd.Email, cd.Anh3x4,
           cd.TinhTrangSucKhoe, cd.GiayKhamSucKhoe, cd.NgayKhamSucKhoe, cd.NgayTao
    FROM CongDan cd
    WHERE NOT EXISTS (
        SELECT 1
        FROM HoSo hs
        WHERE hs.MaCongDan = cd.MaCongDan
          AND hs.MaHang = @MaHang
    )
    ORDER BY cd.NgayTao DESC, cd.MaCongDan DESC;
END
GO

Exec sp_CongDan_PhuHopTheoHang @mahang = 'A'

-- Tự động cập nhật theo thời gian thực trạng thái của kỳ thi mỗi khi user đăng nhập
CREATE PROCEDURE sp_CapNhatTrangThaiKyThi
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE KyThi
    SET TrangThai = CASE
        WHEN GETDATE() < CAST(NgayBatDau AS DATETIME) + CAST(ISNULL(GioBatDau, '00:00:00') AS DATETIME)
            THEN N'Sắp diễn ra'
        
        WHEN GETDATE() > CAST(ISNULL(NgayKetThuc, NgayBatDau) AS DATETIME) + CAST('23:59:59' AS DATETIME)
            THEN N'Đã kết thúc'
        
        ELSE N'Đang diễn ra'
    END
    WHERE TrangThai IN (N'Sắp diễn ra', N'Đang diễn ra'); -- Chỉ cập nhật kỳ thi chưa kết thúc
END;
EXEC sp_CapNhatTrangThaiKyThi;


-- Proc cập nhật lại điểm 12 cho các GPLX bị trừ điểm và không vi phạm trong vòng 6 tháng
CREATE OR ALTER PROCEDURE sp_ResetDiemGPLX
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayHienTai DATE = GETDATE();
    UPDATE gp
    SET gp.SoDiem = 12
    FROM GiayPhep gp
    WHERE gp.SoDiem < 12 AND gp.TrangThai = N'Còn hiệu lực'
      AND NOT EXISTS (
            SELECT 1
            FROM ViPham vp
            WHERE vp.GiayPhepID = gp.GiayPhepID
              AND vp.ThoiGianViPham >= DATEADD(MONTH, -6, @NgayHienTai)  -- 6 tháng
        );
END;
GO
EXEC sp_ResetDiemGPLX;


ALTER LOGIN TrungTruc WITH PASSWORD = 'TrungTruc@123'

-- Cách xem tất cả user
USE QLGPLX;
SELECT name AS [UserName],
       type_desc AS [UserType],
       create_date,
       modify_date
FROM sys.database_principals
WHERE type IN ('S','U','G')  -- S: SQL user, U: Windows user, G: Windows group
ORDER BY name;
