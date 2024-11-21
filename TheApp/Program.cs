using System;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {
        //Human human = new Human();
        //human.Greetings();

        //human.name = "Иван";
        //human.age = 40;
        //human.Greetings();

        //Human human = new Human();
        //human.Greetings();

        //Human human = new Human("Иван");
        //human.Greetings();

        //Human human = new Human("Иван", 45);
        //human.Greetings();

        //Animal animal = new Animal();

        //animal.type = "dog";
        //animal.name = "Spotty";
        //animal.age = 5;

        //animal.Info();

        //Animal animal = new Animal("собака", "Шарик", 4);
        //animal.Info();

        //Animal animal = new Animal { type = "собака", name = "Вольт", age = 4 };
        //animal.Info();

        Rectangle rectangle = new Rectangle(8);
        rectangle.CalculateSquare();
    }
}

class Rectangle
{
    public int a;
    public int b;

    public void CalculateSquare()
    {
        Console.WriteLine($"Сторона a равна {a}, сторона b равна {b}, прощадь равна {a * b}.");
    }

    public Rectangle(int side) 
    {
        a = side;
        b = side;
    }

    public Rectangle(int sideA, int sideB)
    {
        a = sideA;
        b = sideB;
    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }
}

class Human
{
    // Поля класса
    public string name;
    public int age;

    // Метод класса
    public void Greetings()
    {
        Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
    }

    // Конструктор 1
    public Human()
    {
        name = "Неизвестно";
        age = 20;
    }
    // Конструктор 2
    public Human(string n)
    {
        name = n;
        age = 20;
    }
    // Конструктор 3
    public Human(string n, int a)
    {
        name = n;
        age = a;
    }
}

struct Animal
{
    // Поля структуры
    public string type;
    public string name;
    public int age;

    // Метод структуры
    public void Info()
    {
        Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
    }

    public Animal(string petType, string petName, int petAge)
    {
        type = petType;
        name = petName;
        age = petAge;
    }
}
class Pen
{
    public string color;
    public int cost;

    public void ShowData()
    {
        Console.WriteLine("Цвет ручки: {0}.\nЦена ручки: {1}", color, cost);
    }

    public Pen()
    {
        color = "чёрный";
        cost = 100;
    }

    public Pen(string penColor,  int penCost)
    {
        color = penColor;
        cost = penCost;
    }
}