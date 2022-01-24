using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TotalPrice { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

    }
}
