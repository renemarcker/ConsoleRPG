
using ConsoleRPG.Items.Enums;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace ConsoleRPG.Heroes.Classes
{
    public class Warrior : Hero
    {
        /// <summary>
        /// Warrior class initiaze with:
        /// <para>Strength:5, Dexterity:2, Intelligence:1</para>
        /// <para>Damage Attribute: Strength (1,0,0) </para>
        /// <para>Valid weapons: Axe, Hammer and Sword</para>
        /// <para>Valid armor: Mail and Plate</para>
        /// </summary>
        /// <param name="name">The given name of the hero.</param>
        public Warrior(string name) : base(1, new HeroAttributes(5, 2, 1), new HeroAttributes(1,0,0), new List<WeaponType> { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword }, new List<ArmorType> { ArmorType.Mail, ArmorType.Plate })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            // increase: strength -> +3, dexterity -> +2, intelligence -> +1
            HeroAttributes warriorLevelUp = new (3, 2, 1); 
            _heroAttributes += warriorLevelUp;
        }
    }
}
