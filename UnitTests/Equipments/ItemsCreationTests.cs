﻿using ConsoleRPG.Items;
using ConsoleRPG.Items.Enums;

namespace UnitTests.Equipments
{
    public class ItemsCreationTests
    {
        #region Create Armor
        [Fact]
        public void Constructor_GenericArmor_ShouldCreateArmorCorrectly()
        {
            //Arrange
            string name = "Common Plate Chest";
            int requiredLevel = 2;
            ItemSlot itemSlot = ItemSlot.body;
            ArmorType armorType = ArmorType.Plate;
            int strength = 1;
            int dexterity = 0;
            int intelligence = 0;
            //Act
            Armor commonBodyPlate = new Armor(name, requiredLevel, itemSlot, armorType, strength, dexterity, intelligence);
            //Assert
            Assert.Equal(name,commonBodyPlate.Name);
            Assert.Equal(requiredLevel, commonBodyPlate.RequiredLevel);
            Assert.Equal(itemSlot, commonBodyPlate.Slot);
            Assert.Equal(armorType, commonBodyPlate.ArmorType);
            Assert.Equal(strength, commonBodyPlate.ArmorAttributes.Strength);
            Assert.Equal(dexterity, commonBodyPlate.ArmorAttributes.Dexterity);
            Assert.Equal(intelligence, commonBodyPlate.ArmorAttributes.Intelligence);
        }
        #endregion

        #region Create Weapon
        [Fact]
        public void Constructor_GenericWeapon_ShouldCreateWeaponCorrectly()
        {
            //Arrange
            string name = "Orc Slayer";
            int requiredLevel = 10;
            WeaponType weaponType = WeaponType.Axe;
            int dmg = 45;
            //Act
            Weapon legendaryAxe = new Weapon(name, requiredLevel, dmg, weaponType);
            //Assert
        }
        #endregion
    }
}
