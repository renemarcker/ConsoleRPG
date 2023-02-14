using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Heroes
{
    public class Ranger : Hero
    {
        public Ranger(string name):base(1,1,7,1,new List<Items.WeaponType> { Items.WeaponType.Bow}, new List<Items.ArmorType> { Items.ArmorType.Leather, Items.ArmorType.Mail})
        {
            _name = name;
        }
    }
}
