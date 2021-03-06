USE [master]
GO
/****** Object:  Database [MiniMarket_DB]    Script Date: 7/26/2019 9:30:38 PM ******/
CREATE DATABASE [MiniMarket_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniMarket_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MiniMarket_DB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MiniMarket_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MiniMarket_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MiniMarket_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniMarket_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniMarket_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniMarket_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniMarket_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiniMarket_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniMarket_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [MiniMarket_DB] SET  MULTI_USER 
GO
ALTER DATABASE [MiniMarket_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniMarket_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniMarket_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniMarket_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MiniMarket_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MiniMarket_DB', N'ON'
GO
USE [MiniMarket_DB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/26/2019 9:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/26/2019 9:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](128) NOT NULL,
	[CustomerPhoneNumber] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 7/26/2019 9:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](128) NOT NULL,
	[Password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/26/2019 9:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[TotalPrice] [int] NULL,
	[CustomerID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 7/26/2019 9:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[SalingPrice] [int] NOT NULL,
	[SalingQuantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/26/2019 9:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](128) NOT NULL,
	[Price] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Image] [nvarchar](128) NULL,
	[IsDelete] [bit] NOT NULL CONSTRAINT [DF_Product_IsDelete]  DEFAULT ((0)),
	[CategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Lương thực thực phẩm')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Thời trang')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Điện tử gia dụng')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Văn phòng phẩm')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Hóa mỹ phẩm')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhoneNumber]) VALUES (1, N'Default cusomer', N'0123456789')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhoneNumber]) VALUES (2, N'Khách hàng 01', N'0987654321')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhoneNumber]) VALUES (5, N'Đỗ Thị Minh Trang', N'0909112233')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Password]) VALUES (1, N'Nhân viên 01', N'123456')
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Password]) VALUES (2, N'Nhân viên 02', N'123456')
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (1, N'Tảo cuộn cơm Shushi', 32000, 100, N'Product001.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (2, N'Gạo Jasmine', 58000, 200, N'Product002.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (3, N'Gạo Hạt ngọc trời Thiên Long', 103800, 100, N'Product003.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (4, N'Gạo Giống Nhật Coop', 125000, 100, N'Product004.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (5, N'Nem nướng Cầu Tre', 65000, 200, N'Product005.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (6, N'Cá hồi phi lê Hải Nam', 92900, 150, N'Product006.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (7, N'Kem cao cấp Calano', 98000, 100, N'Product007.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (8, N'Xúc xích heo xông khối', 71900, 150, N'Product008.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (9, N'Sữa chua Lif Kun', 27300, 200, N'Product009.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (10, N'Sữa Yayourt Long Thành', 42800, 250, N'Product010.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (11, N'Kim chi cải thảo Bibigo', 12500, 250, N'Product011.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (12, N'Cá hồi cắt thỏi Amigo', 102300, 100, N'Product012.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (13, N'Coca Cola Light', 9500, 300, N'Product013.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (14, N'Sting dâu', 8900, 300, N'Product014.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (15, N'Trà xanh Macha Tea+', 6600, 300, N'Product015.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (16, N'Bia Heniken lon', 18500, 300, N'Product016.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (17, N'Bia Desperados', 18500, 300, N'Product017.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (18, N'Bia Tiger Crystal lon', 16000, 300, N'Product018.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (19, N'Đầm mùa hè cotton cho bé gái', 69000, 20, N'Product019.jpg', 0, 2)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (20, N'Áo bác sĩ tay ngắn Bossini', 12500, 20, N'Product020.jpg', 0, 2)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (21, N'Kẹo bạc hà', 15000, 30, N'Product021.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (22, N'Kinh Đô Sandwich', 6000, 20, N'Product022.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (23, N'Bánh Quế Chocolate', 10000, 30, N'Product023.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (24, N'Bánh Quế kem dâu', 10000, 30, N'Product024.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (25, N'Chao dinh dưỡng tôm rông biển', 19000, 20, N'Product025.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (26, N'Bánh phồng tôm không cay', 5000, 30, N'Product026.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (27, N'Đường phèn', 28000, 30, N'Product027.jpg', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Quantity], [Image], [IsDelete], [CategoryID]) VALUES (28, N'Sầu riêng xấy lạnh', 44000, 30, N'Product028.jpg', 0, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [MiniMarket_DB] SET  READ_WRITE 
GO
