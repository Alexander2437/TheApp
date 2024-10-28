using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        //var anketa = (name : "Aleksandr", age : 36);

        var (name, age) = ("Евгения", 27);
        //Console.WriteLine("Ваше имя: {0}", name);
        //Console.WriteLine("Ваш возраст: {0}", age);

        Console.WriteLine($"Мое имя: {name}.\nМой возраст: {age}.");

        //(string name, int age) anketa;

        Console.Write("Введите ваше имя: ");
        name = Console.ReadLine();

        Console.Write("Введите свой возраст: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        //Console.WriteLine("Ваше имя: {0}", anketa.Item1);
        //Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

        Console.ReadKey();
    }
}