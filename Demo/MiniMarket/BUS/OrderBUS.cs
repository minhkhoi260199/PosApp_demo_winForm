using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderBUS
    {
        private OrderDAO orderDAO;

        public OrderBUS()
        {
            orderDAO = new OrderDAO();
        }

        public List<Order> GetAll()
        {
            return orderDAO.GetAll();
        }

        public Order GetByID(int ID)
        {
            return orderDAO.GetByID(ID);
        }

        public int Insert(DateTime createdAt, int totalPrice, int customerID, int employeeID)
        {
            orderDAO.Insert(createdAt, totalPrice, customerID, employeeID);
            int topOrderID = orderDAO.TopOrderID();

            return topOrderID;
        }

        public int Insert(Order order)
        {
            return this.Insert(order.CreatedAt, order.TotalPrice, order.CustomerID, order.EmployeeID);
        }


        public Boolean Update(int ID, DateTime createdAt, int totalPrice, int customerID, int employeeID)
        {
            return orderDAO.Update(ID, createdAt, totalPrice, customerID, employeeID);
        }

        public Boolean Update(Order order)
        {
            return this.Update(order.OrderID, order.CreatedAt, order.TotalPrice, order.CustomerID, order.EmployeeID);
        }

        public Boolean Delete(int ID)
        {
            return orderDAO.Delete(ID);
        }

        public Boolean Delete(Order order)
        {
            return this.Delete(order.OrderID);
        }
    }
}
