using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Monster
    {
        //Variables
        private string name;
        private int hitModifier;
        private int health;
        private int armor;
        private int damage;
        private string weapon;

        //Contructor
        public Monster(string mstName, int mstHitModifier, int mstHealth, int mstArmor, int mstDamage, string mstWeapon)
        {
            name = mstName;
            hitModifier = mstHitModifier;
            health = mstHealth;
            armor = mstArmor;
            damage = mstDamage;
            weapon = mstWeapon;
        }


    }
}
