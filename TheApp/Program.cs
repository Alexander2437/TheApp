using System;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        int h;
        int w;

        Console.Write("Укажите длину прямоугольника: ");
        w = int.Parse(Console.ReadLine());
        Console.Write("Укажите высоту прямоугольника: ");
        h = int.Parse(Console.ReadLine());
       
        GetRectangleData(w, h, out int area, out int perimetr);
        
        Console.WriteLine("Площадь прямоугольника: {0}", area);
        Console.WriteLine("Периметр прямоугольника: {0}", perimetr);
    }

    static void GetRectangleData(in int width, in int hight, out int RectArea, out int RectPerimetr)
    {
        width++;
        hight++;
        RectArea = width * hight;
        RectPerimetr = (width + hight) * 2;
    }

}