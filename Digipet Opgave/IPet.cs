using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Digipet_Opgave
{
    public interface IPet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public bool IsDead { get; set; }



        public void ClampValues() // a limit to how high and low pets stats can get 
        {
            AttackPower = Math.Clamp(AttackPower, 0, Level * 100);
            Hunger = Math.Clamp(Hunger, 0, 100);
            Health = Math.Clamp(Health, 0, 100);
            Happiness = Math.Clamp(Happiness, 0, 100);
        }

        public void Train(); // in Cat/Dog Class
        public void Feed(); // in Cat/Dog Class
        public void Play(); // in Cat/Dog Class
        public void Sleep(); // Under Cat/Dog Class
        public void RecieveItem(IItem item) 
        {
            
        }
        public void Fight(Monster monster) 
        {

            //Encounter the mosnters
            Console.WriteLine(Name + " and a monster are about to fight");
            Console.WriteLine("Monster Damage: " + monster.MonsterDamage);
            Console.WriteLine("Monster HP: " + monster.MonsterHP);

            while (true) // while loop it will keep on running till one of the condations is meet eaither pet dies or monster dies 
            {
                Thread.Sleep(2000);
                monster.MonsterHP -= RNG.random.Next(AttackPower); // Pet attacks the mosnter with a random number from 0 to what ever my attack is 

                Console.WriteLine("OMG " + Name + " Attacks and body slammed the monster");
                Console.WriteLine("Current Monster HP: " + monster.MonsterHP);

                if (monster.MonsterHP <= 0) // if Monster dies the pet gets a level up and stats
                { 
                    Level = Level + 1;
                    Hunger = Hunger + RNG.random.Next(1, 6);
                    Happiness = Happiness + RNG.random.Next(5, 12);
                    break;
                }

                Thread.Sleep(2000);
                Health -= RNG.random.Next(monster.MonsterDamage); // Monster attacks the pet with a random number between 0 and 12
                Console.WriteLine("OH NOOO.... " + monster.Name + " Attacked and we got hit");
                Console.WriteLine("Current Pet HP: " + Health);

                if (Health <= 0 && !IsDead) // if Monster wins the whole console shuts down 
                {
                    Die();
                    break;
                }
            }
            ClampValues();
        }
        public void Die() // a method to shut down the whole console 
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
        public void Update(object? obj) // timer called from PetManger with each round it drops my Hunger and Happiness 
        {

            Hunger = Hunger - RNG.random.Next(1, 3);
            Happiness = Happiness - RNG.random.Next(1, 3);

            if (Hunger < 20) // if Hunger is under 20 I start taking damage 
            {
                Health = Health - RNG.random.Next(1, 6);
                Console.WriteLine(Name + " is very hungry and is losing health");
            }
            ClampValues();
        }

    }
}
