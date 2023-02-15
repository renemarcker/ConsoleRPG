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
            //Act and Assert
            Assert.Equal(name, whiteMage.Name);
            Assert.Equal(1, whiteMage.Level);
            Assert.Equal(1, whiteMage.HeroAttributes.Strength);
            Assert.Equal(1, whiteMage.HeroAttributes.Dexterity);
            Assert.Equal(8, whiteMage.HeroAttributes.Intelligence);
        }
        #endregion

        #region Class Ranger
        [Fact]
        public void Constructor_InitializeRangerWithName_ShouldCreateRangerLevel1()
        {
            //Arrange
            string name = "Legolas";
            Ranger elvenPrince = new Ranger(name);
            //Act and Assert
            Assert.Equal(name, elvenPrince.Name);
            Assert.Equal(1, elvenPrince.Level);
            Assert.Equal(1, elvenPrince.HeroAttributes.Strength);
            Assert.Equal(7, elvenPrince.HeroAttributes.Dexterity);
            Assert.Equal(1, elvenPrince.HeroAttributes.Intelligence);
        }
        #endregion

        #region Class Rogue
        [Fact]
        public void Constructor_InitializeRogueWithName_ShouldCreateRogueLevel1()
        {
            //Arrange
            string name = "Gwaine";
            Rogue knight = new Rogue(name);
            //Act and Assert
            Assert.Equal(name, knight.Name);
            Assert.Equal(1, knight.Level);
            Assert.Equal(2, knight.HeroAttributes.Strength);
            Assert.Equal(6, knight.HeroAttributes.Dexterity);
            Assert.Equal(1, knight.HeroAttributes.Intelligence);
        }
        #endregion

        #region Class Warrior
        [Fact]
        public void Constructor_InitializeWarriorWithName_ShouldCreateWarriorLevel1()
        {
            //Arrange
            string name = "Arthur";
            Warrior king = new Warrior(name);
            //Act and Assert
            Assert.Equal(name, king.Name);
            Assert.Equal(1, king.Level);
            Assert.Equal(5, king.HeroAttributes.Strength);
            Assert.Equal(2, king.HeroAttributes.Dexterity);
            Assert.Equal(1, king.HeroAttributes.Intelligence);
        }
        #endregion

    }
}