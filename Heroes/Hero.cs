using ConsoleRPG.Items;
using ConsoleRPG.Items.Enums;
using System.Text;

namespace ConsoleRPG.Heroes
{
    public abstract class Hero
    {
        protected string _name;
        protected int _level;
        protected HeroAttributes _heroAttributes = new (0,0,0);
        private HeroAttributes _damageAttributes = new(0, 0, 0);
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
            HeroAttributes damageAttributes,
            List<WeaponType> weaponProficiency,
            List<ArmorType> armorProficiency)
        { 
            _level = level;
            _heroAttributes = heroAttributes;
            _damageAttributes = damageAttributes;
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

        public decimal Damage()
        {
            Weapon equipedWeapon = (Weapon)Equipments[ItemSlot.weapon];
            int weaponDamage = 1;
            if (equipedWeapon != null) weaponDamage = equipedWeapon.Damage;
            HeroAttributes totalAttributes = TotalAttributes()*_damageAttributes;
            decimal damageAttribute = totalAttributes.Strength + totalAttributes.Dexterity + totalAttributes.Intelligence;
            decimal damage = weaponDamage * (1 + (damageAttribute / 100));
            return Decimal.Round(damage,2);
        }

        public string Display()
        {
            StringBuilder heroDisplay = new("The states of the Hero:\n\n");
            HeroAttributes totalAttributes = TotalAttributes();
            decimal damage = Damage();
            heroDisplay.AppendFormat("Name:         {0}\n",_name);
            heroDisplay.AppendFormat("Class:        {0}\n",this.GetType().Name);
            heroDisplay.AppendFormat("Level:        {0}\n", _level);
            heroDisplay.AppendFormat("Strength:     {0}\n",totalAttributes.Strength);
            heroDisplay.AppendFormat("Dexterity:    {0}\n", totalAttributes.Dexterity);
            heroDisplay.AppendFormat("Intelligence: {0}\n", totalAttributes.Intelligence);
            heroDisplay.AppendFormat("Damage:       {0}\n", damage);
            Console.WriteLine(heroDisplay);
            return heroDisplay.ToString();
        }

    }
}
