USE [master]
GO
/****** Object:  Database [QLKho]    Script Date: 11/10/2015 8:55:23 AM ******/
CREATE DATABASE [QLKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKho', FILENAME = N'E:\Nam 4 ki 1\TT nhóm\QLKho\QLKho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKho_log', FILENAME = N'E:\Nam 4 ki 1\TT nhóm\QLKho\QLKho_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKho] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKho] SET  MULTI_USER 
GO
ALTER DATABASE [QLKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKho] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKho', N'ON'
GO
USE [QLKho]
GO
/****** Object:  Table [dbo].[CHITIETNHAP]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETNHAP](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CHITIETNHAP1] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETXUAT]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETXUAT](
	[MaPhieuXuat] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGiaXuat] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CHITIETXUAT_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHH] [varchar](10) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [float] NULL,
	[GiaBan] [float] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](20) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](20) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](20) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[MaNCC] [varchar](10) NULL,
	[NgayNhap] [date] NULL,
	[TongNhap] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieuXuat] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[NgayXuat] [date] NULL,
	[TongXuat] [nchar](10) NULL,
 CONSTRAINT [PK_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETNHAP] ([MaPhieuNhap], [MaHH], [SoLuong], [DonGiaNhap], [ThanhTien]) VALUES (N'1', N'1', 2, 20000, 100897)
INSERT [dbo].[CHITIETNHAP] ([MaPhieuNhap], [MaHH], [SoLuong], [DonGiaNhap], [ThanhTien]) VALUES (N'1', N'2', 35, 2143, 75005)
INSERT [dbo].[CHITIETNHAP] ([MaPhieuNhap], [MaHH], [SoLuong], [DonGiaNhap], [ThanhTien]) VALUES (N'1', N'3', 2, 123444, 246888)
INSERT [dbo].[CHITIETNHAP] ([MaPhieuNhap], [MaHH], [SoLuong], [DonGiaNhap], [ThanhTien]) VALUES (N'2', N'2', 234, 123, 28782)
INSERT [dbo].[CHITIETXUAT] ([MaPhieuXuat], [MaHH], [SoLuong], [DonGiaXuat], [ThanhTien]) VALUES (N'1', N'1', 2333, 45678, 106566774)
INSERT [dbo].[CHITIETXUAT] ([MaPhieuXuat], [MaHH], [SoLuong], [DonGiaXuat], [ThanhTien]) VALUES (N'1', N'2', 2333, 2347898, 5477646034)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [DVT], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'1', N'Áo nỉ thu đông', N'chiếc', 23245, 32456709, 45678)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [DVT], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'2', N'Áo nỉ in hình chữ', N'chiếc', 34567, 2345678, 2347898)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [DVT], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'3', N'Áo nỉ in hình báo', N'chiếc', 345, 324567, 3456789)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [GhiChu]) VALUES (N'1', N'Nguyễn Thị Dung', N'Vĩnh Phúc', N'098765124           ', N'Khách hàng quen thuộc')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [GhiChu]) VALUES (N'2', N'Trần Trung Kiên', N'Hà Nội', N'098765q3534         ', N'Khách VIP')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [GhiChu]) VALUES (N'3', N'Nguyền Hoài Thu', N'Hà Giang', N'0129375654          ', N'Khách VIP')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [GhiChu]) VALUES (N'4', N'Phan Trọng Sinh', N'Hà Nội', N'0987654             ', NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SDT], [GhiChu]) VALUES (N'5', N'Nguyễn Việt Hoa', N'Hà Tây', N'0987654345678       ', NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'1', N'Sao vàng', N'Hoàng Quốc Việt', N'09077868567         ', N'Uy tín')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'2', N'Ðông Dương', N'Bà Triệu - HN', N'978070              ', N'Uy tín')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'3', N'Hải Thịnh', N'Nam Định', N'09876235            ', N'Uy tín')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'4', N'Trung đông', N'Hà Nội', N'098678909345        ', N'Uy tín')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'5', N'Á Nam', N'Hà Nội', N'098674378           ', N'UY tín')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu]) VALUES (N'1', N'Bạch Thị Diệu Linh', N'Lạc Sơn - Hòa Bình', N'0966101314          ', N'Giám đốc')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu]) VALUES (N'2', N'Trần Thị Huyền', N'Thạch Hà - Hà Tĩnh', N'0988234567          ', N'Nhân viên')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu]) VALUES (N'3', N'Nguyễn Hòa Nhật quang', N'An Giang', N'09876567            ', N'Nhân Viên')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu]) VALUES (N'4', N'Trần Minh Nghiệp', N'Bắc Ninh', N'098765678000        ', N'Nhân Viên')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNV], [MaNCC], [NgayNhap], [TongNhap]) VALUES (N'', N'2', N'1', CAST(N'2015-11-10' AS Date), 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNV], [MaNCC], [NgayNhap], [TongNhap]) VALUES (N'1', N'1', N'1', NULL, NULL)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNV], [MaNCC], [NgayNhap], [TongNhap]) VALUES (N'2', N'2', N'2', CAST(N'2015-11-06' AS Date), 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNV], [MaNCC], [NgayNhap], [TongNhap]) VALUES (N'3', N'2', N'1', CAST(N'2015-11-06' AS Date), 0)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [MaNV], [MaKH], [NgayXuat], [TongXuat]) VALUES (N'1', N'1', N'1', NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [MaNV], [MaKH], [NgayXuat], [TongXuat]) VALUES (N'2', N'2', N'1', CAST(N'2015-11-10' AS Date), N'0         ')
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAP_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CHITIETNHAP] CHECK CONSTRAINT [FK_CHITIETNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETNHAP1_PHIEUNHAP] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETNHAP] CHECK CONSTRAINT [FK_CHITIETNHAP1_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETXUAT_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CHITIETXUAT] CHECK CONSTRAINT [FK_CHITIETXUAT_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETXUAT_PHIEUXUAT1] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[CHITIETXUAT] CHECK CONSTRAINT [FK_CHITIETXUAT_PHIEUXUAT1]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[Add_CTN]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Add_CTN] @MaPhieuNhap varchar(10),  @MaHH varchar(10), @SoLuong int, @DonGiaNhap float,@ThanhTien float
 as
 begin

	set @ThanhTien = @DonGiaNhap*@SoLuong
Insert into CHITIETNHAP values(@MaPhieuNhap,@MaHH,@SoLuong,@DonGiaNhap,@ThanhTien)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_CTX]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_CTX] @MaPhieuXuat varchar(10),  @MaHH varchar(10), @SoLuong int, @DonGiaXuat float,@ThanhTien float
 as
 begin

	set @ThanhTien = @DonGiaXuat*@SoLuong
Insert into CHITIETXUAT values(@MaPhieuXuat,@MaHH,@SoLuong,@DonGiaXuat,@ThanhTien)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_PN]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[Add_PN] @MaPhieuNhap varchar(10),  @MaNV varchar(10), @MaNCC int, @NgayNhap datetime,@TongNhap float
 as
 begin
Insert into PHIEUNHAP values(@MaPhieuNhap,@MaNV,@MaNCC,@NgayNhap,@TongNhap)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_PX]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[Add_PX] @MaPhieuXuat varchar(10),  @MaNV varchar(10), @MaKH int, @NgayXuat datetime,@TongXuat float
 as
 begin
Insert into PHIEUXUAT values(@MaPhieuXuat,@MaNV,@MaKH,@NgayXuat,@TongXuat)
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_CTN]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Sho_CTN] 
as
begin
	select * from ChiTietNhap
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_CTX]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Sho_CTX] 
as
begin
	select * from CHITIETXUAT
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_HH]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Sho_HH] 
as
begin
	select * from HANGHOA
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_KH]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Sho_KH] 
as
begin
	select * from KHACHHANG
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_NCC]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Sho_NCC] 
as
begin
	select * from NHACUNGCAP
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_NV]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Sho_KH]    Script Date: 11/4/2015 8:47:48 AM ******/

create proc [dbo].[Sho_NV] 
as
begin
	select * from NHANVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_PN]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Sho_PN] 
as
begin
	select * from PHIEUNHAP
end
GO
/****** Object:  StoredProcedure [dbo].[Sho_PX]    Script Date: 11/10/2015 8:55:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Sho_PX] 
as
begin
	select * from PHIEUXUAT
end
GO
USE [master]
GO
ALTER DATABASE [QLKho] SET  READ_WRITE 
GO
