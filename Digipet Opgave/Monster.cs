using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class Monster
    {
        public string Name;
        public int MonsterDamage;
        public int MonsterHP;


        public Monster(string name, int monsterDamage, int monsterHP)
        {
            Name = name;
            MonsterDamage = monsterDamage;
            MonsterHP = monsterHP;
        }
        // Monsters that have health, Attack, HP
        // Drops chance
        // Level incrase
    }
}
