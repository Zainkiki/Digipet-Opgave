using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class Dog : IPet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Level { get; set; }
        public bool IsDead { get; set; }

        public Dog(string name)
        {
            Name = name;
            Hunger = 50;
            Happiness = 50;
            Health = 100;
            AttackPower = 13;
            Level = 1;
        }


        public void Train()
        {
            AttackPower = AttackPower + RNG.random.Next(5, 12);
            Console.WriteLine(Name + " " + "Started tranning and gained more AttackPower");
            Thread.Sleep(2000);

            Hunger = Hunger - RNG.random.Next(30, 40);
            Console.WriteLine(Name + " " + "Is now a bit hungry");
            Thread.Sleep(2000);

            Health = Health + RNG.random.Next(2, 4);

            Happiness = Happiness + RNG.random.Next(5, 15);
            Console.WriteLine(Name + " " + "Is now very happy by becoming stronger");
            Thread.Sleep(2000);
            Console.WriteLine("You shoud check Kiwi's stats for a surprise");

            ((IPet)this).ClampValues();
        }

        public void Feed()
        {
            Console.WriteLine(Name + " " + "started eating but didn't like the food");
            Thread.Sleep(2000);
            Console.WriteLine(Name + " " + "left a mess behind needs cleanning");

            Hunger = Hunger + RNG.random.Next(5, 12);
            Happiness = Happiness - RNG.random.Next(3, 6);

            ((IPet)this).ClampValues();

        }

        public void Play()
        {
            Console.WriteLine("You took " + Name + " on a walk");
            Thread.Sleep(2000);
            Happiness = Happiness + RNG.random.Next(7, 13);
            Hunger = Hunger - RNG.random.Next(5, 9);

            ((IPet)this).ClampValues();
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " " + "is now sleeping after a long day");

            Hunger = Hunger - RNG.random.Next(10, 23);
            Happiness = Happiness + RNG.random.Next(1, 9);
            Health = Health + RNG.random.Next(40, 80);

            ((IPet)this).ClampValues();
        }
    }
}