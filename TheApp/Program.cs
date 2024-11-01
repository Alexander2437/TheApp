using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        (string name, string surname, string login, int LoginLength, string password, bool PetIsPresent, int age, string[] FavColors) user;

        for (int j = 0; j < 3; j++)
        {
            Console.Write("Введите имя пользователя: ");
            user.name = Console.ReadLine();

            Console.Write("Введиде фамилию пользователя: ");
            user.surname = Console.ReadLine();

            Console.Write("Придумайте логин: ");
            user.login = Console.ReadLine();
            user.LoginLength = user.login.Length;

            Console.WriteLine("Длина логина: {0}", user.LoginLength);

            Console.Write("Придумайте пароль: ");
            user.password = Console.ReadLine();

            Console.Write("Наличие питомца. Укажите \u0022да\u0022 или \u0022нет\u0022: ");
            var Answer = Console.ReadLine();
            if (Answer == "да")
            {
                user.PetIsPresent = true;
                //Console.WriteLine("У вас есть питомец.");
            }
            else
            {
                user.PetIsPresent = false;
                //Console.WriteLine("У вас нет пиомца.");
            }

            Console.Write("Укажите ваш возраст: ");
            user.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Укажите три своих любимых цвета: ");
            user.FavColors = new string[3];
            for (int i = 0; i < user.FavColors.Length; i++)
            {
                user.FavColors[i] = Console.ReadLine();
            }
        }
    }
}