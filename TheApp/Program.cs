using System;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {


        GetUserData();
    }

    public static void GetUserData()
    {
        var name = EnterData("имя пользователя");
        var lastname = EnterData("фамилию пользователя");
        //var color = EnterData("любимый цвет");
        //
        int age = EnterNumber("возраст пользователя");
       
        Console.WriteLine("Наличие питомца. Укажите да или нет.");
        bool hasPet = false;
        string petAnswer = Console.ReadLine().ToUpper();
        if (petAnswer == "Да".ToUpper())
        {
            hasPet = true;
        }

        int petCount = 0;
        if (hasPet == true)
        {
            petCount = EnterNumber("количество питомцев");
        }

        int favColorsNumber = EnterNumber("количество любимых цветов");

        string[] petNames = EnterPetNames(petCount); 

        (string name, string lastname, int age, bool hasPet, int petCount, string[] petNames, string[] favColors) UserData;

        UserData.name = name;
        UserData.lastname = lastname;
        UserData.age = age;
        UserData.hasPet = hasPet;
        UserData.petCount = petCount;
        UserData.petNames = petNames;

    }

    private static string[] EnterFavColors(int arraySize)
    {
        string[] result = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            var arrayValue = EnterData("любимый цвет");
            result[i] = arrayValue;
        }
        return result;
    }

    private static string[] EnterPetNames(int arraySize)
    {
        string[] result = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            var arrayValue = EnterData("кличку питомца");
            result[i] = arrayValue;
        }
        return result;
    }

    private static int EnterNumber(string text)
    {
        bool isCorrectNumber = false;
        int age;
        do
        {
            Console.Write("Введите {0}: ", text);
            string input = Console.ReadLine();
            isCorrectNumber = CheckData(input, out age);
        }
        while (isCorrectNumber == false);
        return age;
    }

    private static string EnterData(string text)
    {
        bool condition = false;
        string name;
        do
        {
            Console.Write("Введите {0}: ", text);
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                condition = false;
            }
            else
            {
                condition = true;
            }
        }
        while (condition == false);
        return name;
    }

    public static bool CheckData(string number, out int corrnumber)
    {
        bool result = false;
        int x = 0;
        if (int.TryParse(number, out int intnumber))
        {
            if (intnumber > 0)
            {
                x = intnumber;
                result = true;
            }
        }
        else
        {
            x = 0;
            result = false;
        }
        corrnumber = x;
        return result;
    }
}