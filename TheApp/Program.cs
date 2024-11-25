using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
        string companyType = department?.Company?.Type;
        string companyCity = department?.City?.Name;
        string companyName = department?.Company?.Name ?? "Неизвестная компания";
        if (companyType?.ToLower() == "Банк".ToLower() &&  companyCity?.ToLower() == "Санкт-Петербург".ToLower())
        {
            Console.WriteLine("\"У банка {0} есть отделение в Санкт-Петербурге\"", companyName);
        }
    }

    static Department GetCurrentDepartment()
    {
        // logic
    }
}

class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}