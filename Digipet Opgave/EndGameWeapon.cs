using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class EndGameWeapon : IItem
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int MinimumDamage { get; set; }
        public int Price { get; set; }


        public EndGameWeapon(string name)
        {
            Name = name;
            Damage = 50;
            MinimumDamage = 35;
            Price = 150;
        }
    }
}
