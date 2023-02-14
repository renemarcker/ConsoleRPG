using ConsoleRPG.Heroes;
using ConsoleRPG.Items;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace UnitTests
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
            List<WeaponType> weapons= new List<WeaponType>()
            {
                WeaponType.Staff,
                WeaponType.Wand,
            };
            List<ArmorType> armors = new List<ArmorType>()
            {
                ArmorType.Cloth
            };
            object[] expected = new object[]
            {
                name,
                1,
                1,
                1,
                8,
                weapons,
                armors
            };
            //Act
            object[] actual = new object[]
            {
                whiteMage.Name,
                whiteMage.Level,
                whiteMage.HeroAttributes.Strength,
                whiteMage.HeroAttributes.Dexterity,
                whiteMage.HeroAttributes.Intelligence,
                whiteMage.ValidWeaponTypes,
                whiteMage.ValidArmorTypes
            };
            //Assert
            Assert.Equal(expected,actual);
        }
        #endregion

        #region Class Ranger
        [Fact]
        public void Constructor_InitializeRangerWithName_ShouldCreateRangerLevel1()
        {
            //Arrange
            string name = "Legolas";
            Ranger elverPrince = new Ranger(name);
            List<WeaponType> weapons = new List<WeaponType>()
            {
                WeaponType.Bow,
            };
            List<ArmorType> armors = new List<ArmorType>()
            {
                ArmorType.Leather,
                ArmorType.Mail,
            };
            object[] expected = new object[]
            {
                name,
                1,
                1,
                7,
                1,
                weapons,
                armors
            };
            //Act
            object[] actual = new object[]
            {
                elverPrince.Name,
                elverPrince.Level,
                elverPrince.HeroAttributes.Strength,
                elverPrince.HeroAttributes.Dexterity,
                elverPrince.HeroAttributes.Intelligence,
                elverPrince.ValidWeaponTypes,
                elverPrince.ValidArmorTypes
            };
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Class Rogue
        [Fact]
        public void Constructor_InitializeRogueWithName_ShouldCreateRogueLevel1()
        {
            //Arrange
            string name = "Gwaine";
            Rogue merlinKnight = new Rogue(name);
            List<WeaponType> weapons = new List<WeaponType>()
            {
                WeaponType.Dagger,
                WeaponType.Sword,
            };
            List<ArmorType> armors = new List<ArmorType>()
            {
                ArmorType.Leather,
                ArmorType.Mail,
            };
            object[] expected = new object[]
            {
                name,
                1,
                2,
                6,
                1,
                weapons,
                armors
            };
            //Act
            object[] actual = new object[]
            {
                merlinKnight.Name,
                merlinKnight.Level,
                merlinKnight.HeroAttributes.Strength,
                merlinKnight.HeroAttributes.Dexterity,
                merlinKnight.HeroAttributes.Intelligence,
                merlinKnight.ValidWeaponTypes,
                merlinKnight.ValidArmorTypes
            };
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

    }
}