using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    class MidGameWeapon : IItem
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int MinimumDamage { get; set; }
        public int Price { get; set; }


        public MidGameWeapon(string name)
        {
            Name = name;
            Damage = 25;
            MinimumDamage = 12;
            Price = 50;
        }
    }
}
