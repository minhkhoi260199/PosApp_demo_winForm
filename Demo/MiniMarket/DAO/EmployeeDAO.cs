using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeDAO : DataProvider
    {
        public EmployeeDAO() : base() {}

        public List<Employee> GetAll()
        {
            String query = "SELECT EmployeeID, EmployeeName, Password FROM Employee";
            DataTable dt = ExecuteQuery(query);

            List<Employee> employees = new List<Employee>();

            foreach(DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.EmployeeID = (int)dr["EmployeeID"];
                employee.EmployeeName = dr["EmployeeName"].ToString();
                employee.Password = dr["Password"].ToString();

                employees.Add(employee);
            }

            return employees;
        }

        public Employee GetByID(int ID)
        {
            String query = "SELECT EmployeeID, EmployeeName, Password FROM Employee WHERE EmployeeID = " + ID.ToString();
            DataTable dt = ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            Employee employee = new Employee();
            employee.EmployeeID = (int)dt.Rows[0]["EmployeeID"];
            employee.EmployeeName = dt.Rows[0]["EmployeeName"].ToString();
            employee.Password = dt.Rows[0]["Password"].ToString();

            return employee;
        }
                
        public bool Insert(String stremployeeName, String strPassword)
        {
            String query = "INSERT INTO Employee(EmployeeName, Password) VALUES (N'" + stremployeeName + "', N'" + strPassword + "')";
            return ExecuteNonQuery(query);
        }

        public bool Update(int ID, String stremployeeName, String strPassword)
        {
            String query = "UPDATE Employee SET EmployeeName = N'" + stremployeeName + "', Password = '" + strPassword + "' WHERE EmployeeID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

        public bool Delete(int ID)
        {
            String query = "DELETE FROM Employee WHERE EmployeeID = " + ID.ToString();
            return ExecuteNonQuery(query);
        }

    }
}
