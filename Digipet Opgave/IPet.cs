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
        IItem EquipedItem { get; set; }



        public void ClampValues() // a limit to how high and low pets stats can get 
        {
            AttackPower = Math.Clamp(AttackPower, 0, Level * 100);
            Hunger = Math.Clamp(Hunger, 0, Level * 100);
            Health = Math.Clamp(Health, 0, Level * 100);
            Happiness = Math.Clamp(Happiness, 0, Level * 100);
        }
        public void Train(); // in Cat/Dog Class
        public void Feed(); // in Cat/Dog Class
        public void Play(); // in Cat/Dog Class
        public void Sleep(); // Under Cat/Dog Class
        public void RecieveItem(IItem item) 
        {
            EquipedItem = item;
        }

        public int GetDamage()
        {
            if (EquipedItem != null)
            {
                return AttackPower + EquipedItem.Damage;
            }
            return AttackPower;
        }
        public void Fight(Monster monster) 
        {
            monster.MonsterDamage = monster.MonsterDamage * Level;
            monster.MonsterHP = monster.MonsterHP * Level;

            //Encounter the mosnters
            Console.WriteLine(Name + " and a monster are about to fight");
            Console.WriteLine("Monster Damage: " + monster.MonsterDamage);
            Console.WriteLine("Monster HP: " + monster.MonsterHP);

            while (true) // while loop it will keep on running till one of the condations is meet eaither pet dies or monster dies 
            {
                Thread.Sleep(500);
                monster.MonsterHP -= GetDamage(); // Pet attacks the mosnter 

                Console.WriteLine("OMG " + Name + " Is attacking like crazy");
                Console.WriteLine("Current Monster HP: " + monster.MonsterHP);

                if (monster.MonsterHP <= 0) // if Monster dies the pet gets a level up and stats
                { 
                    Level = Level + 1;
                    Hunger = Hunger + RNG.random.Next(1, 6);
                    Happiness = Happiness + RNG.random.Next(5, 12);
                    Gold = Gold + 50;
                    break;
                }

                Thread.Sleep(500);
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
        void ClampMonsterValues()
        {

        }


        public void Die() // a method to shut down the whole console 
        {
            IsDead = true;

            Console.WriteLine("Your pet is dead now get out");
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
            Console.WriteLine("Gold: " + Gold);
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
