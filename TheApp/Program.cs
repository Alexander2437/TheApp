using System;

class Program
{
    public static void Main(string[] args)
    {
        GetArrayFromConsole();
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;

        for (int i = 0; i < result.Length; i++)
            for (int t = i + 1; t <result.Length; t++)
            {
                if (result[i] > result[t]) 
                {
                    temp = result[i];
                    result[i] = result[t];
                    result[t] = temp;
                }
            }
        foreach (int item in result)
            Console.Write(item + "\t");

        return result;
    }
}