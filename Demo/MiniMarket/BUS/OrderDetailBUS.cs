using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetailBUS
    {
        private OrderDetailDAO orderDetailDAO;

        public OrderDetailBUS()
        {
            orderDetailDAO = new OrderDetailDAO();
        }

        public List<OrderDetail> GetAll()
        {
            return orderDetailDAO.GetAll();
        }

        public OrderDetail GetByID(int ID)
        {
            return orderDetailDAO.GetByID(ID);
        }

        public Boolean Insert(int orderID, int productID, int salingPrice, int salingQuantity)
        {
            return orderDetailDAO.Insert(orderID, productID, salingPrice, salingQuantity);
        }

        public Boolean Insert(OrderDetail orderDetail)
        {
            return this.Insert(orderDetail.OrderID, orderDetail.ProductID, orderDetail.SalingPrice, orderDetail.SalingQuantity);
        }


        public Boolean Update(int ID, int orderID, int productID, int salingPrice, int salingQuantity)
        {
            return orderDetailDAO.Update(ID, orderID, productID, salingPrice, salingQuantity);
        }

        public Boolean Update(OrderDetail orderDetail)
        {
            return this.Update(orderDetail.OrderDetailID, orderDetail.OrderID, orderDetail.ProductID, orderDetail.SalingPrice, orderDetail.SalingQuantity);
        }

        public Boolean Delete(int ID)
        {
            return orderDetailDAO.Delete(ID);
        }

        public Boolean Delete(OrderDetail orderDetail)
        {
            return this.Delete(orderDetail.OrderDetailID);
        }
    }
}
