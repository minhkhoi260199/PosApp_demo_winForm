using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProductDAO : DataProvider
    {
        public ProductDAO() : base() {}

        public List<Product> GetAll()
        {
            String query = "SELECT ProductID, ProductName, Price, Quantity, Image, IsDelete, CategoryID FROM Product";
            DataTable dt = ExecuteQuery(query);

            List<Product> products = new List<Product>();

            foreach(DataRow dr in dt.Rows)
            {
                Product product = new Product();
                product.ProductID = (int)dr["ProductID"];
                product.ProductName = dr["ProductName"].ToString();
                product.Price = (int)dr["Price"];
                product.Quantity = (int)dr["Quantity"];
                product.Image = dr["Image"].ToString();
                product.IsDelete = (bool)dr["IsDelete"];
                product.CategoryID = (int)dr["CategoryID"];

                products.Add(product);
            }

            return products;
        }

        public Product GetByID(int ID)
        {
            String query = "SELECT ProductID, ProductName, Price, Quantity, Image, IsDelete, CategoryID FROM Product WHERE ProductID = " + ID.ToString();
            DataTable dt = ExecuteQuery(query);

            Product product = new Product();
            product.ProductID = (int)dt.Rows[0]["ProductID"];
            product.ProductName = dt.Rows[0]["ProductName"].ToString();
            product.Price = (int)dt.Rows[0]["Price"];
            product.Quantity = (int)dt.Rows[0]["Quantity"];
            product.Image = dt.Rows[0]["Image"].ToString();
            product.IsDelete = (bool)dt.Rows[0]["IsDelete"];
            product.CategoryID = (int)dt.Rows[0]["CategoryID"];

            return product;
        }
                
        public bool Insert(String strproductName, int price, int quantity, String strImage, bool isDelete, int categoryID)
        {
            String query = "INSERT INTO Product(ProductName, Price, Quantity, Image, IsDelete, CategoryID) VALUES (N'" + strproductName + "', '" + price.ToString() + "', '" + quantity.ToString() + "', '" + strImage + "', '" + isDelete.ToString() + "', '" + categoryID.ToString() + "')";
            return ExecuteNonQuery(query);
        }

        public bool Update(int ID, String strproductName, int price, int quantity, String strImage, bool isDelete, int categoryID)
        {
            String query = "UPDATE Product SET ProductName = N'" + strproductName + "', Price = '" + price.ToString() + "', Quantity = '" + quantity.ToString() + "', Image = '" + strImage + "', IsDelete = '" + isDelete.ToString() + "', CategoryID = '" + categoryID.ToString() + "' WHERE ProductID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public bool Delete(int ID)
        {
            String query = "DELETE FROM Product WHERE ProductID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

    }
}
