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
        public Ranger(string name) : base(1, 1, 7, 1, new List<WeaponType> { WeaponType.Bow }, new List<ArmorType> { ArmorType.Leather, ArmorType.Mail })
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            _heroAttributes.Strength += 1;
            _heroAttributes.Dexterity += 5;
            _heroAttributes.Intelligence += 1;
        }
    }
}
