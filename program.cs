using System;

namespace Лаба_13
{
    // Абстрактный класс Животное
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Move();

        // Общий метод вывода информации
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        ~Animal()
        {
            Console.WriteLine($"Объект {Name} класса Animal уничтожен.");
        }
    }

    // Рыба
    abstract class Fish : Animal
    {
        public Fish(string name) : base(name) { }

        public abstract void Dive();
    }

    // Птица
    abstract class Bird : Animal
    {
        public Bird(string name) : base(name) { }

        public abstract void Rise();
    }

    // Млекопитающие
    abstract class Mammals : Animal
    {
        public Mammals(string name) : base(name) { }

        public abstract void Jump();
    }

    // Дельфин
    class Dolphin : Mammals
    {
        public Dolphin(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} says: I'm swimming");
        }

        public override void Jump()
        {
            Console.WriteLine($"{Name} jump out of the water.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Dolphin:");
            base.ShowInfo();
            Move();
            Jump();
        }
    }

    // Пингвин
    class Penguin : Bird
    {
        public Penguin(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} says: I'm swimming and walking");
        }

        public override void Rise()
        {
            Console.WriteLine($"{Name} can not fly.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Penguin:");
            base.ShowInfo();
            Move();
            Rise();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dolphin("Теренс"),
                new Penguin("Ковальски")
            };

            foreach (var animal in animals)
            {
                animal.ShowInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
