using ConsoleRPG.Heroes.Classes;
using ConsoleRPG.Heroes;
using ConsoleRPG.Items.Enums;
using ConsoleRPG.Items;
using Xunit;

namespace UnitTests.Equipments
{
    public class EquipArmorTests
    {


        #region Test Armor slots

        #region Valid Armor body
        [Fact]
        public void EquipArmor_EquipValidArmorBody_ShouldEquipArmorToBodySlot()
        {
            //Arrange
            Warrior peasant = new ("Rene");
            Armor bodyArmor = new ("Plate Chest",1, ItemSlot.body, ArmorType.Plate, new HeroAttributes(5,1,0));
            //Act
            peasant.EquipArmor(bodyArmor);
            //Assert
            Assert.Equal(bodyArmor, peasant.Equipments[ItemSlot.body]);
        }
        #endregion

        #region Valid Armor Legs
        [Fact]
        public void EquipArmor_EquipValidArmorLegs_ShouldEquipArmorToLegsSlot()
        {
            //Arrange
            Warrior peasant = new ("Rene");
            Armor legsArmor = new ("Plate Pants", 1, ItemSlot.legs, ArmorType.Plate, new HeroAttributes(2, 2, 0));
            //Act
            peasant.EquipArmor(legsArmor);
            //Assert
            Assert.Equal(legsArmor, peasant.Equipments[ItemSlot.legs]);
        }
        #endregion

        #region Valid Armor Head
        [Fact]
        public void EquipArmor_EquipValidArmorHead_ShouldEquipArmorToHeadSlot()
        {
            //Arrange
            Warrior peasant = new ("Rene");
            Armor headArmor = new ("Plate Helmet", 1, ItemSlot.head, ArmorType.Plate, new HeroAttributes(2, 2, 0));
            //Act
            peasant.EquipArmor(headArmor);
            //Assert
            Assert.Equal(headArmor, peasant.Equipments[ItemSlot.head]);
        }
        #endregion
        #endregion



        #region Valid armor types in classes

        #region Mage
        [Theory]
        [InlineData(ArmorType.Cloth)]
        public void EquipArmor_EquipValidArmorMage_ShouldEquipArmorToMage(ArmorType armorType)
        {
            //Arrange
            Mage whiteMage = new("Gandalf");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            //Act
            whiteMage.EquipArmor(bodyArmor);
            //Assert
            Assert.Equal(bodyArmor, whiteMage.Equipments[ItemSlot.body]);
        }
        #endregion

        #region Ranger
        [Theory]
        [InlineData(ArmorType.Leather)]
        [InlineData(ArmorType.Mail)]
        public void EquipArmor_EquipValidArmorRanger_ShouldEquipArmorToRanger(ArmorType armorType)
        {
            //Arrange
            Ranger elvenPrince = new("Legolas");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            //Act
            elvenPrince.EquipArmor(bodyArmor);
            //Assert
            Assert.Equal(bodyArmor, elvenPrince.Equipments[ItemSlot.body]);
        }
        #endregion

        #region Rogue
        [Theory]
        [InlineData(ArmorType.Leather)]
        [InlineData(ArmorType.Mail)]
        public void EquipArmor_EquipValidArmorRogue_ShouldEquipArmorToRogue(ArmorType armorType)
        {
            //Arrange
            Rogue knight = new("Gwaine");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            //Act
            knight.EquipArmor(bodyArmor);
            //Assert
            Assert.Equal(bodyArmor, knight.Equipments[ItemSlot.body]);
        }
        #endregion

        #region Warrior
        [Theory]
        [InlineData(ArmorType.Mail)]
        [InlineData(ArmorType.Plate)]
        public void EquipArmor_EquipValidArmorWarrior_ShouldEquipArmorToWarrior(ArmorType armorType)
        {
            //Arrange
            Warrior king = new("Arthur");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            //Act
            king.EquipArmor(bodyArmor);
            //Assert
            Assert.Equal(bodyArmor, king.Equipments[ItemSlot.body]);
        }
        #endregion

        #endregion



        #region Invalid Armor Type
        #region Mage
        [Theory]
        [InlineData(ArmorType.Leather)]
        [InlineData(ArmorType.Mail)]
        [InlineData(ArmorType.Plate)]
        public void EquipArmor_EquipInvalidArmorMage_ShouldThrowEquipException(ArmorType armorType)
        {
            //Arrange
            Mage whiteMage = new("Gandalf");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            // Act and Assert
            Assert.Throws<EquipException>(() => whiteMage.EquipArmor(bodyArmor));
        }
        #endregion

        #region Ranger
        [Theory]
        [InlineData(ArmorType.Cloth)]
        [InlineData(ArmorType.Plate)]
        public void EquipArmor_EquipInvalidArmorRanger_ShouldThrowEquipException(ArmorType armorType)
        {
            //Arrange
            Ranger knight = new("Legolas");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            // Act and Assert
            Assert.Throws<EquipException>(() => knight.EquipArmor(bodyArmor));
        }
        #endregion

        #region Rogue
        [Theory]
        [InlineData(ArmorType.Cloth)]
        [InlineData(ArmorType.Plate)]
        public void EquipArmor_EquipInvalidArmorRogue_ShouldThrowEquipException(ArmorType armorType)
        {
            //Arrange
            Rogue knight = new("Gwaine");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            // Act and Assert
            Assert.Throws<EquipException>(() => knight.EquipArmor(bodyArmor));
        }
        #endregion

        #region Warrior
        [Theory]
        [InlineData(ArmorType.Cloth)]
        [InlineData(ArmorType.Leather)]
        public void EquipArmor_EquipInvalidArmorWarrior_ShouldThrowEquipException(ArmorType armorType)
        {
            //Arrange
            Warrior king = new("Arthur");
            Armor bodyArmor = new("Common Chest", 1, ItemSlot.body, armorType, new HeroAttributes(1, 1, 1));
            // Act and Assert
            Assert.Throws<EquipException>(() => king.EquipArmor(bodyArmor));
        }
        #endregion

        #endregion




        #region Invalid Level
        [Fact]
        public void EquipArmor_EquipArmorWithInvalidLevel_ShouldThrowEquipException()
        {
            //Arrange
            Warrior peasant = new ("Rene");
            Armor headArmor = new ("Plate Helmet", 10, ItemSlot.head, ArmorType.Plate, new HeroAttributes(2, 2, 0));
            //Act and Assert
            Assert.Throws<EquipException>(() => peasant.EquipArmor(headArmor));
        }

        #endregion

    }
}
