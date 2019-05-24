using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_game
{
    public class Player : Entity
{
        public List<Item> Inv { get; set; }
        public Weapon EqWep { get; set; }
        public Armor EqArmor { get; set; }
        public int Gold { get; set; }

        public Player(int hp, string name, int atk, string element, int spd, List<Item> inv, int gold)
        {
            Maxhealth = hp;
            Name = name;
            Atk = atk;
            Element = element;
            Spd = spd;
            Inv = inv;
            Gold = gold;
        }

        public override int calcDamage()
        {
            return EqWep.Atk + Atk;
        }

        public override void loseHealth(int damage)
        {
            Currhealth -= damage;
        }

        public void equipWeapon(Weapon item)
        {
            EqWep = item;
        }

        public void equipArmor(Armor item)
        {
            EqArmor = item;
        }
}
}
