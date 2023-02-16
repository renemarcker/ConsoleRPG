using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(1, new HeroAttributes(5, 2, 1), new List<WeaponType> { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword }, new List<ArmorType> { ArmorType.Mail, ArmorType.Plate })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            HeroAttributes warriorLevelUp = new HeroAttributes(3, 2, 1);
            _heroAttributes += warriorLevelUp;
        }
    }
}
