using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class PlayerCharacter
    {
        //Variables
        private string name;
        private int hitModifier;
        private int health;
        private int armor;
        private int damage;
        private string weapon;

        //Constructor
        public PlayerCharacter(string plyName, int plyHitModifier, int plyHealth, int plyArmor, int plyDamage, string plyWeap0n)
        {
            name = plyName;
            hitModifier = plyHitModifier;
            health = plyHealth;
            armor = plyArmor;
            damage = plyDamage;
            weapon = plyWeap0n;
        }

        //To string to dispaly the character stats
        public override string ToString()
        {
            return $"{name}, Health: {health}, Armor {armor}, {weapon} does {damage} with a +{hitModifier} to hit";
        }
    }
}
