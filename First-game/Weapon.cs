using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    public class Weapon : Item
    {
        public int Atk { get; set; }

        public Weapon(string name, string element, int price, int atk)
        {
            Name = name;
            Element = element;
            Price = price;
            Atk = atk;
        }
    }
}
