using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WepApp.Models
{
    public partial class covid19Context : DbContext
    {
        public covid19Context()
        {
        }

        public covid19Context(DbContextOptions<covid19Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CtHoadon> CtHoadons { get; set; }
        public virtual DbSet<Danhmuc> Danhmucs { get; set; }
        public virtual DbSet<Dantoc> Dantocs { get; set; }
        public virtual DbSet<Gopy> Gopies { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Hoso> Hosos { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Lienhe> Lienhes { get; set; }
        public virtual DbSet<Loaitk> Loaitks { get; set; }
        public virtual DbSet<Quoctich> Quoctiches { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<Tokhai> Tokhais { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BTJRTTO;Initial Catalog=covid19;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CtHoadon>(entity =>
            {
                entity.HasKey(e => new { e.Masp, e.Mdhd })
                    .HasName("PK__CT_HOADO__518DC7BD85FB8862");

                entity.ToTable("CT_HOADON");

                entity.Property(e => e.Masp).HasColumnName("MASP");

                entity.Property(e => e.Mdhd).HasColumnName("MDHD");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.CtHoadons)
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CT_HOADON__MASP__3D5E1FD2");

                entity.HasOne(d => d.MdhdNavigation)
                    .WithMany(p => p.CtHoadons)
                    .HasForeignKey(d => d.Mdhd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CT_HOADON__MDHD__3E52440B");
            });

            modelBuilder.Entity<Danhmuc>(entity =>
            {
                entity.HasKey(e => e.Madm)
                    .HasName("PK__DANHMUC__603F005CC88084FD");

                entity.ToTable("DANHMUC");

                entity.Property(e => e.Madm)
                    .ValueGeneratedNever()
                    .HasColumnName("MADM");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(50)
                    .HasColumnName("TENDM");
            });

            modelBuilder.Entity<Dantoc>(entity =>
            {
                entity.HasKey(e => e.Madt)
                    .HasName("PK__DANTOC__603F005BDF06D42A");

                entity.ToTable("DANTOC");

                entity.Property(e => e.Madt)
                    .ValueGeneratedNever()
                    .HasColumnName("MADT");

                entity.Property(e => e.Tendt)
                    .HasMaxLength(30)
                    .HasColumnName("TENDT");
            });

            modelBuilder.Entity<Gopy>(entity =>
            {
                entity.HasKey(e => e.Magy)
                    .HasName("PK__GOPY__603F38B2448F24D6");

                entity.ToTable("GOPY");

                entity.Property(e => e.Magy)
                    .ValueGeneratedNever()
                    .HasColumnName("MAGY");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NOIDUNG")
                    .IsFixedLength(true);

                entity.Property(e => e.Tinhtrang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TINHTRANG")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Gopies)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GOPY__MAKH__3C69FB99");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mdhd)
                    .HasName("PK__HOADON__1AF4D8F293F2ABE6");

                entity.ToTable("HOADON");

                entity.Property(e => e.Mdhd)
                    .ValueGeneratedNever()
                    .HasColumnName("MDHD");

                entity.Property(e => e.Diachinhan)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHINHAN");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLAP");

                entity.Property(e => e.Nguoinhan)
                    .HasMaxLength(40)
                    .HasColumnName("NGUOINHAN");

                entity.Property(e => e.Sdtnhan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDTNHAN")
                    .IsFixedLength(true);

                entity.Property(e => e.Tongtien)
                    .HasColumnType("money")
                    .HasColumnName("TONGTIEN");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__MAKH__3B75D760");
            });

            modelBuilder.Entity<Hoso>(entity =>
            {
                entity.HasKey(e => e.Mahs)
                    .HasName("PK__HOSO__603F20DD13578A4B");

                entity.ToTable("HOSO");

                entity.Property(e => e.Mahs)
                    .ValueGeneratedNever()
                    .HasColumnName("MAHS");

                entity.Property(e => e.Khuvuc)
                    .HasMaxLength(100)
                    .HasColumnName("KHUVUC");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYLAP");

                entity.Property(e => e.Tinhtrang).HasColumnName("TINHTRANG");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Hosos)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOSO__MAKH__398D8EEE");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makh)
                    .HasName("PK__KHACHHAN__603F592CE5C317AA");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMND")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(5)
                    .HasColumnName("GIOITINH");

                entity.Property(e => e.Madt).HasColumnName("MADT");

                entity.Property(e => e.Maloaitk).HasColumnName("MALOAITK");

                entity.Property(e => e.Maqt).HasColumnName("MAQT");

                entity.Property(e => e.Mk)
                    .HasMaxLength(20)
                    .HasColumnName("MK");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(40)
                    .HasColumnName("TENKH");

                entity.Property(e => e.Tk)
                    .HasMaxLength(20)
                    .HasColumnName("TK");

                entity.HasOne(d => d.MadtNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Madt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KHACHHANG__MADT__4222D4EF");

                entity.HasOne(d => d.MaloaitkNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Maloaitk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KHACHHANG__MALOA__403A8C7D");

                entity.HasOne(d => d.MaqtNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Maqt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KHACHHANG__MAQT__412EB0B6");
            });

            modelBuilder.Entity<Lienhe>(entity =>
            {
                entity.HasKey(e => e.Malh)
                    .HasName("PK__LIENHE__603F414D57ADDD57");

                entity.ToTable("LIENHE");

                entity.Property(e => e.Malh).HasColumnName("MALH");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Facebook)
                    .HasMaxLength(255)
                    .HasColumnName("FACEBOOK");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Loaitk>(entity =>
            {
                entity.HasKey(e => e.Maloaitk)
                    .HasName("PK__LOAITK__AFC8E595787EE494");

                entity.ToTable("LOAITK");

                entity.Property(e => e.Maloaitk)
                    .ValueGeneratedNever()
                    .HasColumnName("MALOAITK");

                entity.Property(e => e.Tenloaitk)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TENLOAITK")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Quoctich>(entity =>
            {
                entity.HasKey(e => e.Maqt)
                    .HasName("PK__QUOCTICH__602379EC43F6FDC1");

                entity.ToTable("QUOCTICH");

                entity.Property(e => e.Maqt)
                    .ValueGeneratedNever()
                    .HasColumnName("MAQT");

                entity.Property(e => e.Tenqt)
                    .HasMaxLength(50)
                    .HasColumnName("TENQT");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PK__SANPHAM__60228A32823F718D");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.Masp)
                    .ValueGeneratedNever()
                    .HasColumnName("MASP");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Madm).HasColumnName("MADM");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(50)
                    .HasColumnName("TENSP");

                entity.HasOne(d => d.MadmNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Madm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MADM__440B1D61");
            });

            modelBuilder.Entity<Tokhai>(entity =>
            {
                entity.HasKey(e => e.Matokhai)
                    .HasName("PK__TOKHAI__D056C0E8DBF66DE8");

                entity.ToTable("TOKHAI");

                entity.Property(e => e.Matokhai)
                    .ValueGeneratedNever()
                    .HasColumnName("MATOKHAI");

                entity.Property(e => e.Dinhungdau)
                    .HasMaxLength(100)
                    .HasColumnName("DINHUNGDAU");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Nguoicobieuhien).HasColumnName("NGUOICOBIEUHIEN");

                entity.Property(e => e.Trieuchung)
                    .HasMaxLength(100)
                    .HasColumnName("TRIEUCHUNG");

                entity.Property(e => e.Txnguoibenh).HasColumnName("TXNGUOIBENH");

                entity.Property(e => e.Txnguoinuocbenh).HasColumnName("TXNGUOINUOCBENH");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Tokhais)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOKHAI__MAKH__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
