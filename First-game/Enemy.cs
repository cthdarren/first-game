using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    public class Enemy : Entity
{
        public Enemy(int hp, string name, int lvl, int atk, string ele, int spd) : base(hp, name, lvl, atk, ele, spd)
        {

        }

        public override int calcDamage()
        {
            return _atk;
        }

        public override void loseHealth(int damage)
        {
            _currhealth -= damage;
        }
    }
}
