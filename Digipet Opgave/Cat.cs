using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class Cat : IPet
    {

        public string Name;
        public int Hunger;
        public int Happiness;
        public int Health;

        public Cat(string name)
        {
            Name = name;
            Hunger = 50;
            Happiness = 50;
            Health = 100;
        }


        public void Feed()
        {
            Hunger = Hunger + 20;
            Hunger = Math.Clamp(Hunger, 0, 100);

            Console.WriteLine("Your pet has been fed a rare candy from the streets");
            Console.WriteLine("Hunger now:" + Hunger);
        }
        public void Play()
        {
            Happiness = Happiness + 20;
            Hunger = Hunger - 5;
            Happiness = Math.Clamp(Happiness, 0, 100);
            Hunger = Math.Clamp(Hunger, 0, 100);

            Console.WriteLine("Hunger after playing:" + Hunger);
            Console.WriteLine("Happiness after playing:" + Happiness);
        }
        public void Print()
        {
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Health: " + Health);
        }

        public void Fight()
        {
            Hunger = Hunger - 80;
            Happiness = Happiness - 20;
            Health = Health - 80;

            Hunger = Math.Clamp(Hunger, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
            Health = Math.Clamp(Health, 0, 100);

            Console.WriteLine("Your pet has fought and returned with a win!");
            Console.WriteLine("Your pet has rescived a injury while fighting!");

        }

        public void Sleep()
        {
            Hunger = Hunger - 20;
            Happiness = Happiness + 12;
            Health = Health + 100;

            Hunger = Math.Clamp(Hunger, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
            Health = Math.Clamp(Health, 0, 100);


            Console.WriteLine("Your pet has gaind more health and Happiness but is now hungry");

        }
        public void Update()
        {

        }
    }
}
