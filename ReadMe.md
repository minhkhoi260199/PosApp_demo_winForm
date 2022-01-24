## Project - POS (Point of Sale)
- Thiết kế một phần mềm bán hàng tại các cửa hàng tiện lợi (POS = POINT OF SALE)
- UI 

![image](https://i.pinimg.com/736x/71/31/fb/7131fbc2a64853ccdf5490e4df85ab89--design-ui-interface-design.jpg)

- Databse:
    * Employee(__EmployeeID__, EmployeeName, Password)
    * Customer(__CustomerID__, CustomerName, CustomerPhoneNumber)
    * Category(__CategoryID__, CategoryName)
    * Product(__ProductID__, ProductName, Price, Quantity, Image, *CategoryID*, IsDelete)
    * Order(__OderID__, CreatedAt, TotalPrice, *CustomerID*, *EmployeeID*)
    * OrderDetail(__OderDetailID__, *OrderID*, *ProductID*, SalingPrice, SalingQuantity)

![image](\Database_Design.png)

## Project
### Project info
- Công nghệ: Windows Form & .Net Framework (version 4.7.2) & C#
- Cơ sở dữ liệu: SQL Server (version SQL SERVER 2014)
### Phân hệ
- Phân hệ nhân viên:
    - Đăng nhập
    - Hiển thị danh sách
    - Xem chi tiết thông tin sản phẩm
    - Tìm kiếm thông tin sản phẩm
    - Tạo hóa đơn bán hàng (Đặt hàng, cập nhật thông tin, lưu hóa dơn). Sau khi lưu thì không dược cập nhật hay xóa.
    - In hóa hóa đơn bán hàng.
    - Xuất báo cáo theo ngày. (Report và In ấn)
    - Tạo thông tin khách hàng (option)
