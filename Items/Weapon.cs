
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Items
{
    internal class Weapon : Item
    {
        private WeaponType _weaponType;
        private int _damage;

        public WeaponType WeaponType { get => _weaponType; }
        public int Damage { get => _damage; }

        public Weapon(string name, int requiredLevel, int damage, WeaponType weaponType)
        {
            _slot = ItemSlot.weapon;
            _name = name;
            _requiredLevel = requiredLevel;
            _damage = damage;
            _weaponType = weaponType;

        }
    }
}
