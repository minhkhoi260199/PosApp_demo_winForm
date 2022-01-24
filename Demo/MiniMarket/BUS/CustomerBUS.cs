using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private CustomerDAO customerDAO;

        public CustomerBUS()
        {
            customerDAO = new CustomerDAO();
        }

        public List<Customer> GetAll()
        {
            return customerDAO.GetAll();
        }

        public Customer GetByID(int ID)
        {
            return customerDAO.GetByID(ID);
        }

        public Customer GetByPhoneNumber(String PhoneNumber)
        {
            return customerDAO.GetByPhoneNumber(PhoneNumber);
        }

        public Boolean Insert(String strCustomerName, String strCustomerPhoneNumber)
        {
            return customerDAO.Insert(strCustomerName, strCustomerPhoneNumber);
        }

        public Boolean Insert(Customer customer)
        {
            return this.Insert(customer.CustomerName, customer.CustomerPhoneNumber);
        }

        public Boolean Update(int ID, String strCustomerName, String strCustomerPhoneNumber)
        {
            return customerDAO.Update(ID, strCustomerName, strCustomerPhoneNumber);
        }

        public Boolean Update(Customer customer)
        {
            return this.Update(customer.CustomerID, customer.CustomerName, customer.CustomerPhoneNumber);
        }

        public Boolean Delete(int ID)
        {
            return customerDAO.Delete(ID);
        }

        public Boolean Delete(Customer customer)
        {
            return this.Delete(customer.CustomerID);
        }
    }
}
