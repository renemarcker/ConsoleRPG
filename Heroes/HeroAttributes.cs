namespace ConsoleRPG.Heroes
{
    public class HeroAttributes
    {
        private int _strength;
        private int _dexterity;
        private int _intelligence;

        public int Strength { get => _strength; }
        public int Dexterity { get => _dexterity;  }
        public int Intelligence { get => _intelligence; }

        public HeroAttributes(int strength, int dexterity, int intelligence)
        {
            _strength = strength;
            _dexterity = dexterity;
            _intelligence= intelligence;
        }
        /// <summary>
        /// Override method for adding two HeroAttibutes.
        /// </summary>
        /// <param name="lhs"> The left hand side in the equation</param>
        /// <param name="rhs"> The right hand side in the equation</param>
        /// <returns>New HeroAttributes, where each attribute is the sum of the corresponding attributes from lhs and rhs.</returns>
        public static HeroAttributes operator +(HeroAttributes lhs, HeroAttributes rhs)
        {
            return new HeroAttributes(lhs._strength + rhs._strength, lhs._dexterity + rhs._dexterity, lhs._intelligence + rhs._intelligence);
        }

        /// <summary>
        /// Override method for multiplication of two HeroAttibutes.
        /// </summary>
        /// <param name="lhs"> The left hand side in the equation</param>
        /// <param name="rhs"> The right hand side in the equation</param>
        /// <returns>New HeroAttributes, where each attribute is the product of the corresponding attributes from lhs and rhs.</returns>
        public static HeroAttributes operator *(HeroAttributes lhs, HeroAttributes rhs)
        {
            return new HeroAttributes(lhs._strength * rhs._strength, lhs._dexterity * rhs._dexterity, lhs._intelligence * rhs._intelligence);
        }

        /// <summary>
        /// Override method to compare two HeroAttributes.
        /// </summary>
        /// <param name="obj">Should be an HeroAttributes</param>
        /// <returns>True if the attributes(strength, dexterity and intelligence) is same of HeroAttributes</returns>
        public override bool Equals(object? obj)
        {
            return obj is HeroAttributes heroAttributes &&
                _strength == heroAttributes._strength &&
                _dexterity == heroAttributes._dexterity &&
                _intelligence == heroAttributes._intelligence;
        }
    }
}