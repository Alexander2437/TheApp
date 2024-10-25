using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        int numbers = 0;

        /*for (int i = 0; i <= array.GetUpperBound(0); i++) 
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++) 
            {
                if(array[i, j] > 0)
                    numbers++;
            
            
            Console.Write(numbers);
        }*/

        foreach (var item in array) 
        {
            if (item > 0)
                numbers++;
        }

        Console.WriteLine(numbers);
    }
}