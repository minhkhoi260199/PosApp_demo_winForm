using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrderDetailDAO : DataProvider
    {
        public OrderDetailDAO() : base() {}

        public List<OrderDetail> GetAll()
        {
            String query = "SELECT OrderDetailID, OrderID, ProductID, SalingPrice, SalingQuantity FROM OrderDetail";
            DataTable dt = ExecuteQuery(query);

            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach(DataRow dr in dt.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderDetailID = (int)dr["OrderDetailID"];
                orderDetail.OrderID = (int)dr["OrderID"];
                orderDetail.ProductID = (int)dr["ProductID"];
                orderDetail.SalingPrice = (int)dr["SalingPrice"];
                orderDetail.SalingQuantity = (int)dr["SalingQuantity"];

                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }

        public OrderDetail GetByID(int ID)
        {
            String query = "SELECT OrderDetailID, OrderID, ProductID, SalingPrice, SalingQuantity FROM OrderDetail WHERE OrderDetailID = " + ID.ToString();
            DataTable dt = ExecuteQuery(query);

            OrderDetail orderDetail = new OrderDetail();
            orderDetail.OrderDetailID = (int)dt.Rows[0]["OrderDetailID"];
            orderDetail.OrderID = (int)dt.Rows[0]["OrderID"];
            orderDetail.ProductID = (int)dt.Rows[0]["ProductID"];
            orderDetail.SalingPrice = (int)dt.Rows[0]["SalingPrice"];
            orderDetail.SalingQuantity = (int)dt.Rows[0]["SalingQuantity"];

            return orderDetail;
        }
                
        public bool Insert(int orderID, int productID, int salingPrice, int salingQuantity)
        {
            String query = "INSERT INTO OrderDetail(OrderID, ProductID, SalingPrice, SalingQuantity) VALUES ('" + orderID.ToString() + "', '" + productID.ToString() + "', '" + salingPrice.ToString() + "', '" + salingQuantity.ToString() + "')";
            return ExecuteNonQuery(query);
        }

        public bool Update(int ID, int orderID, int productID, int salingPrice, int salingQuantity)
        {
            String query = "UPDATE OrderDetail SET OrderID = '" + orderID.ToString() + "', ProductID = '" + productID.ToString() + "', SalingPrice = '" + salingPrice.ToString() + "', SalingQuantity = '" + salingQuantity.ToString() +"' WHERE OrderDetailID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public bool Delete(int ID)
        {
            String query = "DELETE FROM OrderDetail WHERE OrderDetailID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

    }
}
