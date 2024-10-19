using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] favcolors = new string[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
            favcolors[i] = Console.ReadLine();
        }

        foreach (var color in favcolors)
        {
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
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}