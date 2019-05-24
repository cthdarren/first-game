using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    public class Player : Entity
{
        public List<Item> _inv { get; set; }
        public Item _weapon { get; set; }
        public Item _armor { get; set; }
        public int _gold { get; set; }

        public Player(int hp, string name, int atk, string element, int spd, List<Item> inv, Item wep, Item armor, int gold) : base (hp, name, atk, element, spd)
        {
            _inv = inv;
            _weapon = wep;
            _armor = armor;
            _gold = gold;
        }

        public override int calcDamage()
        {
            return _weapon._atk + _atk;
        }

        public override void loseHealth(int damage)
        {
            _currhealth -= damage;
        }
}
}
