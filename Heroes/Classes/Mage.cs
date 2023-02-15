using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(1, 1, 1, 8, new List<WeaponType> { WeaponType.Staff, WeaponType.Wand }, new List<ArmorType> { ArmorType.Cloth })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            _heroAttributes.Strength += 1;
            _heroAttributes.Dexterity += 1;
            _heroAttributes.Intelligence += 5;
        }
    }
}
