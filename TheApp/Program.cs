using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3, }, { 4, 5, 6, }, {7, 8, 9 }, {10, 11, 12} };
 
            /*foreach (int i in array) 
            {
                Console.Write(i + " ");
            }*/
            
            //Console.WriteLine(array.Length);
            
            //int lines = array.GetUpperBound(0) + 1;
            //int columns = array.GetUpperBound(1) + 1;

            //Console.WriteLine("Количество строк: {0}", lines);
            //Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            //Console.Write("Количество стобцов: {0}", columns);
            //Console.Write(array.GetUpperBound(1) +1 + " ");

            Console.WriteLine();

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++) 
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++) 
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}