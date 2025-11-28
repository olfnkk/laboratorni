using laboratorni;
using System;

namespace laboratorni
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Cat
    {
        public string Name { get;}
        public Gender Gender { get;}

        private double energy;

        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

        public double Energy
        {
            get { return energy;}
            private set
            {
                if (value<MinEnergy)
                    throw new Exception("not enough energy to jump");

                if (value>MaxEnergy)
                    energy = MaxEnergy;
                else
                    energy = value;
            }
        }
        public Cat(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }
        public void Jump()
        {
            Energy=Energy-JumpEnergyDrain;
        }

        public void Sleep()
        {
            Energy=Energy+SleepEnergyGain;
        }
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("knopa", Gender.Male);
        Console.WriteLine($"Name:{cat.Name}, Gender:{cat.Gender}, Energy:{cat.Energy}");

        cat.Jump();
        Console.WriteLine("After jump: " +cat.Energy);

        cat.Sleep();
        Console.WriteLine("After sleep: " +cat.Energy);
    }
}


