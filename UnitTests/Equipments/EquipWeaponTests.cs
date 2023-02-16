using ConsoleRPG.Heroes;
using ConsoleRPG.Heroes.Classes;
using ConsoleRPG.Items;
using ConsoleRPG.Items.Enums;

namespace UnitTests.Equipments
{
    public class EquipWeaponTests
    {

        #region Valid Weapon

        [Fact]
        public void EquipWeapon_EquipValidWeapon_ShouldEquipWeaponToSlot()
        {
            //Arrange
            Warrior codeWarrior = new Warrior("Sean");
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            codeWarrior.LevelUp();
            Weapon twinBlade = new Weapon("Bug Slayer", 10, 42, WeaponType.Hammer);
            //Act
            codeWarrior.EquipWeapon(twinBlade);
            //Assert
            Assert.Equal(twinBlade, codeWarrior.Equipments[ItemSlot.weapon]);
        }

        #endregion

        #region Invalid Level
        [Fact]
        public void EquipWeapon_EquipWeaponWithInvalidLevel_ShouldThrowEquipException()
        {
            //Arrange
            Warrior peasant = new Warrior("Rene");
            Weapon twinBlade = new Weapon("Bug Slayer", 10, 42, WeaponType.Hammer);
            //Act and Assert
            Assert.Throws<EquipException>(() => peasant.EquipWeapon(twinBlade));
        }

        #endregion

        #region Invalid Weapon Type
        [Fact]
        public void EquipWeapon_EquipWeaponWithInvalidWeaponType_ShouldThrowEquipException()
        {
            //Arrange
            Ranger jackOfAll = new Ranger("Rene");
            Weapon twinBlade = new Weapon("Bug Slayer", 10, 42, WeaponType.Hammer);
            //Act and Assert
            Assert.Throws<EquipException>(() => jackOfAll.EquipWeapon(twinBlade));
        }

        #endregion

    }
}
