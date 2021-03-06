USE [MiniMarket_DB]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Lương thực thực phẩm')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Thời trang')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Điện tử gia dụng')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Văn phòng phẩm')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Hóa mỹ phẩm')
SET IDENTITY_INSERT [dbo].[Category] OFF
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
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhoneNumber]) VALUES (1, N'Default cusomer', N'0123456789')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhoneNumber]) VALUES (2, N'Khách hàng 01', N'0987654321')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerPhoneNumber]) VALUES (5, N'Đỗ Thị Minh Trang', N'0909112233')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Password]) VALUES (1, N'Nhân viên 01', N'123456')
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Password]) VALUES (2, N'Nhân viên 02', N'123456')
SET IDENTITY_INSERT [dbo].[Employee] OFF
