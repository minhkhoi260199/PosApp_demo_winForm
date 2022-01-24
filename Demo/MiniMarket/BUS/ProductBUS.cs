using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBUS
    {
        private ProductDAO productDAO;

        public ProductBUS()
        {
            productDAO = new ProductDAO();
        }

        public List<Product> GetAll()
        {
            return productDAO.GetAll();
        }

        public Product GetByID(int ID)
        {
            return productDAO.GetByID(ID);
        }

        public Boolean Insert(String strProductName, int price, int quantity, String strImage, bool isDelete, int categoryID)
        {
            return productDAO.Insert(strProductName, price, quantity, strImage, isDelete, categoryID);
        }

        public Boolean Insert(Product product)
        {
            return this.Insert(product.ProductName, product.Price, product.Quantity, product.Image, product.IsDelete, product.CategoryID);
        }


        public Boolean Update(int ID, String strProductName, int price, int quantity, String strImage, bool isDelete, int categoryID)
        {
            return productDAO.Update(ID, strProductName, price, quantity, strImage, isDelete, categoryID);
        }

        public Boolean Update(Product product)
        {
            return this.Update(product.ProductID, product.ProductName, product.Price, product.Quantity, product.Image, product.IsDelete, product.CategoryID);
        }

        public Boolean Delete(int ID)
        {
            return productDAO.Delete(ID);
        }

        public Boolean Delete(Product product)
        {
            return this.Delete(product.ProductID);
        }
    }
}
