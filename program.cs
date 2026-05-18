using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_13
{
    // Абстрактный класс Животное
    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Move();

        // Конструктор класса Животное
        public Animal(string name)
        {
            Name = name;
        }

        // Деструктор класса Животное
        ~Animal()
        {
            Console.WriteLine($"Объект {Name} класса Animal уничтожен.");
        }
    }

    // Абстрактный Класс Рыба, наследуется от Животное
    abstract class Fish : Animal
    {
        public Fish(string name) : base(name) { }

        public abstract void Dive();
    }

    // Абстрактный Класс Птица, наследуется от Животное
    abstract class Bird : Animal
    {
        public Bird(string name) : base(name) { }

        public abstract void Rise();
    }

    // Класс Дельфин, наследуется от Животное
    class Dolphin : Animal
    {
        public Dolphin(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} says: I'm swimming");
        }
    }

    // Класс Пингвин, наследуется от Животное
    class Pinguin : Animal
    {
        public Pinguin(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} says: I'm swimming and walking");
        }
    }
    abstract class Mammals : Animal
    {
        public Mammals(string name) : base(name) { }

        public abstract void Jump();
    }

    // Пример класса, реализующего интерфейс IDisposable, для демонстрации деструктора
    class ExampleDisposable : IDisposable
    {
        public ExampleDisposable()
        {
            Console.WriteLine("Создан объект ExampleDisposable.");
            Console.ReadLine();
        }

        public void Dispose()
        {
            Console.ReadLine();
            Console.WriteLine("Вызван метод Dispose объекта ExampleDisposable.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Dolphin("Теранс");
            animals[1] = new Pinguin("Ковальски");

            // Создание объекта ExampleDisposable для демонстрации деструктора
            using (var exampleDisposable = new ExampleDisposable())
            {
                animals[2] = new Pinguin("Шкипер");
                foreach (var animal in animals)
                {
                    animal.Move();
                }
            }

            Console.ReadLine();
        }
    }
}
