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
        public int RewardEXP;


        public Monster(string name, int monsterDamage, int monsterHP, int rewardEXP)
        {
            Name = name;
            MonsterDamage = monsterDamage;
            MonsterHP = monsterHP;
            RewardEXP = rewardEXP;
        }
        // Monsters that have health, Attack, HP
        // Drops chance
        // Level incrase
    }
}
