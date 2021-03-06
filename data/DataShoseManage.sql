USE [master]
GO
/****** Object:  Database [DoAnNet]    Script Date: 3/21/2021 7:49:03 PM ******/
CREATE DATABASE [DoAnNet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAnNet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DoAnNet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DoAnNet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DoAnNet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DoAnNet] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAnNet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAnNet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAnNet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAnNet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAnNet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAnNet] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAnNet] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DoAnNet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAnNet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAnNet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAnNet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAnNet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAnNet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAnNet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAnNet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAnNet] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DoAnNet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAnNet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAnNet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAnNet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAnNet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAnNet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAnNet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAnNet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoAnNet] SET  MULTI_USER 
GO
ALTER DATABASE [DoAnNet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAnNet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAnNet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAnNet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DoAnNet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DoAnNet] SET QUERY_STORE = OFF
GO
USE [DoAnNet]
GO
/****** Object:  Rule [ngay]    Script Date: 3/21/2021 7:49:09 PM ******/
CREATE RULE [dbo].[ngay] 
AS
@ngay>'1990-1-1'
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaNV] [int] NOT NULL,
	[NgayCham] [date] NULL,
	[Cham] [bit] NOT NULL,
 CONSTRAINT [khoa_chinh] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[Cham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
	[MucLuong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDonHang]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDonHang](
	[MaDonHang] [int] NULL,
	[MaCTDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaCTSp] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaTien] [float] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaPhieuNhap] [int] NULL,
	[MaCTPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaCTSp] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [float] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTSanPham]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSanPham](
	[MaSp] [int] NULL,
	[MaCTSp] [int] IDENTITY(1,1) NOT NULL,
	[KichCo] [float] NULL,
	[MaSac] [nvarchar](50) NULL,
	[ChatLieu] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [float] NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NULL,
	[NgayMua] [date] NULL,
	[SoLuong] [int] NULL,
	[TongTien] [float] NULL,
	[MaNV] [int] NULL,
	[MaLoHang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SoDienThoai] [float] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaLoHang] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaPhieuNhap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[ThuongHieu] [nvarchar](50) NULL,
	[MaLoHang] [int] NULL,
	[SoLuong] [int] NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNcc] [int] IDENTITY(1,1) NOT NULL,
	[TenNcc] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [float] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[MaChucVu] [int] NULL,
	[TinhTrang] [bit] NULL,
	[TongNgayCong] [int] NULL,
	[Luong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaNcc] [int] NULL,
	[SoLuong] [int] NULL,
	[TongTien] [float] NULL,
	[NgayNhap] [date] NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPhieuXuat] [int] IDENTITY(1,1) NOT NULL,
	[MaDonHang] [int] NULL,
	[NgayXuat] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaLoai] [int] NULL,
	[MaSp] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](90) NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongKe]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongKe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TongNhap] [float] NULL,
	[TongXuat] [float] NULL,
	[SanPhamTon] [nvarchar](max) NULL,
	[SanPhamBanChay] [nvarchar](max) NULL,
	[Thang] [int] NULL,
	[DoanhThu] [float] NULL,
	[SoLuongNhap] [int] NULL,
	[SoLuongXuat] [int] NULL,
	[SoLuongDonHang] [int] NULL,
 CONSTRAINT [PK_ThongKe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[CTDonHang]  WITH CHECK ADD FOREIGN KEY([MaCTSp])
REFERENCES [dbo].[CTSanPham] ([MaCTSp])
GO
ALTER TABLE [dbo].[CTDonHang]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaCTSp])
REFERENCES [dbo].[CTSanPham] ([MaCTSp])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaSp])
REFERENCES [dbo].[SanPham] ([MaSp])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaLoHang])
REFERENCES [dbo].[KhoHang] ([MaLoHang])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[LoaiSanPham]  WITH CHECK ADD FOREIGN KEY([MaLoHang])
REFERENCES [dbo].[KhoHang] ([MaLoHang])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNcc])
REFERENCES [dbo].[NhaCungCap] ([MaNcc])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
/****** Object:  StoredProcedure [dbo].[capnhat_doanhthu_ban]    Script Date: 3/21/2021 7:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[capnhat_doanhthu_ban]
as
begin 
	update ThongKe
	set TongXuat = (SELECT SUM(TongTien) from DonHang where MONTH(DonHang.NgayMua) = thang)
end
GO
/****** Object:  StoredProcedure [dbo].[capnhat_sanpham_bancham]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[capnhat_sanpham_bancham]
as
begin 
	update ThongKe
	set SanPhamTon = (select top(1) SanPham.TenSanPham 
						  from SanPham,CTSanPham,CTDonHang,DonHang
						  where SanPham.MaSp = CTSanPham.MaCTSp and
								CTDonHang.MaCTSp = CTSanPham.MaCTSp and
								DonHang.MaDonHang = CTDonHang.MaDonHang and
								MONTH(DonHang.NgayMua) = Thang
						  group by SanPham.TenSanPham 
						  having count(CTDonHang.MaCTSp) <=  all(select count(CTDonHang.MaCTSp) from CTDonHang,CTSanPham
																								where CTDonHang.MaCTSp =  CTSanPham.MaCTSp
																								group by CTDonHang.MaCTSp)
						  )
end
GO
/****** Object:  StoredProcedure [dbo].[capnhat_sanpham_banchay]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[capnhat_sanpham_banchay]
as
begin 
	update ThongKe
	set SanPhamBanChay = (select top(1) SanPham.TenSanPham 
						 from SanPham,CTSanPham,CTDonHang,DonHang
						  where SanPham.MaSp = CTSanPham.MaCTSp and
								CTDonHang.MaCTSp = CTSanPham.MaCTSp and
								DonHang.MaDonHang = CTDonHang.MaDonHang and
								MONTH(DonHang.NgayMua) = Thang
						  group by SanPham.TenSanPham 
						  having count(CTDonHang.MaCTSp)>=  all(select count(CTDonHang.MaCTSp) from CTDonHang,CTSanPham
																								where CTDonHang.MaCTSp =  CTSanPham.MaCTSp
																								group by CTDonHang.MaCTSp)
						  )
end
GO
/****** Object:  StoredProcedure [dbo].[capnhat_soluong_ban]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[capnhat_soluong_ban]
as
begin 
	update ThongKe
	set SoLuongXuat = (SELECT SUM(SoLuong) from DonHang where MONTH(DonHang.NgayMua) = thang)
end
GO
/****** Object:  StoredProcedure [dbo].[capnhat_tong_doanhthu]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[capnhat_tong_doanhthu]
as
begin
	update ThongKe
	set DoanhThu = TongXuat - TongNhap
end
GO
/****** Object:  StoredProcedure [dbo].[thongke_doanhthu_nhap]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[thongke_doanhthu_nhap]
as
begin 
	update ThongKe 
	SET TongNhap = (select sum(TongTien) from PhieuNhap WHERE MONTH(PhieuNhap.NgayNhap)=Thang)
end
GO
/****** Object:  StoredProcedure [dbo].[thongke_sanpham_nhap]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[thongke_sanpham_nhap]
as
begin 
	update ThongKe 
	SET SoLuongNhap = (select sum(SoLuong) from PhieuNhap WHERE MONTH(PhieuNhap.NgayNhap)=Thang)
end
GO
/****** Object:  StoredProcedure [dbo].[tong_hoadon]    Script Date: 3/21/2021 7:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[tong_hoadon]
as
begin
	update ThongKe
	set SoLuongDonHang = (select COUNT(*) from DonHang WHERE MONTH(DonHang.NgayMua) = thang)
end
GO
USE [master]
GO
ALTER DATABASE [DoAnNet] SET  READ_WRITE 
GO
