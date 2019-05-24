using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    public class Armor : Item
    {
        public int Health { get; set; }

        public Armor(string name, string element, int price, int hp)
        {
            Name = name;
            Element = element;
            Price = price;
            Health = hp;
        }
    }
}
