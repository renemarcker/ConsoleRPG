using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name):base(1,1,1,8,new List<Items.WeaponType> { Items.WeaponType.Staff,Items.WeaponType.Wand}, new List<Items.ArmorType> { Items.ArmorType.Cloth})
        {
            _name = name;
        }
    }
}
