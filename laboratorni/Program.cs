using System;

namespace laboratorni
{
    abstract class Shape
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle("Circle 1", 3);
            Circle c2 = new Circle("Circle 2", 5);

            Square s1 = new Square("Square 1", 4);
            Square s2 = new Square("Square 2", 7);

            Shape[] shapes = { c1, c2, s1, s2 };

            Console.WriteLine("=== Всі фігури ===");
            foreach (var sh in shapes)
            {
                Console.WriteLine($"{sh.Name}: площа = {sh.Area():F2}, периметр = {sh.Perimeter():F2}");
            }
            double maxSquareArea = Math.Max(s1.Area(), s2.Area());
            double maxCircleArea = Math.Max(c1.Area(), c2.Area());

            Console.WriteLine();
            Console.WriteLine("=== Найбільші фігури ===");
            Console.WriteLine("Найбільший квадрат: " + maxSquareArea.ToString("F2"));
            Console.WriteLine("Найбільше коло: " + maxCircleArea.ToString("F2"));
        }
    }
}

