using ConsoleRPG.Items;
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Mage : Hero
    {
        /// <summary>
        /// Mage class initiaze with:
        /// <para>Strength:1, Dexterity:1, Intelligence:8</para>
        /// <para>Damage Attribute: Intelligence (0,0,1) </para>
        /// <para>Valid weapons: Staff and Wand</para>
        /// <para>Valid armor: Cloth</para>
        /// </summary>
        /// <param name="name">The given name of the hero.</param>
        public Mage(string name) : base(1, new HeroAttributes(1, 1, 8), new HeroAttributes(0,0,1), new List<WeaponType> { WeaponType.Staff, WeaponType.Wand }, new List<ArmorType> { ArmorType.Cloth })
        {
            _name = name;
        }
        public override void LevelUp()
        {
            _level++;
            // increase: strength -> +1, dexterity -> +1, intelligence -> +5
            HeroAttributes mageLevelUp = new (1, 1, 5);
            _heroAttributes += mageLevelUp;
        }

    }

}
