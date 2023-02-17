
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Rogue : Hero
    {
        /// <summary>
        /// Rogue class initiaze with:
        /// <para>Strength:2, Dexterity:6, Intelligence:1</para>
        /// <para>Damage Attribute: Dexterity (0,1,0) </para>
        /// <para>Valid weapons: Dagger and Sword</para>
        /// <para>Valid armor: Leather and Mail</para>
        /// </summary>
        /// <param name="name">The given name of the hero.</param>
        public Rogue(string name) : base(1, new HeroAttributes(2, 6, 1), new HeroAttributes(0,1,0), new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            // increase: strength -> +1, dexterity -> +4, intelligence -> +1
            HeroAttributes rogueLevelUp = new (1, 4, 1);
            _heroAttributes += rogueLevelUp;
        }
    }
}
