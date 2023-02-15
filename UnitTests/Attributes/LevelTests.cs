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
            Mage whiteMage = new Mage("Gandalf");
            whiteMage.LevelUp();
            int level = 2;
            int[] expected = new int[] { level, 2, 2, 13 };
            //Act
            int[] actual = new int[]
            {
                whiteMage.Level,
                whiteMage.HeroAttributes.Strength,
                whiteMage.HeroAttributes.Dexterity,
                whiteMage.HeroAttributes.Intelligence
            };
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Level-up Ranger
        [Fact]
        public void LevelUp_RangerToLevel2_ShouldReturnLevel2RangerAttributes()
        {
            Ranger elvenPrince = new Ranger("Legolas");
            elvenPrince.LevelUp();
            int level = 2;
            int[] expected = new int[] { level, 2, 12, 2 };
            //Act
            int[] actual = new int[]
            {
                elvenPrince.Level,
                elvenPrince.HeroAttributes.Strength,
                elvenPrince.HeroAttributes.Dexterity,
                elvenPrince.HeroAttributes.Intelligence
            };
            //Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Level-up Rogue
        [Fact]
        public void LevelUp_RogueToLevel2_ShouldReturnLevel2RogueAttributes()
        {
            Rogue knight = new Rogue("Gwaine");
            knight.LevelUp();
            int level = 2;
            int[] expected = new int[] { level, 3, 10, 2 };
            //Act
            int[] actual = new int[]
            {
                knight.Level,
                knight.HeroAttributes.Strength,
                knight.HeroAttributes.Dexterity,
                knight.HeroAttributes.Intelligence
            };
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Level-up Warrior
        [Fact]
        public void LevelUp_WarriorToLevel2_ShouldReturnLevel2WarriorAttributes()
        {
            Warrior king = new Warrior("Arthur");
            king.LevelUp();
            int level = 2;
            int[] expected = new int[] { level, 8, 4, 2 };
            //Act
            int[] actual = new int[]
            {
                king.Level,
                king.HeroAttributes.Strength,
                king.HeroAttributes.Dexterity,
                king.HeroAttributes.Intelligence
            };
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
