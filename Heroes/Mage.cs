
namespace ConsoleRPG.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name):base(1,1,1,8,new List<Items.WeaponType> { Items.WeaponType.Staff,Items.WeaponType.Wand}, new List<Items.ArmorType> { Items.ArmorType.Cloth})
        {
            _name = name;
        }

        public override void LevelUp()
        {
            _level++;
            _heroAttributes.Strength += 1;
            _heroAttributes.Dexterity+= 1;
            _heroAttributes.Intelligence += 5;
        }
    }
}
