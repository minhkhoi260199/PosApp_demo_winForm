using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO : DataProvider
    {
        public CustomerDAO() : base() {}

        public List<Customer> GetAll()
        {
            String query = "SELECT CustomerID, CustomerName, CustomerPhoneNumber FROM Customer";
            DataTable dt = ExecuteQuery(query);

            List<Customer> customers = new List<Customer>();

            foreach(DataRow dr in dt.Rows)
            {
                Customer customer = new Customer();
                customer.CustomerID = (int)dr["CustomerID"];
                customer.CustomerName = dr["CustomerName"].ToString();
                customer.CustomerPhoneNumber = dr["CustomerPhoneNumber"].ToString();

                customers.Add(customer);
            }

            return customers;
        }

        public Customer GetByID(int ID)
        {
            String query = "SELECT CustomerID, CustomerName, CustomerPhoneNumber FROM Customer WHERE CustomerID = " + ID.ToString();
            DataTable dt = ExecuteQuery(query);

            Customer customer = new Customer();
            customer.CustomerID = (int)dt.Rows[0]["CustomerID"];
            customer.CustomerName = dt.Rows[0]["CustomerName"].ToString();
            customer.CustomerPhoneNumber = dt.Rows[0]["CustomerPhoneNumber"].ToString();

            return customer;
        }

        public Customer GetByPhoneNumber(String PhoneNumber)
        {
            String query = "SELECT CustomerID, CustomerName, CustomerPhoneNumber FROM Customer WHERE CustomerPhoneNumber = '" + PhoneNumber + "'";
            DataTable dt = ExecuteQuery(query);

            Customer customer = new Customer();
            if (dt.Rows.Count == 0)
                return null;
            customer.CustomerID = (int)dt.Rows[0]["CustomerID"];
            customer.CustomerName = dt.Rows[0]["CustomerName"].ToString();
            customer.CustomerPhoneNumber = dt.Rows[0]["CustomerPhoneNumber"].ToString();

            return customer;
        }

        public bool Insert(String strcustomerName, String strcustomerPhoneNumber)
        {
            String query = "INSERT INTO Customer(CustomerName, CustomerPhoneNumber) VALUES (N'" + strcustomerName + "', '" + strcustomerPhoneNumber + "')";
            return ExecuteNonQuery(query);
        }

        public bool Update(int ID, String strcustomerName, String strcustomerPhoneNumber)
        {
            String query = "UPDATE Customer SET CustomerName = N'" + strcustomerName + "', CustomerPhoneNumber = '" + strcustomerPhoneNumber + "' WHERE CustomerID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public bool Delete(int ID)
        {
            String query = "DELETE FROM Customer WHERE CustomerID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

    }
}
