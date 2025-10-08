using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public partial class QLGPLXContext : DbContext
{
    public QLGPLXContext()
    {
    }

    public QLGPLXContext(DbContextOptions<QLGPLXContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CanBo> CanBos { get; set; }

    public virtual DbSet<CanBoHoSo> CanBoHoSos { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<CongDan> CongDans { get; set; }

    public virtual DbSet<GiayPhep> GiayPheps { get; set; }

    public virtual DbSet<HangGiayPhep> HangGiayPheps { get; set; }

    public virtual DbSet<HoSo> HoSos { get; set; }

    public virtual DbSet<KetQuaChiTiet> KetQuaChiTiets { get; set; }

    public virtual DbSet<KetQuaThi> KetQuaThis { get; set; }

    public virtual DbSet<KyThi> KyThis { get; set; }

    public virtual DbSet<LoaiViPham> LoaiViPhams { get; set; }

    public virtual DbSet<ViPham> ViPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-39G03JV\\SQLEXPRESS;Initial Catalog=QLGPLX;User ID=sa;Password=123456789;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CanBo>(entity =>
        {
            entity.HasKey(e => e.MaCanBo).HasName("PK__CanBo__4003E21544B1E269");

            entity.ToTable("CanBo");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.CanBos)
                .HasForeignKey(d => d.MaChucVu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CanBo__MaChucVu__1B9317B3");
        });

        modelBuilder.Entity<CanBoHoSo>(entity =>
        {
            entity.HasKey(e => new { e.MaCanBo, e.HoSoId, e.ThoiGian }).HasName("PK__CanBo_Ho__0732DEB83567FA19");

            entity.ToTable("CanBo_HoSo");

            entity.Property(e => e.HoSoId).HasColumnName("HoSoID");
            entity.Property(e => e.ThoiGian)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TrangThaiDuyet).HasMaxLength(50);

            entity.HasOne(d => d.HoSo).WithMany(p => p.CanBoHoSos)
                .HasForeignKey(d => d.HoSoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CanBo_HoS__HoSoI__214BF109");

            entity.HasOne(d => d.MaCanBoNavigation).WithMany(p => p.CanBoHoSos)
                .HasForeignKey(d => d.MaCanBo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CanBo_HoS__MaCan__2057CCD0");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaChucVu).HasName("PK__ChucVu__D463953365D2FD89");

            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.TenChucVu, "UQ__ChucVu__A7E2123E53D946C6").IsUnique();

            entity.Property(e => e.TenChucVu).HasMaxLength(50);
        });

        modelBuilder.Entity<CongDan>(entity =>
        {
            entity.HasKey(e => e.MaCongDan).HasName("PK__CongDan__4183A0263C11E818");

            entity.ToTable("CongDan");

            entity.HasIndex(e => e.SoDienThoai, "UQ__CongDan__0389B7BDF110EE0A").IsUnique();

            entity.HasIndex(e => e.Cccd, "UQ__CongDan__A955A0AA4D1EFAF8").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__CongDan__A9D1053423DEB215").IsUnique();

            entity.Property(e => e.Anh3x4).HasMaxLength(255);
            entity.Property(e => e.Cccd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GiayKhamSucKhoe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TinhTrangSucKhoe)
                .HasMaxLength(50)
                .HasDefaultValue("Khỏe mạnh");
        });

        modelBuilder.Entity<GiayPhep>(entity =>
        {
            entity.HasKey(e => e.GiayPhepId).HasName("PK__GiayPhep__8DD5F3DC4FB43304");

            entity.ToTable("GiayPhep");

            entity.HasIndex(e => new { e.MaCongDan, e.MaHang }, "UQ_GPLX_OnePerHang").IsUnique();

            entity.HasIndex(e => e.SoGiayPhep, "UQ__GiayPhep__290F8525E385C46F").IsUnique();

            entity.Property(e => e.GiayPhepId).HasColumnName("GiayPhepID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MaHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SoDiem).HasDefaultValue(12);
            entity.Property(e => e.SoGiayPhep)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .HasDefaultValue("Còn hiệu lực");

            entity.HasOne(d => d.MaCongDanNavigation).WithMany(p => p.GiayPheps)
                .HasForeignKey(d => d.MaCongDan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GiayPhep__MaCong__76619304");

            entity.HasOne(d => d.MaHangNavigation).WithMany(p => p.GiayPheps)
                .HasForeignKey(d => d.MaHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GiayPhep__MaHang__7755B73D");
        });

        modelBuilder.Entity<HangGiayPhep>(entity =>
        {
            entity.HasKey(e => e.MaHang).HasName("PK__HangGiay__19C0DB1D4C123681");

            entity.ToTable("HangGiayPhep");

            entity.Property(e => e.MaHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiemDatLyThuyet).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DiemDatThucHanh).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DoTuoiToiThieu).HasDefaultValue(18);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.TenHang).HasMaxLength(50);
        });

        modelBuilder.Entity<HoSo>(entity =>
        {
            entity.HasKey(e => e.HoSoId).HasName("PK__HoSo__A9F1AA18B4880AA2");

            entity.ToTable("HoSo");

            entity.HasIndex(e => e.MaCongDan, "IX_HoSo_CongDan");

            entity.Property(e => e.HoSoId).HasColumnName("HoSoID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MaHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayNop).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .HasDefaultValue("Đang xử lý");

            entity.HasOne(d => d.MaCongDanNavigation).WithMany(p => p.HoSos)
                .HasForeignKey(d => d.MaCongDan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoSo__MaCongDan__5BAD9CC8");

            entity.HasOne(d => d.MaHangNavigation).WithMany(p => p.HoSos)
                .HasForeignKey(d => d.MaHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoSo__MaHang__5CA1C101");
        });

        modelBuilder.Entity<KetQuaChiTiet>(entity =>
        {
            entity.HasKey(e => e.ChiTietId).HasName("PK__KetQuaCh__B117E9EA45EE62E7");

            entity.ToTable("KetQuaChiTiet");

            entity.HasIndex(e => new { e.KetQuaId, e.LoaiMon }, "UQ_KetQuaChiTiet").IsUnique();

            entity.Property(e => e.ChiTietId).HasColumnName("ChiTietID");
            entity.Property(e => e.Diem).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.KetQua).HasMaxLength(20);
            entity.Property(e => e.KetQuaId).HasColumnName("KetQuaID");
            entity.Property(e => e.LoaiMon).HasMaxLength(20);
            entity.Property(e => e.ThoiGianBatDau).HasColumnType("datetime");

            entity.HasOne(d => d.KetQuaNavigation).WithMany(p => p.KetQuaChiTiets)
                .HasForeignKey(d => d.KetQuaId)
                .HasConstraintName("FK__KetQuaChi__KetQu__6FB49575");
        });

        modelBuilder.Entity<KetQuaThi>(entity =>
        {
            entity.HasKey(e => e.KetQuaId).HasName("PK__KetQuaTh__0CFF02632502BA45");

            entity.ToTable("KetQuaThi");

            entity.HasIndex(e => new { e.HoSoId, e.KyThiId, e.LanThi }, "UQ_KetQuaThi").IsUnique();

            entity.Property(e => e.KetQuaId).HasColumnName("KetQuaID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.HoSoId).HasColumnName("HoSoID");
            entity.Property(e => e.KetQuaTongHop).HasMaxLength(20);
            entity.Property(e => e.KyThiId).HasColumnName("KyThiID");
            entity.Property(e => e.LanThi).HasDefaultValue(1);
            entity.Property(e => e.NgayKetLuan)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.HoSo).WithMany(p => p.KetQuaThis)
                .HasForeignKey(d => d.HoSoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQuaThi__HoSoI__681373AD");

            entity.HasOne(d => d.KyThi).WithMany(p => p.KetQuaThis)
                .HasForeignKey(d => d.KyThiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQuaThi__KyThi__690797E6");
        });

        modelBuilder.Entity<KyThi>(entity =>
        {
            entity.HasKey(e => e.KyThiId).HasName("PK__KyThi__3C6526B91325ED89");

            entity.ToTable("KyThi");

            entity.Property(e => e.KyThiId).HasColumnName("KyThiID");
            entity.Property(e => e.DiaDiem).HasMaxLength(255);
            entity.Property(e => e.GioBatDau).HasPrecision(0);
            entity.Property(e => e.MaHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenKyThi).HasMaxLength(150);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .HasDefaultValue("Sắp diễn ra");

            entity.HasOne(d => d.MaHangNavigation).WithMany(p => p.KyThis)
                .HasForeignKey(d => d.MaHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KyThi__MaHang__634EBE90");
        });

        modelBuilder.Entity<LoaiViPham>(entity =>
        {
            entity.HasKey(e => e.LoaiViPhamId).HasName("PK__LoaiViPh__5378BA5B7CD88EE4");

            entity.ToTable("LoaiViPham");

            entity.Property(e => e.LoaiViPhamId).HasColumnName("LoaiViPhamID");
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.MucPhatDen).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MucPhatTu).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TenViPham).HasMaxLength(255);
        });

        modelBuilder.Entity<ViPham>(entity =>
        {
            entity.HasKey(e => e.ViPhamId).HasName("PK__ViPham__CF3C3E5DD10A6B47");

            entity.ToTable("ViPham");

            entity.Property(e => e.ViPhamId).HasColumnName("ViPhamID");
            entity.Property(e => e.BienKiemSoat).HasMaxLength(20);
            entity.Property(e => e.DiaDiem).HasMaxLength(255);
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GiayPhepId).HasColumnName("GiayPhepID");
            entity.Property(e => e.LoaiViPhamId).HasColumnName("LoaiViPhamID");
            entity.Property(e => e.MucPhat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ThoiGianViPham)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .HasDefaultValue("Chưa xử lý");

            entity.HasOne(d => d.GiayPhep).WithMany(p => p.ViPhams)
                .HasForeignKey(d => d.GiayPhepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ViPham__GiayPhep__7FEAFD3E");

            entity.HasOne(d => d.LoaiViPham).WithMany(p => p.ViPhams)
                .HasForeignKey(d => d.LoaiViPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ViPham__LoaiViPh__00DF2177");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
