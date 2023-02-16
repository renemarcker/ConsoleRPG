using ConsoleRPG.Items;
using ConsoleRPG.Items.Enums;
using System.Data;

namespace ConsoleRPG.Heroes
{
    public abstract class Hero
    {
        protected string _name;
        protected int _level;
        protected HeroAttributes _heroAttributes = new HeroAttributes(0,0,0);
        protected List<WeaponType> _validWeaponTypes = new List<WeaponType>();
        protected List<ArmorType> _validArmorTypes = new List<ArmorType>();
        protected Dictionary<ItemSlot, Item> _equipments = new Dictionary<ItemSlot, Item>()
        {
            { ItemSlot.head,null },
            { ItemSlot.body,null },
            { ItemSlot.legs,null },
            { ItemSlot.weapon,null },
        };

        public string Name { get => _name; }
        public int Level { get => _level; }
        public HeroAttributes HeroAttributes { get => _heroAttributes; }
        public Dictionary<ItemSlot, Item> Equipments { get => _equipments; }
        public List <WeaponType> ValidWeaponTypes { get => _validWeaponTypes; }
        public List <ArmorType> ValidArmorTypes { get => _validArmorTypes; }


        public Hero(
            int level,
            HeroAttributes heroAttributes,
            List<WeaponType> weaponProficiency,
            List<ArmorType> armorProficiency)
        { 
            _level = level;
            _heroAttributes = heroAttributes;
            _validWeaponTypes = weaponProficiency;
            _validArmorTypes = armorProficiency;

        }

        public abstract void LevelUp();

        public void EquipWeapon(Weapon weapon)
        {
            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
                throw new EquipException("The weapon is not valid for the given class.");
            if (_level < weapon.RequiredLevel)
                throw new EquipException("The hero do not meet the required level for item.");
            _equipments[ItemSlot.weapon] = weapon;
        }

        public void EquipArmor(Armor armor)
        {
            if (!ValidArmorTypes.Contains(armor.ArmorType))
                throw new EquipException("The weapon is not valid for the given class.");
            if (_level < armor.RequiredLevel)
                throw new EquipException("The hero do not meet the required level for item.");
            _equipments[armor.Slot] = armor;
        }

        public HeroAttributes TotalAttributes()
        {
            HeroAttributes total = new (0, 0, 0);
            total += _heroAttributes;
            foreach (var item in Equipments)
            {
                if(item.Key!=ItemSlot.weapon && item.Value!=null)
                {
                    Armor select = (Armor)item.Value;
                    total += select.ArmorAttributes;
                }
            }
            return total;
        }
    }
}
