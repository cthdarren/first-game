using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    public class Enemy : Entity
{
        public Enemy(int hp, string name, int lvl, int atk, string element, int spd)
        {
            Maxhealth = hp;
            Name = name;
            Atk = atk;
            Element = element;
            Spd = spd;
        }

        public override int calcDamage()
        {
            return Atk;
        }

        public override void loseHealth(int damage)
        {
            Currhealth -= damage;
        }
    }
}
