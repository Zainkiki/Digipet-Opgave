namespace Digipet_Opgave
{
    class Pet
    {
        static Random rnd = new Random();
        public string Name;
        public int Hunger;
        public int Happiness;
        public int Health;
        public int AttackPower;
        public int Level;

        public virtual void PlaySound()
        { 

        }

        public Pet(string name)
        {
            Name = name;
            Hunger = 50;
            Happiness = 50;
            Health = 100;
            AttackPower = 13;
            Level = 1;
        }

        public void ClampValues() // This is to set a limit to how low/Hight the stats can get / I plan to increase to limite by leveling up but thats for later maybe
        {

            AttackPower = Math.Clamp(AttackPower, 0, 100);
            Hunger = Math.Clamp(Hunger, 0, 100);
            Health = Math.Clamp(Health, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
        }

        public void Train() // a method to increase the pets stats by "training " your pet to incrase some of the stats by a random number()
        {
            AttackPower = AttackPower + rnd.Next(0, 10);
            Hunger = Hunger - rnd.Next(8, 12);
            Health = Health + rnd.Next(2, 4);
            Happiness = Happiness + rnd.Next(1, 3);

            ClampValues();

            Console.WriteLine("You shoud check your pets stats for a surprise");
        }

        public void Feed() // Same as the other methods above 
        {

            Hunger = Hunger + rnd.Next(10, 20);
            AttackPower = AttackPower - rnd.Next(0, 2);

            ClampValues();


            Console.WriteLine(Name + " has been fed a rare candy from the streets");
            Console.WriteLine(Name + " has become fat and lost some of his attakc power");
        }

        public void Play() // Same as the others methods above
        {

            Happiness = Happiness + rnd.Next(3, 13);
            Hunger = Hunger - rnd.Next(0, 4);

            ClampValues();

            Console.WriteLine("Played with " + Name);
            PlaySound();
        }
        public void Print() // this is a method that Prints all of the stats to the user
        {
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("AttackPower: " + AttackPower);
        }
        public void Fight(Monster monster) // this is where we introduce the monster from the mosnter class to fight our pet with a while loop I gave the monster values under the PetManger class I also added a delay of 2 seceounds between each round
        {
            Console.WriteLine(Name + " and a monster are about to fight");
            Console.WriteLine("Monster Damage: " + monster.MonsterDamage);
            Console.WriteLine("Monster HP: " + monster.MonsterHP);

            while (true)
            {
                Thread.Sleep(2000);
                monster.MonsterHP -= rnd.Next(AttackPower);

                Console.WriteLine("OMG " + Name + " Attacks and hits the monster");
                Console.WriteLine("Current Monster HP: " + monster.MonsterHP);

                if (monster.MonsterHP <= 0)
                    break;
                Hunger = Hunger + rnd.Next(1, 6);
                Happiness = Happiness + rnd.Next(5, 12);
                Level = Level + 1;

                Thread.Sleep(2000);
                Health -= rnd.Next(monster.MonsterDamage);
                Console.WriteLine("OH NOOO.... " + monster.Name + " Attacked and we got hit");
                Console.WriteLine("Current Pet HP: " + Health);

                if (Health <= 0)
                    break;
                Hunger = Hunger - rnd.Next(4, 8);
                Happiness = Happiness - rnd.Next(12, 20);
            }
            ClampValues();
        }
        public void Sleep()
        {

            Hunger = Hunger - rnd.Next(10, 23);
            Happiness = Happiness + rnd.Next(1, 9);
            Health = Health + rnd.Next(40, 80);

            ClampValues();


            Console.WriteLine(Name + " has gaind more health and Happiness but is now hungry");
        }
        public void Update(object? obj) // this is a method that has a timer whice is called from PetMangaer after each 15 secends or what it ever we set it 2 it will - some of the values and if Hunger is under 20 it will also - from health
        {

            Hunger = Hunger - rnd.Next(1, 3);
            Happiness = Happiness - rnd.Next(1, 3);

            if (Hunger < 20)
            {
                Health = Health - rnd.Next(1, 6);
                Happiness = Happiness - rnd.Next(1, 4);
                Console.WriteLine(Name + " is very hungry and is losing health");
            }
            ClampValues();
        }
    }
}
