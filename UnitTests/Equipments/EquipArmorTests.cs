using ConsoleRPG.Heroes.Classes;
using ConsoleRPG.Heroes;
using ConsoleRPG.Items.Enums;
using ConsoleRPG.Items;

namespace UnitTests.Equipments
{
    public class EquipArmorTests
    {
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

        #region Invalid Armor Type
        [Fact]
        public void EquipArmor_EquipArmorWithInvalidArmorType_ShouldThrowEquipException()
        {
            //Arrange
            Ranger jackOfAll = new ("Rene");
            Armor headArmor = new ("Plate Helmet", 1, ItemSlot.head, ArmorType.Plate, new HeroAttributes(2, 2, 0));
            //Act and Assert
            Assert.Throws<EquipException>(() => jackOfAll.EquipArmor(headArmor));
        }

        #endregion
    }
}
