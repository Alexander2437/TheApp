using System;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        int vysota;
        int shyrina;

        Console.Write("Укажите длину прямоугольника: ");
        shyrina = int.Parse(Console.ReadLine());
        Console.Write("Укажите высоту прямоугольника: ");
        vysota = int.Parse(Console.ReadLine());
       
        GetRectangleData(shyrina, vysota, out int area, out int perimetr);
        
        Console.WriteLine("Площадь прямоугольника: {0}", area);
        Console.WriteLine("Периметр прямоугольника: {0}", perimetr);
    }

    static void GetRectangleData(int width, int hight, out int RectArea, out int RectPerimetr)
    {
        width++;
        hight++;
        RectArea = width * hight;
        RectPerimetr = (width + hight) * 2;
    }

}