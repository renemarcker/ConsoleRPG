
using ConsoleRPG.Heroes;
using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Items
{
    public class Armor : Item
    {
        private ArmorType _armorType;
        private HeroAttributes _armorAttributes = new HeroAttributes();

        public ArmorType ArmorType { get => _armorType;  }
        public HeroAttributes ArmorAttributes { get => _armorAttributes; }

        public Armor(string name, int requiredLevel, ItemSlot slot, ArmorType armorType, int strength, int dexterity, int intelligence)
        {
            _name = name;
            _requiredLevel = requiredLevel;
            _slot = slot;
            _armorType = armorType;
            _armorAttributes.Strength = strength;
            _armorAttributes.Dexterity = dexterity;
            _armorAttributes.Intelligence = intelligence;
        }
    }
}
