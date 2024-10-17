using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int t = 0;

        while (true)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском языке с маленькой буквы");
            Console.WriteLine(t);

            var text = Console.ReadLine();

            if (text == "stop")
            { 
                Console.WriteLine("Цикл остановлен");
                break;
            }
            
            switch (text)
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

                    continue;
                    /*Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");
                    break;*/
            }
         t++;
        }
    }
}