using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;

        Console.WriteLine("Укажите тип питомца: ");
        Pet.Type = Console.ReadLine();
        Console.WriteLine("Укажите имя питомца: ");
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;
        Console.WriteLine("Укажите возраст питомца: ");
        Pet.Age = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Тип вашего питомца: {0}.\nИмя вашего питомца: {1}.\nДлина имени вашего питомца: {2}.\nВозраст вашего питомца: {3}", Pet.Type, Pet.Name, Pet.NameCount, Pet.Age);

        Console.ReadKey();
    }
}