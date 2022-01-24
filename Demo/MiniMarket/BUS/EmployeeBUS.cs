using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        private EmployeeDAO employeeDAO;

        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
        }

        public List<Employee> GetAll()
        {
            return employeeDAO.GetAll();
        }

        public Employee GetByID(int ID)
        {
            return employeeDAO.GetByID(ID);
        }

        public Boolean Insert(String strEmployeeName, String strPassword)
        {
            return employeeDAO.Insert(strEmployeeName, strPassword);
        }

        public Boolean Insert(Employee employee)
        {
            return this.Insert(employee.EmployeeName, employee.Password);
        }


        public Boolean Update(int ID, String strEmployeeName, String strPassword)
        {
            return employeeDAO.Update(ID, strEmployeeName, strPassword);
        }

        public Boolean Update(Employee employee)
        {
            return this.Update(employee.EmployeeID, employee.EmployeeName, employee.Password);
        }

        public Boolean Delete(int ID)
        {
            return employeeDAO.Delete(ID);
        }

        public Boolean Delete(Employee employee)
        {
            return this.Delete(employee.EmployeeID);
        }

        public Employee CheckAccount(int employeeID, String password)
        {
            Employee employee = employeeDAO.GetByID(employeeID);

            if (employee == null)
                return null;
            else
            {
                if (employee.Password != password)
                    return null;
                else
                    return employee;
            }
        }
    }
}
