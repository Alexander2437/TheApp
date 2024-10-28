using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        //var anketa = (name : "Aleksandr", age : 36);

        (string name, int age) anketa;

        Console.WriteLine("Введите ваше имя: ");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите свой возраст: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);
    }
}