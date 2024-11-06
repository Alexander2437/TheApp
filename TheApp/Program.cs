using System;

class Program
{
    public static void Main(string[] args)
    {
        GetArrayFromConsole();
    }

    static int[] GetArrayFromConsole()
    {
        var arraytoobtain = new int[5];

        for (int i = 0; i < arraytoobtain.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            arraytoobtain[i] = int.Parse(Console.ReadLine());
        }
        
        SortArray(arraytoobtain);

        return arraytoobtain;
    }

    static int[] SortArray(int[] arraytosort) 
    {
        int temp = 0;

        for (int i = 0; i < arraytosort.Length; i++)
            for (int t = i + 1; t < arraytosort.Length; t++)
            {
                if (arraytosort[i] > arraytosort[t])
                {
                    temp = arraytosort[i];
                    arraytosort[i] = arraytosort[t];
                    arraytosort[t] = temp;
                }
            }

        PrintArray(arraytosort);

        return arraytosort;
    }

    static int[] PrintArray(int[] arraytoprint) 
    {
        foreach (int item in arraytoprint)
            Console.Write(item + "\t");

        return arraytoprint;
    }
}