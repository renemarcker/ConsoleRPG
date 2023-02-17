
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(1, new HeroAttributes(1, 7, 1), new HeroAttributes(0,1,0), new List<WeaponType> { WeaponType.Bow }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            HeroAttributes rangerLevelUp = new (1, 5, 1);
            _heroAttributes += rangerLevelUp;
        }
    }
}
