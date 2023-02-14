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

    }
}