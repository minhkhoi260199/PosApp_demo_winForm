using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrderDAO : DataProvider
    {
        public OrderDAO() : base() {}

        public List<Order> GetAll()
        {
            String query = "SELECT OrderID, CreatedAt, TotalPrice, CustomerID, EmployeeID FROM Order";
            DataTable dt = ExecuteQuery(query);

            List<Order> orders = new List<Order>();

            foreach(DataRow dr in dt.Rows)
            {
                Order order = new Order();
                order.OrderID = (int)dr["OrderID"];
                order.CreatedAt = (DateTime)dr["CreatedAt"];
                order.TotalPrice = (int)dr["TotalPrice"];
                order.CustomerID = (int)dr["CustomerID"];
                order.EmployeeID = (int)dr["EmployeeID"];

                orders.Add(order);
            }

            return orders;
        }

        public Order GetByID(int ID)
        {
            String query = "SELECT OrderID, CreatedAt, TotalPrice, CustomerID, EmployeeID FROM Order WHERE OrderID = " + ID.ToString();
            DataTable dt = ExecuteQuery(query);

            Order order = new Order();
            order.OrderID = (int)dt.Rows[0]["OrderID"];
            order.CreatedAt = (DateTime)dt.Rows[0]["CreatedAt"];
            order.TotalPrice = (int)dt.Rows[0]["TotalPrice"];
            order.CustomerID = (int)dt.Rows[0]["CustomerID"];
            order.EmployeeID = (int)dt.Rows[0]["EmployeeID"];

            return order;
        }
                
        public bool Insert(DateTime createdAt, int totalPrice, int customerID, int employeeID)
        {
            String query = "INSERT INTO [Order](CreatedAt, TotalPrice, CustomerID, EmployeeID) VALUES ('" + createdAt.ToString() + "', " + totalPrice.ToString() + ", " + customerID.ToString() + ", " + employeeID.ToString() + ")";
            return ExecuteNonQuery(query);
        }

        public bool Update(int ID, DateTime createdAt, int totalPrice, int customerID, int employeeID)
        {
            String query = "UPDATE Order SET CreatedAt = '" + createdAt.ToString() + "', TotalPrice = '" + totalPrice.ToString() + "', CustomerID = '" + customerID.ToString() + "', EmployeeID = '" + employeeID.ToString() +"' WHERE OrderID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public bool Delete(int ID)
        {
            String query = "DELETE FROM Order WHERE OrderID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public int TopOrderID()
        {
            String query = "SELECT TOP(1) OrderID FROM [Order] ORDER BY OrderID DESC";
            DataTable dt = ExecuteQuery(query);
            int topOrderID = (int)dt.Rows[0][0];
            return topOrderID;
        }
    }
}
