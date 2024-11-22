using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheApp
{
    class App1
    {
        Employee employee = new Employee();
        //employee.Department 
        //string CompanyName = employee.Department.Company.Name;
    }
    public class Employee
    {
        public Department Department;
    }

    public class Department
    {
        public Company Company;
    }

    public class Company
    {
        public string Name;
    }
}
