using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Person
    {
        public string name;
        //public Person(string name)
        //{
        //    this.name = name;
        //}
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}
