using System;

class Program
{
    public static void Main(string[] args)
    {
        
    }
}

class Human
{
    public string name;
    public int age;

    public void Greetings()
    {
        Console.WriteLine("Здравствуйте, меня зовут {0}, мне {1}.", name, age);
    }

    struct Animal
    {
        public string type;
        public string name;
        public int age;

        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }
}