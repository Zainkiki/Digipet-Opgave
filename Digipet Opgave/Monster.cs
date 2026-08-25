using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class Monster
    {
        static Random mrnd = new Random();
        public string Name;
        public int HP;
        public int AttackPower;

        public Monster(string name)
        {
            Name = name;
            HP = mrnd.Next(200, 300);
            AttackPower = mrnd.Next(12, 15);
        }
        // Monsters that have health, Attack, HP
        // Drops chance
        // Level incrase
    }
}
