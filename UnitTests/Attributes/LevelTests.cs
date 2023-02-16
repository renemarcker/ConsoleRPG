using ConsoleRPG.Heroes;
using ConsoleRPG.Heroes.Classes;

namespace UnitTests.Attributes
{
    public class LevelTests
    {

        #region Level-up Mage
        [Fact]
        public void LevelUp_MageToLevel2_ShouldReturnLevel2MageAttributes()
        {
            //Arrange
            Mage whiteMage = new ("Gandalf");
            whiteMage.LevelUp();
            HeroAttributes expected = new (2, 2, 13);
            //Act and Assert
            Assert.Equal(2,whiteMage.Level);
            Assert.True(expected.Equals(whiteMage.HeroAttributes));
        }
        #endregion

        #region Level-up Ranger
        [Fact]
        public void LevelUp_RangerToLevel2_ShouldReturnLevel2RangerAttributes()
        {
            Ranger elvenPrince = new ("Legolas");
            elvenPrince.LevelUp();
            HeroAttributes expected = new (2, 12, 2);
            //Act and Assert
            Assert.Equal(2, elvenPrince.Level);
            Assert.True(expected.Equals(elvenPrince.HeroAttributes));
        }

        #endregion

        #region Level-up Rogue
        [Fact]
        public void LevelUp_RogueToLevel2_ShouldReturnLevel2RogueAttributes()
        {
            Rogue knight = new ("Gwaine");
            knight.LevelUp();
            HeroAttributes expected = new (3, 10, 2);
            //Act and Assert
            Assert.Equal(2, knight.Level);
            Assert.True(expected.Equals(knight.HeroAttributes));
        }
        #endregion

        #region Level-up Warrior
        [Fact]
        public void LevelUp_WarriorToLevel2_ShouldReturnLevel2WarriorAttributes()
        {
            Warrior king = new ("Arthur");
            king.LevelUp();
            HeroAttributes expected = new (8, 4, 2);
            //Act and Assert
            Assert.Equal(2, king.Level);
            Assert.True(expected.Equals(king.HeroAttributes));
        }
        #endregion
    }
}
