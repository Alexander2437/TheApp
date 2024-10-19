using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int sum = 0;

        while (true) 
        {
            Console.Write("Insert a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number < 0) 
            {
                continue;
            }

            else if (number == 0) 
            {
                break;
            }

            sum += number;
            Console.WriteLine("Final sum is {0}", sum);
        }
    }
}