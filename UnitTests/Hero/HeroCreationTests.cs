using ConsoleRPG.Heroes;
using ConsoleRPG.Heroes.Classes;
using ConsoleRPG.Items;

namespace UnitTests.Hero
{
    public class HeroCreationTests
    {
        #region Class Mage
        [Fact]
        public void Constructor_InitializeMageWithName_ShouldCreateMageLevel1()
        {
            //Arrange
            string name = "Gandalf";
            Mage whiteMage = new Mage(name);
            HeroAttributes mageStart = new HeroAttributes(1, 1, 8);
            //Act and Assert
            Assert.Equal(name, whiteMage.Name);
            Assert.Equal(1, whiteMage.Level);
            Assert.True(mageStart.Equals(whiteMage.HeroAttributes));
        }
        #endregion

        #region Class Ranger
        [Fact]
        public void Constructor_InitializeRangerWithName_ShouldCreateRangerLevel1()
        {
            //Arrange
            string name = "Legolas";
            Ranger elvenPrince = new Ranger(name);
            HeroAttributes rangerStart = new HeroAttributes(1, 7, 1);
            //Act and Assert
            Assert.Equal(name, elvenPrince.Name);
            Assert.Equal(1, elvenPrince.Level);
            Assert.True(rangerStart.Equals(elvenPrince.HeroAttributes));
        }
        #endregion

        #region Class Rogue
        [Fact]
        public void Constructor_InitializeRogueWithName_ShouldCreateRogueLevel1()
        {
            //Arrange
            string name = "Gwaine";
            Rogue knight = new Rogue(name);
            HeroAttributes rogueStart = new HeroAttributes(2, 6, 1);
            //Act and Assert
            Assert.Equal(name, knight.Name);
            Assert.Equal(1, knight.Level);
            Assert.True(rogueStart.Equals(knight.HeroAttributes));
        }
        #endregion

        #region Class Warrior
        [Fact]
        public void Constructor_InitializeWarriorWithName_ShouldCreateWarriorLevel1()
        {
            //Arrange
            string name = "Arthur";
            Warrior king = new Warrior(name);
            HeroAttributes warriorStart = new HeroAttributes(5, 2, 1);
            //Act and Assert
            Assert.Equal(name, king.Name);
            Assert.Equal(1, king.Level);
            Assert.True(warriorStart.Equals(king.HeroAttributes));
        }
        #endregion

    }
}