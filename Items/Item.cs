using ConsoleRPG.Items.Enums;

namespace ConsoleRPG.Items
{
    public abstract class Item
    {
        protected string _name;
        protected int _requiredLevel;
        protected ItemSlot _slot;


        public string Name { get => _name; set => _name = value; }
        public int RequiredLevel { get => _requiredLevel; set => _requiredLevel = value; }
        public ItemSlot Slot { get => _slot; set => _slot = value; }
    }
}