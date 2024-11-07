using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = GetArrayFromConsole(10);
        ShowArray(array, true);
    }

    static void ShowArray(int[] array, bool IsSort = false) 
    {
        var temp = array;
        if (IsSort == true) 
        {
            temp = SortArray(array);
        }

        foreach (int item in temp)
        {
            Console.Write(item + " ");
        }
    } 

    static int[] GetArrayFromConsole(int num = 5)
    {
        var arraytoobtain = new int[num];

        for (int i = 0; i < arraytoobtain.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            arraytoobtain[i] = int.Parse(Console.ReadLine());
        }

        //SortArray(arraytoobtain);

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

        //PrintArray(arraytosort);

        return arraytosort;
    }

    static int[] PrintArray(int[] arraytoprint)
    {
        foreach (int item in arraytoprint)
            Console.Write(item + "\t");

        return arraytoprint;
    }

    static void SortComplexArray(int[,] arr)
    {
        int temp;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    if (arr[i, j] > arr[i, k])
                    {
                        temp = arr[i, k];
                        arr[i, k] = arr[i, j];
                        arr[i, j] = temp;
                    }
        }
    }
}