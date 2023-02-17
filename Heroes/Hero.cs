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

        /// <summary>
        /// Equip an given weapon and replace if already equipped weapon.
        /// </summary>
        /// <param name="weapon">Weapon that is equipped.</param>
        /// <exception cref="EquipException">When the weapon is invalid based on weapon proficiency of the class and level.</exception>
        public void EquipWeapon(Weapon weapon)
        {
            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
                throw new EquipException("The weapon is not valid for the given class.");
            if (_level < weapon.RequiredLevel)
                throw new EquipException("The hero do not meet the required level for item.");
            _equipments[ItemSlot.weapon] = weapon;
        }
        /// <summary>
        /// Equip an given armor in its slot and replace if already equipped armor on give slot.
        /// </summary>
        /// <param name="armor">Armor that is equipped.</param>
        /// <exception cref="EquipException">When the armor is invalid based on the armor proficiency of the class and level.</exception>
        public void EquipArmor(Armor armor)
        {
            if (!ValidArmorTypes.Contains(armor.ArmorType))
                throw new EquipException("The weapon is not valid for the given class.");
            if (_level < armor.RequiredLevel)
                throw new EquipException("The hero do not meet the required level for item.");
            _equipments[armor.Slot] = armor;
        }
        /// <summary>
        /// Calculate the total attributes of the Hero based on base, the gain through level up and equipped armors.
        /// </summary>
        /// <returns>The total attributes as new Hero Attributes.</returns>
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
        /// <summary>
        /// Calculate the damage output of the hero based on equation:
        /// <para>X*(1+Y/100)</para>
        /// <para>Where:</para>
        /// <para>X = damage from the weapon and unarmed = 1 damage</para>
        /// <para>Y = damage attribute of the class</para>
        /// <returns>Total of damage as decimal rounded two decimals.</returns>
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

        /// <summary>
        /// Display the stats of the hero.
        /// </summary>
        /// <returns>name, class, level, total strength, total dexterity, total intelligence and damage.</returns>
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
