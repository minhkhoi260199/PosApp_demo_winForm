using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryDAO : DataProvider
    {
        public CategoryDAO() : base() {}

        public List<Category> GetAll()
        {
            String query = "SELECT CategoryID, CategoryName FROM Category";
            DataTable dt = ExecuteQuery(query);

            List<Category> categories = new List<Category>();

            foreach(DataRow dr in dt.Rows)
            {
                Category category = new Category();
                category.CategoryID = (int)dr["CategoryID"];
                category.CategoryName = dr["CategoryName"].ToString();

                categories.Add(category);
            }

            return categories;
        }

        public Category GetByID(int ID)
        {
            String query = "SELECT CategoryID, CategoryName FROM Category WHERE CategoryID = " + ID.ToString();
            DataTable dt = ExecuteQuery(query);

            Category category = new Category();
            category.CategoryID = (int)dt.Rows[0]["CategoryID"];
            category.CategoryName = dt.Rows[0]["CategoryName"].ToString();

            return category;
        }
                
        public bool Insert(string strCategoryName)
        {
            String query = "INSERT INTO Category(CategoryName) VALUES (N'" + strCategoryName + "')";
            return ExecuteNonQuery(query);
        }

        public bool Update(int ID, String strCategoryName)
        {
            String query = "UPDATE Category SET CategoryName = N'" + strCategoryName + "' WHERE CategoryID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public bool Delete(int ID)
        {
            String query = "DELETE FROM Category WHERE CategoryID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

    }
}
