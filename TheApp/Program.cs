using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.Write("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1);

            Console.Write("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1);

            /*foreach (var item in array) 
            {
                Console.Write(item + " ");
            }*/

            Console.ReadKey();
        }
    }
}