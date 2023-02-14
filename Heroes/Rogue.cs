using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Heroes
{
    public class Rogue : Hero
    {
        public Rogue(string name):base(1,2,6,1,new List<Items.WeaponType> { Items.WeaponType.Dagger, Items.WeaponType.Sword}, new List<Items.ArmorType> { Items.ArmorType.Leather, Items.ArmorType.Mail})
        {
            _name = name;
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
