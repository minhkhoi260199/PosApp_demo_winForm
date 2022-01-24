using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public String Image { get; set; }
        public Boolean IsDelete { get; set; }
        public int CategoryID { get; set; }

        public Product()
        {
            this.IsDelete = false;
        }
    }
}
