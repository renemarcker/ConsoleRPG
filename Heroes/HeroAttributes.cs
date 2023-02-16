namespace ConsoleRPG.Heroes
{
    public class HeroAttributes
    {
        private int _strength;
        private int _dexterity;
        private int _intelligence;

        public HeroAttributes(int strength, int dexterity, int intelligence)
        {
            _strength = strength;
            _dexterity = dexterity;
            _intelligence= intelligence;
        }

        public static HeroAttributes operator +(HeroAttributes lhs, HeroAttributes rhs)
        {
            return new HeroAttributes(lhs._strength + rhs._strength, lhs._dexterity + rhs._dexterity, lhs._intelligence + rhs._intelligence);
        }

        public override bool Equals(object? obj)
        {
            return obj is HeroAttributes heroAttributes &&
                _strength == heroAttributes._strength &&
                _dexterity == heroAttributes._dexterity &&
                _intelligence == heroAttributes._intelligence;
        }
    }
}