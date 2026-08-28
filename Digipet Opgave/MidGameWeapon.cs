using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    public class MidGameWeapon : IItem
    {
        public string Name { get; set; }
        public int Damage { get; set; } 
        public int Price { get; set; }


        public MidGameWeapon(string name, int maximumdamage, int price) // hella boring 
        {
            Name = name;
            Damage = maximumdamage;
            Price = price;
        }
    }
}
