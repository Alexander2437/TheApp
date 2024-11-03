using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        string[] favcolors = new string[3];

        Console.WriteLine("Введите три ваших любимых цвета на английском с маленькой буквы:");

        for (int i = 0; i < favcolors.Length; i++) 
        {
            favcolors[i] = ShowColor();
        }
        
        Console.WriteLine("Ваши любимые цвета:");

        foreach (var Color in favcolors) 
        {
            Console.WriteLine(Color);
        }
    }

    static string ShowColor()
    {
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }
}