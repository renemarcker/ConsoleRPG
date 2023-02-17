using ConsoleRPG.Heroes;
using ConsoleRPG.Heroes.Classes;
using ConsoleRPG.Items.Enums;
using ConsoleRPG.Items;

namespace UnitTests.Hero
{
    public class DamageTests
    {
        #region No Weapon - level 1 classes

        #region Mage
        [Fact]
        public void Damage_CalculateDamageWithNoWeaponMage_ShouldReturnCorrect()
        {
            //Arrange
            Mage whiteMage = new("Gandalf");
            decimal damageAttribute = 8;
            decimal control = 1 * (1 + (damageAttribute / 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = whiteMage.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Ranger
        [Fact]
        public void Damage_CalculateDamageWithNoWeaponRanger_ShouldReturnCorrect()
        {
            //Arrange
            Ranger elevenPrince = new("Legolas");
            decimal damageAttribute = 7;
            decimal control = 1 * (1 + (damageAttribute / 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = elevenPrince.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Rogue
        [Fact]
        public void Damage_CalculateDamageWithNoWeaponRogue_ShouldReturnCorrect()
        {
            //Arrange
            Rogue knight = new("Gwaine");
            decimal damageAttribute = 6;
            decimal control = 1 * (1 + (damageAttribute / 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = knight.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Warrior
        [Fact]
        public void Damage_CalculateDamageWithNoWeaponWarrior_ShouldReturnCorrect()
        {
            //Arrange
            Warrior king = new("Arthur");
            decimal damageAttribute = 5;
            decimal control = 1 * (1 + (damageAttribute / 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = king.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #endregion

        #region Equip Weapon
        [Fact]
        public void Damage_EquipWeapon_ShouldReturnDamageBasedOnWeapon()
        {
            //Arrange
            Warrior codeWarrior = new("Sean");
            Weapon twinBlade = new("Bug Slayer", 1, 42, WeaponType.Hammer);
            codeWarrior.EquipWeapon(twinBlade);
            decimal damageAttribute = 5;
            decimal control = 42 * (1 + (damageAttribute / 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = codeWarrior.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Replace Equipped Weapon
        [Fact]
        public void Damage_ReplaceEquipWeapon_ShouldReturnDamageBasedOnNewWeapon()
        {
            //Arrange
            Warrior codeWarrior = new("Sean");
            Weapon twinBlade = new("Bug Slayer", 1, 42, WeaponType.Hammer);
            Weapon longSword = new("Excalibur",1,122,WeaponType.Sword);
            codeWarrior.EquipWeapon(twinBlade);
            codeWarrior.EquipWeapon(longSword);
            decimal damageAttribute = 5;
            decimal control = 122 * (1 + (damageAttribute/ 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = codeWarrior.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Equip Weapon and Armor
        [Fact]
        public void Damage_EquipWeaponAndArmor_ShouldReturnDamageBasedWeaponAndArmor()
        {
            //Arrange
            Warrior codeWarrior = new("Sean");
            Weapon longSword = new("Excalibur", 1, 122, WeaponType.Sword);
            Armor legendaryArmor = new("Milanese Plate Armor", 10, ItemSlot.body, ArmorType.Plate, new HeroAttributes(42, 20, 11));
            codeWarrior.LevelUp(); // lvl 2
            codeWarrior.LevelUp(); // lvl 3
            codeWarrior.LevelUp(); // lvl 4
            codeWarrior.LevelUp(); // lvl 5
            codeWarrior.LevelUp(); // lvl 6
            codeWarrior.LevelUp(); // lvl 7
            codeWarrior.LevelUp(); // lvl 8
            codeWarrior.LevelUp(); // lvl 9
            codeWarrior.LevelUp(); // lvl 10
            codeWarrior.EquipWeapon(longSword);
            codeWarrior.EquipArmor(legendaryArmor);
            decimal damageAttribute = 74; // Strength + weapon... (3*level+2) + 42
            decimal control = longSword.Damage * (1 + (damageAttribute / 100));
            decimal expected = Decimal.Round(control, 2);
            //Act
            decimal actual = codeWarrior.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
