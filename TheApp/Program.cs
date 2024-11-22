using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        
        //Department department = new Department();
        //employee.Department = department;
        
        //employee.Department = new Department();

        //employee.City = "Moscow";

        //string x = employee.City;

        //string companyname = employee.department.company.name;

        string name = employee.Department.Company.Name;
    }
}

public class Employee
{
    public Department Department;
    public string City;
}

public class Department
{
    public Company Company;
}

public class Company
{
    public string Name;
}