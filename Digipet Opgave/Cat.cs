using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class Cat : IPet
    {
        static Random rnd = new Random();
        public string Name;
        public int Hunger;
        public int Happiness;
        public int Health;
        public int AttackPower;

        public Cat(string name)
        {
            Name = name;
            Hunger = 50;
            Happiness = 50; 
            Health = 100;
            AttackPower = 13;
        }

        public void ClampValues()
        {

            AttackPower = Math.Clamp(AttackPower, 0, 100);
            Hunger = Math.Clamp(Hunger, 0, 100);
            Health = Math.Clamp(Health, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
        }

        public void Train()
        {
            AttackPower = AttackPower + rnd.Next(0, 10);
            Hunger = Hunger - rnd.Next(8, 12);
            Health = Health + rnd.Next(2, 4);
            Happiness = Happiness + rnd.Next(1, 3);

            ClampValues();

            Console.WriteLine("You shoud check your pets stats for a surprise");
        }

        public void Feed()
        {

            Hunger = Hunger + rnd.Next(10, 20);
            AttackPower = AttackPower - rnd.Next(0, 2);

            ClampValues();


            Console.WriteLine(Name + "has been fed a rare candy from the streets");
            Console.WriteLine(Name + "has become fat and lost some of his attakc power");
        }

        public void Play()
        {

            Happiness = Happiness + rnd.Next(3, 13);
            Hunger = Hunger - rnd.Next(0, 4);

            ClampValues();

            Console.WriteLine("Played with " + Name);

        }
        public void Print()
        {
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("AttackPower: " + AttackPower);
        }
        public void Fight()
        {
            if (AttackPower > 30)
            {
                Console.WriteLine(Name +"has returned from fighting monsters");
                Console.WriteLine(Name +"stats has imporved");
                Console.WriteLine("He has gaind more EXP // I have yet to add EXP");
                Console.WriteLine("He has gaind more items // I have yet to add items");

                AttackPower = AttackPower + rnd.Next(0, 9);
                Hunger = Hunger - rnd.Next(1, 16);
                Happiness = Happiness + rnd.Next(1, 25);
                Health = Health + rnd.Next(1, 8);
            }

            else if (AttackPower <= 30)
            {
                Console.WriteLine(Name + "has returned after a defeat");
                Console.WriteLine(Name + "stats has decresed");
                Console.WriteLine(Name + "has lost EXP");
                Console.WriteLine("Something with broken items or something");

                AttackPower = AttackPower - rnd.Next(3, 12);
                Hunger = Hunger - rnd.Next(60, 80);
                Happiness = Happiness - rnd.Next(1, 25);
                Health = Health - rnd.Next(60, 80);
            }

            AttackPower = Math.Clamp(AttackPower, 0, 100);
            Hunger = Math.Clamp(Hunger, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
            Health = Math.Clamp(Health, 0, 100);

        }
        public void Sleep()
        {

            Hunger = Hunger - rnd.Next(10, 23);
            Happiness = Happiness + rnd.Next(1, 9);
            Health = Health + rnd.Next(40, 80);

            Hunger = Math.Clamp(Hunger, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
            Health = Math.Clamp(Health, 0, 100);


            Console.WriteLine(Name + "has gaind more health and Happiness but is now hungry");
        }
        public void Update(object? obj)
        {

            Hunger = Hunger - rnd.Next(1, 3);
            Happiness = Happiness - rnd.Next(1, 3);

            if (Hunger < 20)
            {
                Health = Health - rnd.Next(1, 6);
                Happiness = Happiness - rnd.Next(1, 4);
                Console.WriteLine(Name + "is very hungry and is losing health");
            }
            Hunger = Math.Clamp(Hunger, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
            Health = Math.Clamp(Health, 0, 100);
        }
    }
}