using ConsoleRPG.Heroes;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace UnitTests
{
    public class HeroCreationTests
    {
        #region Class Mage
        [Fact]
        public void Constructor_InitializeMageWithName_ShouldCreateMageStates()
        {
            //Arrange
            string name = "Gandalf";
            Mage whiteMage = new Mage(name);
            object[] expected = new object[]
            {
                name,
                1,

            };
            //Act
            object[] actual = new object[]
            {
                whiteMage.Name,
                whiteMage.Level,
                //whiteMage.HeroAttributes,
                //whiteMage.ValidWeaponTypes,
                //whiteMage.ValidArmorTypes
            };
            //Assert
            Assert.Equal(expected,actual);
        }
        #endregion

    }
}