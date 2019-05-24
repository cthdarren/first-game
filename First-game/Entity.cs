using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    abstract public class Entity
    {
        public int Maxhealth { get; set; }
        public int Currhealth { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Atk { get; set; }
        public string Element { get; set; }
        public int Spd { get; set; }

        abstract public int calcDamage();
        abstract public void loseHealth(int damage);
    }
}
