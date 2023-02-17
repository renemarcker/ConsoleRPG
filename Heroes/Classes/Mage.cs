using ConsoleRPG.Items;
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(1, new HeroAttributes(1, 1, 8), new HeroAttributes(0,0,1), new List<WeaponType> { WeaponType.Staff, WeaponType.Wand }, new List<ArmorType> { ArmorType.Cloth })
        {
            _name = name;
        }
        public override void LevelUp()
        {
            _level++;
            HeroAttributes mageLevelUp = new (1, 1, 5);
            _heroAttributes += mageLevelUp;
        }

    }

}
