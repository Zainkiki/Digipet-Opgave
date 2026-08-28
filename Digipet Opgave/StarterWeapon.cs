using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    public class StarterWeapon : IItem
    {
        public string Name { get; set; }
        public int Damage { get; set; } 
        public int Price { get; set; }


        public StarterWeapon(string name, int maximumdamage, int price)
        {
            Name = name;
            Damage = maximumdamage;
            Price = price;
        }
    }
}
