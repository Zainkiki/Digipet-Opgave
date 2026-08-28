using System;
using System.Collections.Generic;
using System.Net.Mail;
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
        public int Gold { get; set; }
        public bool IsDead { get; set; }
        public IItem EquipedItem { get; set; }


        public Dog(string name)
        {
            Name = name;
            Hunger = 50;
            Happiness = 50;
            Health = 100;
            AttackPower = 13;
            Level = 1;
            Gold = 1;
        }


        public void Train() 
        {
            AttackPower = AttackPower + RNG.random.Next(5, 12); // + AttackPower
            Console.WriteLine(Name + " " + "Started tranning and gained more AttackPower");
            Thread.Sleep(500);

            Hunger = Hunger - RNG.random.Next(30, 40); // - Hunger
            Console.WriteLine(Name + " " + "Is now a bit hungry");
            Thread.Sleep(500);

            Health = Health + RNG.random.Next(2, 4);

            Happiness = Happiness + RNG.random.Next(5, 15); // + Happiness
            Console.WriteLine(Name + " " + "Is now very happy by becoming stronger");
            Thread.Sleep(500);
            Console.WriteLine("You shoud check Kiwi's stats for a surprise");

            ((IPet)this).ClampValues();
        }

        public void Feed() 
        {
            Console.WriteLine(Name + " " + "started eating but didn't like the food");
            Thread.Sleep(500);
            Console.WriteLine(Name + " " + "left a mess behind needs cleanning");

            Hunger = Hunger + RNG.random.Next(40, 60); // + Hunger
            Happiness = Happiness - RNG.random.Next(3, 6); // - Happiness

            ((IPet)this).ClampValues();

        }

        public void Play()
        {
            Console.WriteLine("You took " + Name + " on a walk");
            Thread.Sleep(500);
            Happiness = Happiness + RNG.random.Next(30, 43); // + Happiness
            Hunger = Hunger - RNG.random.Next(2, 6); // - Hunger

            ((IPet)this).ClampValues();
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " " + "is now sleeping after a long day");

            Hunger = Hunger - RNG.random.Next(7, 13); // - Hunger
            Happiness = Happiness + RNG.random.Next(1, 9); // + Happiness
            Health = Health + RNG.random.Next(80, 100); // + Health

            ((IPet)this).ClampValues();
        }
    }
}