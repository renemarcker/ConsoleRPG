using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name):base(1,5,2,1,new List<Items.WeaponType> { Items.WeaponType.Axe,Items.WeaponType.Hammer, Items.WeaponType.Sword}, new List<Items.ArmorType> { Items.ArmorType.Mail, Items.ArmorType.Plate})
        {
            _name = name;
        }
    }
}
