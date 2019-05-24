using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    abstract public class Entity
    {
        public int _maxhealth { get; set; }
        public int _currhealth { get; set; }
        public int _level { get; set; }
        public string _name { get; set; }
        public int _atk { get; set; }
        public string _element { get; set; }
        public int _spd { get; set; }

        public Entity(int hp, string name, int lvl, int atk, string ele, int spd)
        {
            _maxhealth = hp;
            _currhealth = hp;
            _name = name;
            _level = lvl;
            _atk = atk;
            _element = ele;
            _spd = spd;
        }

        abstract public int calcDamage();
        abstract public void loseHealth(int damage);
    }
}
