using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    public class EndGameWeapon : IItem
    {
        public string Name { get; set; }
        public int Damage { get; set; } 
        public int Price { get; set; }


        public EndGameWeapon(string name, int maximumdamage, int price)
        {
            Name = name;
            Damage = maximumdamage;
            Price = price;
        }
    }
}
