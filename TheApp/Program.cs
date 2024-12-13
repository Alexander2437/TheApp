using System;
using System.Threading.Channels;
using System.Xml.Linq;
using MyLibrary;

namespace TheApp
{
    class Program
    {
        public static void Main(string[] args)
        {
 
            Person person = new Person();

            person.name = Console.ReadLine();

            person.Print();
        }
    }
}
