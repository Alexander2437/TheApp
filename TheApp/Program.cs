using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //int[,] arr = {{ 18, 13, 17, 21, -30, 100 }, { 78, 54, 96, -36, 3, 684 } };

        //SortComplexArray(arr);

        //for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        //{
        //    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
        //        Console.Write(arr[i, j] + "    ");

        //    Console.WriteLine();
        //}

        //Console.WriteLine();


        var arr = new int[] { 1, 2, 3 };
        BigDataOperation(in arr);

        Console.WriteLine(arr[0]);



        //(string name, int age) anketa;

        //Console.Write("Введите имя пользователя: ");
        //anketa.name = Console.ReadLine();
        //Console.Write("Введите возраст пользователя цифрами: ");
        //anketa.age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Your name is {0}, your age is {1}", anketa.name, anketa.age);

        //ChangePersonalData(ref anketa.age, anketa.name);

        //Console.WriteLine("Your name is {0}, your age is {1}", anketa.name, anketa.age);

        
        
        //var array = GetArray();

        //SortArray(array);

        //foreach (var item in array)
        //{
        //    Console.Write(item + " ");
        //}




        //ИСПОЛЬЗОВАНИЕ SHOWCOLOR ДЛЯ ЗАПОЛНЕНИЯ МАССИВА И ВЫВОДА НА ЭКРАН

        //string[] favColors = new string[3];

        //for (int i = 0; i < favColors.Length; i++)
        //{
        //    favColors[i] = Console.ReadLine();
        //}

        //ShowColors();

        //Console.ReadKey();

        //foreach (string color in favColors)
        //{
        //    Console.Write(color);
        //}
    }

    static string ShowColor(string name, int age)
    {
        Console.WriteLine("{0}, {1} лет, напишите свой любимый цвет на английском языке с маленькой буквы.", name, age);

        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "white":
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is white!");
                break;

            case "blue":
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is blue!");
                break;

            default:
                //continue;
                //Console.BackgroundColor = ConsoleColor.Yellow;
                //Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Nope! Try again!");
                break;
        }

        return color;
    }

    static int[] GetArray(int num = 5)
    {
        var array = new int[num];

        for (int i = 0;i < array.Length; i++)
        {
            Console.WriteLine("Insert array element number {0}", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }       

        //foreach (int element in array)
        //{
        //    Console.Write(element + " ");
        //}

        return array;
    }

    static int[] SortArray(int[] array)
    {
        int temp;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }

    static void ShowColors(string name = "Alex", params string[] favcolors)
    {
        Console.WriteLine("{0}, Ваши любимые цвета:", name);
        foreach (var color in favcolors)
        {
            Console.Write(color + "    ");
        }
    }

    static void SortComplexArray(int[,] array)
    {
        int temp;

        for (int line = 0; line <= array.GetUpperBound(0); line++)
        {
            for (int column = 0; column <= array.GetUpperBound(1); column++)
            {
                for (int nextColumn = column + 1;  nextColumn <= array.GetUpperBound(1); nextColumn++)
                {
                    if (array[line, column] > array[line, nextColumn])
                    {
                        temp = array[line, column];
                        array[line, column] = array[line, nextColumn];
                        array[line, nextColumn] = temp;
                    }
                }
            }
        }
    }

    static void ChangePersonalData(ref int age, string name)
    {
        age++;
        name = "Alexander";
        Console.WriteLine($"Your changed age is {age}, your name is {name}.");
    }

    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
    }
}