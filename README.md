USE [master]
GO
/****** Object:  Database [Demo_QuanLyCafe]    Script Date: 21/09/2022 12:40:41 PM ******/
CREATE DATABASE [Demo_QuanLyCafe]
 
GO
USE [Demo_QuanLyCafe]
GO
/****** Object:  Table [dbo].[BanCafe]    Script Date: 21/09/2022 12:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanCafe](
	[MaSoBan] [int] IDENTITY(1,1) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_BanCafe] PRIMARY KEY CLUSTERED 
(
	[MaSoBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 21/09/2022 12:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHD] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NULL,
	[MaMon] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 21/09/2022 12:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nchar](10) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/09/2022 12:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime] NULL,
	[MaNhanVien] [int] NULL,
	[MaSoBan] [int] NULL,
	[TongTien] [float] NULL,
	[GiamGia] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 21/09/2022 12:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[MaMon] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MaDanhMuc] [int] NULL,
	[GiaTien] [float] NULL,
 CONSTRAINT [PK_Mon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/09/2022 12:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[MatKhau] [varchar](500) NULL,
	[TenDangNhap] [varchar](100) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanCafe] ON 

INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (1, N'Bàn Gỗ')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (2, N'Bàn tre mây 1')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (3, N'Bàn Đá 1')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (4, N'Bàn Đá 2')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (5, N'Bàn Đá 3')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (6, N'Vườn Tre')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (7, N'Bàn Kính 1')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (8, N'Bàn Kính 2')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (9, N'Bàn mây 1')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (10, N'Bàn mây 2')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (11, N'Bàn mây 3')
INSERT [dbo].[BanCafe] ([MaSoBan], [TenBan]) VALUES (12, N'Bàn view Sông')
SET IDENTITY_INSERT [dbo].[BanCafe] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([MaDanhMuc], [Ten]) VALUES (1, N'Nước Uống ')
INSERT [dbo].[DanhMuc] ([MaDanhMuc], [Ten]) VALUES (2, N'Cafe      ')
INSERT [dbo].[DanhMuc] ([MaDanhMuc], [Ten]) VALUES (3, N'Sinh tố   ')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[Mon] ON 

INSERT [dbo].[Mon] ([MaMon], [Ten], [MaDanhMuc], [GiaTien]) VALUES (1, N'Cafe đen', 2, 12000000)
INSERT [dbo].[Mon] ([MaMon], [Ten], [MaDanhMuc], [GiaTien]) VALUES (2, N'Cafe sữa', 2, 15000000)
INSERT [dbo].[Mon] ([MaMon], [Ten], [MaDanhMuc], [GiaTien]) VALUES (3, N'Nước suối', 1, 10000000)
INSERT [dbo].[Mon] ([MaMon], [Ten], [MaDanhMuc], [GiaTien]) VALUES (4, N'Coca', 1, 12000000)
INSERT [dbo].[Mon] ([MaMon], [Ten], [MaDanhMuc], [GiaTien]) VALUES (5, N'Sinh tố bơ', 3, 20000000)
SET IDENTITY_INSERT [dbo].[Mon] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon1] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon1]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Mon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[Mon] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Mon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_BanCafe] FOREIGN KEY([MaSoBan])
REFERENCES [dbo].[BanCafe] ([MaSoBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_BanCafe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[Mon]  WITH CHECK ADD  CONSTRAINT [FK_Mon_DanhMuc] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[Mon] CHECK CONSTRAINT [FK_Mon_DanhMuc]
GO
USE [master]
GO
ALTER DATABASE [Demo_QuanLyCafe] SET  READ_WRITE 
GO
