using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBUS
    {
        private CategoryDAO categoryDAO;

        public CategoryBUS()
        {
            categoryDAO = new CategoryDAO();
        }

        public List<Category> GetAll()
        {
            return categoryDAO.GetAll();
        }

        public Category GetByID(int ID)
        {
            return categoryDAO.GetByID(ID);
        }

        public Boolean Insert(String strCategoryName)
        {
            return categoryDAO.Insert(strCategoryName);
        }

        public Boolean Update(int ID, String strCategoryName)
        {
            return categoryDAO.Update(ID, strCategoryName);
        }

        public Boolean Update(Category category)
        {
            return this.Update(category.CategoryID, category.CategoryName);
        }

        public Boolean Delete(int ID)
        {
            return categoryDAO.Delete(ID);
        }

        public Boolean Delete(Category cateogry)
        {
            return this.Delete(cateogry.CategoryID);
        }
    }
}
