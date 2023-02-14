

using ConsoleRPG.Heroes;

namespace UnitTests
{
    public class LevelTests
    {
        #region Level-up Mage
        [Fact]
        public void LevelUp_MageToLevel2_ShouldReturnLevel2MageAttributes()
        {
            //Arrange
            Mage whiteMage = new Mage("Gandalf");

        }
        #endregion
        
        #region Level-up Ranger
        [Fact]
        public void LevelUp_RangerToLevel2_ShouldReturnLevel2RangerAttributes()
        {
            Ranger elvenPrince = new Ranger("Legolas");
        }

        #endregion

        #region Level-up Rogue
        [Fact]
        public void LevelUp_RogueToLevel2_ShouldReturnLevel2RogueAttributes()
        {
            Rogue knight = new Rogue("Gwaine");
        }
        #endregion

        #region Level-up Warrior
        [Fact]
        public void LevelUp_WarriorToLevel2_ShouldReturnLevel2WarriorAttributes()
        {
            Warrior king = new Warrior("Arthur");
        }
        #endregion
    }
}
