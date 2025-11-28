using System;

namespace laboratorni
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name => name;
        public DateTime BirthYear => birthYear;

        public Person()
        {
            name = "NoName";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Введіть ім'я: ");
            name = Console.ReadLine();

            Console.Write("Введіть рік народження (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Ім'я: {name}, Рік народження: {birthYear.Year}, Вік: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Person[] people = new Person[6];

            Console.WriteLine("--- Введення даних про 6 осіб ---");

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"\nОсоба #{i + 1}");
                people[i] = new Person();
                people[i].Input();
            }

            Console.WriteLine("\n--- Ім’я та вік кожної особи ---");
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Name}: {p.Age()} років");
            }

            foreach (var p in people)
            {
                if (p.Age() < 16)
                {
                    p.ChangeName("Very Young");
                }
            }

            Console.WriteLine("\n--- Інформація про всіх осіб ---");
            foreach (var p in people)
            {
                p.Output();
            }

            Console.WriteLine("\n--- Особи з однаковими іменами ---");
            bool found = false;

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        found = true;
                        Console.WriteLine($"\nЗбіг імен: \"{people[i].Name}\"");
                        people[i].Output();
                        people[j].Output();
                    }
                }
            }

            if (!found)
                Console.WriteLine("Однакових імен не знайдено.");
        }
    }
}