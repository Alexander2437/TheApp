using System;

class Program
{
    static int num1 = 667;
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.ReadKey();

        /*string s = "abc---def";

        Console.WriteLine("Index: 012345678");
        Console.WriteLine("1)     {0}", s);
        Console.WriteLine("2)     {0}", s.Remove(6));
        Console.WriteLine("3)     {0}", s.Remove(0, 2));*/
    }

    static void Echo(string saidword, int deep)
    {
        var modif = saidword;

        if (modif.Length > 2)
            modif = modif.Remove(0, 2);
        
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("..." + modif);

        if (deep > 1)
            Echo(modif, deep - 1);
    }
}