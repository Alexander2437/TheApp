using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        GetArrayFromConsole();
    }

    static int[] GetArrayFromConsole() 
    {
        int[] result = new int[5];

        for (int i = 0; i < result.Length; i++) 
        {
            Console.WriteLine("Введите элемент массива номер: {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[j];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        Console.WriteLine();

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        return result;
    }
}