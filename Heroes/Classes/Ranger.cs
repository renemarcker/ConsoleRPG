
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Ranger : Hero
    {

        /// <summary>
        /// Ranger class initiaze with:
        /// <para>Strength:1, Dexterity:7, Intelligence:1</para>
        /// <para>Damage Attribute: Dexterity (0,1,0) </para>
        /// <para>Valid weapons: Bow</para>
        /// <para>Valid armor: Leather and Mail</para>
        /// </summary>
        /// <param name="name">The given name of the hero.</param>
        public Ranger(string name) : base(1, new HeroAttributes(1, 7, 1), new HeroAttributes(0,1,0), new List<WeaponType> { WeaponType.Bow }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            // increase: strength -> +1, dexterity -> +5, intelligence -> +1
            HeroAttributes rangerLevelUp = new (1, 5, 1);
            _heroAttributes += rangerLevelUp;
        }
    }
}
