using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class Monster
    {


        public string Name;
        public int HP;
        public int AttackPower;

        public Monster(string name)
        {
            Name = name;
            HP = 300;
            AttackPower = 25;
        }
        // Monsters that have health, Attack, HP
        // Drops chance
        // Level incrase
    }
}
