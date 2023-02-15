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
        public Rogue(string name) : base(1, 2, 6, 1, new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            _heroAttributes.Strength += 1;
            _heroAttributes.Dexterity += 4;
            _heroAttributes.Intelligence += 1;
        }
    }
}
