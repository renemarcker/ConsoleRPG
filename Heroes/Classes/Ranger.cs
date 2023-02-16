using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Heroes.Classes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(1, new HeroAttributes(1, 7, 1), new List<WeaponType> { WeaponType.Bow }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            HeroAttributes rangerLevelUp = new HeroAttributes(1, 5, 1);
            _heroAttributes += rangerLevelUp;
        }
    }
}
