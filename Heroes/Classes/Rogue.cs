
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(1, new HeroAttributes(2, 6, 1), new HeroAttributes(0,1,0), new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            HeroAttributes rogueLevelUp = new (1, 4, 1);
            _heroAttributes += rogueLevelUp;
        }
    }
}
