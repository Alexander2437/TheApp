using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите основание: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Введите показатель степени: ");
        byte power = byte.Parse(Console.ReadLine());

        Console.WriteLine($"Число {num} в степени {power} равно: {PowerUp(num, power)}");
    }
    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
}