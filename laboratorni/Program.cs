using System;

namespace laboratorni
{
    internal class Figure
    {
        public virtual double CalculateArea() =>0;
        public virtual double CalculatePerimeter() =>0;
    }

    internal class Circle:Figure
    {
        public double Radius {get;set;}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI*Radius*Radius;

        public override double CalculatePerimeter() => 2 * Math.PI*Radius;
    }

    internal class Rectangle:Figure
    {
        public double Width {get; set;}
        public double Height {get; set;}

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea() => Width*Height;

        public override double CalculatePerimeter() => 2 * (Width+Height);
    }

    internal class Fruit
    {
        public string Name {get; set;}

        public Fruit(string name)
        {
            Name = name;
        }

        public override string ToString() => $"Фрукт: {Name}";
    }

    internal class Apple:Fruit
    {
        public string Variety {get; set;}
        public string Color {get; set;}

        public Apple(string name, string variety, string color) : base(name)
        {
            Variety = variety;
            Color = color;
        }

        public override string ToString() =>
            $"Яблуко: {Name}, Сорт: {Variety}, Колір: {Color}";
    }

    internal class Pear:Fruit
    {
        public string Variety {get; set;}
        public string Color {get; set;}

        public Pear(string name, string variety, string color) : base(name)
        {
            Variety = variety;
            Color = color;
        }

        public override string ToString() =>
            $"Груша: {Name}, Сорт: {Variety}, Колір: {Color}";
    }


    public abstract class Animal
    {
        public float Weight {get; set;}
        public string Color {get; set;}

        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }

        public abstract string MakeSound();
    }

    public abstract class AnimalWithTail:Animal
    {
        public float TailLength {get; set;}

        public AnimalWithTail(string color, float weight, float tailLength)
            : base(color, weight)
        {
            TailLength = tailLength;
        }
    }

    public class Cat:AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength)
            : base(color, weight, tailLength)
        {
        }

        private string Purr() => "purrrrrrrr";
        private string Meow() => "Meow";

        public override string MakeSound() => Purr()+Meow();

        public override string ToString() =>
            $"This is a Cat, Color={Color}, Weight ={Weight}, TailLength={TailLength}";
    }

    public class Dog:AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength)
            : base(color, weight, tailLength)
        {
        }

        public override string MakeSound() => "Woof";

        public override string ToString() =>
            $"This is a Dog, Color={Color}, Weight ={Weight}, TailLength={TailLength}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. ФІГУРИ");
            Circle c = new Circle(5);
            Rectangle r = new Rectangle(4, 7);

            Console.WriteLine($"Коло: площа ={c.CalculateArea():F2}, периметр ={c.CalculatePerimeter():F2}");
            Console.WriteLine($"Прямокутник: площа = {r.CalculateArea():F2}, периметр ={r.CalculatePerimeter():F2}");

            Console.WriteLine("\n 2.ФРУКТИ");
            Fruit f = new Fruit("Фрукт");
            Apple a = new Apple("Яблуко", "Семеринка", "Зелений");
            Pear p = new Pear("Груша", "Конференція", "Зелена");

            Console.WriteLine(f);
            Console.WriteLine(a);
            Console.WriteLine(p);

            Console.WriteLine("\n 3. ТВАРИНИ");
            Cat cat = new Cat("Black", 4.5f, 25f);
            Dog dog = new Dog("Brown", 10.2f, 30f);

            Console.WriteLine(cat.ToString());
            Console.WriteLine("Кіт каже: " + cat.MakeSound());

            Console.WriteLine(dog.ToString());
            Console.WriteLine("Пес каже: " + dog.MakeSound());
        }
    }
}

