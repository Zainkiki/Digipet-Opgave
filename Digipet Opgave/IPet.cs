using System.Xml.Linq;

namespace Digipet_Opgave
{
    interface IPet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Level { get; set; }
        public bool IsDead { get; set; }



        public void ClampValues() // This is to set a limit to how low/Hight the stats can get / I plan to increase to limite by leveling up but thats for later maybe
        {
            AttackPower = Math.Clamp(AttackPower, 0, 100);
            Hunger = Math.Clamp(Hunger, 0, 100);
            Health = Math.Clamp(Health, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
        }

        public void Train();
        public void Feed();
        public void Play();
        public void Clean()
        {
            Console.WriteLine("Cleaned for now idk what to do with this yet");
        }
        public void Sleep();
        public void Fight(Monster monster) // this is where we introduce the monster from the mosnter class to fight our pet with a while loop I gave the monster values under the PetManger class I also added a delay of 2 seceounds between each round
        {
            Console.WriteLine(Name + " and a monster are about to fight");
            Console.WriteLine("Monster Damage: " + monster.MonsterDamage);
            Console.WriteLine("Monster HP: " + monster.MonsterHP);

            while (true)
            {
                Thread.Sleep(2000);
                monster.MonsterHP -= RNG.random.Next(AttackPower);

                Console.WriteLine("OMG " + Name + " Attacks and body slammed the monster");
                Console.WriteLine("Current Monster HP: " + monster.MonsterHP);

                if (monster.MonsterHP <= 0)
                { 
                    Level = Level + 1;
                    Hunger = Hunger + RNG.random.Next(1, 6);
                    Happiness = Happiness + RNG.random.Next(5, 12);
                    break;
                }

                Thread.Sleep(2000);
                Health -= RNG.random.Next(monster.MonsterDamage);
                Console.WriteLine("OH NOOO.... " + monster.Name + " Attacked and we got hit");
                Console.WriteLine("Current Pet HP: " + Health);

                if (Health <= 0 && !IsDead)
                {
                    Die();
                    break;
                }
            }
            ClampValues();
        }
        public void Die()
        {
            IsDead = true;

            Console.WriteLine("Your pet has died now get out");
            Thread.Sleep(2000);
            Environment.Exit(0);

        }
        public void Print() // this is a method that Prints all of the stats to the user
        {
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("AttackPower: " + AttackPower);
        }
        public void Update(object? obj) // this is a method that has a timer whice is called from PetMangaer after each 15 secends or what it ever we set it 2 it will - some of the values and if Hunger is under 20 it will also - from health
        {

            Hunger = Hunger - RNG.random.Next(1, 3);
            Happiness = Happiness - RNG.random.Next(1, 3);

            if (Hunger < 20)
            {
                Health = Health - RNG.random.Next(1, 6);
                Happiness = Happiness - RNG.random.Next(1, 4);
                Console.WriteLine(Name + " is very hungry and is losing health");
            }
            ClampValues();
        }

    }
}
