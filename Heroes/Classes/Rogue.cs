using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(1, new HeroAttributes(2, 6, 1), new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            HeroAttributes rogueLevelUp = new HeroAttributes(1, 4, 1);
            _heroAttributes += rogueLevelUp;
        }
    }
}
