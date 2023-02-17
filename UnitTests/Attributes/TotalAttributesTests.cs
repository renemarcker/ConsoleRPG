using ConsoleRPG.Heroes.Classes;
using ConsoleRPG.Heroes;
using ConsoleRPG.Items.Enums;
using ConsoleRPG.Items;

namespace UnitTests.Attributes
{
    public class TotalAttributesTests
    {

        #region Unarmed
        [Fact]
        public void TotalAttributes_Unarmed_ShouldReturnBaseAttributes()
        {
            //Arrange
            Warrior peasant = new("Rene");
            HeroAttributes expected = peasant.HeroAttributes;
            // Act
            HeroAttributes actual = peasant.TotalAttributes(); // = (5,2,1)
            //Assert
            Assert.True(expected.Equals(actual));
        }
        #endregion

        #region One equiped armor
        [Fact]
        public void TotalAttributes_EquipOneArmor_ShouldReturnCalculatedTotalAttributes()
        {
            //Arrange
            Warrior peasant = new("Rene");
            HeroAttributes bodyArmorAttributes = new HeroAttributes(5, 1, 0);
            Armor bodyArmor = new("Plate Chest", 1, ItemSlot.body, ArmorType.Plate, bodyArmorAttributes);
            peasant.EquipArmor(bodyArmor);
            HeroAttributes expected = peasant.HeroAttributes + bodyArmorAttributes; // = (10,3,1)
            // Act
            HeroAttributes actual = peasant.TotalAttributes();
            //Assert
            Assert.True(expected.Equals(actual));
        }
        #endregion

        #region Two equiped armor
        [Fact]
        public void TotalAttributes_EquipTwoArmor_ShouldReturnCalculatedTotalAttributes()
        {
            //Arrange
            Warrior peasant = new("Rene");
            HeroAttributes bodyArmorAttributes = new HeroAttributes(5, 1, 0);
            HeroAttributes headArmorAttributes = new HeroAttributes(5, 1, 0);
            Armor bodyArmor = new("Plate Chest", 1, ItemSlot.body, ArmorType.Plate, bodyArmorAttributes);
            Armor headArmor = new("Plate Helmet", 1, ItemSlot.head, ArmorType.Plate, headArmorAttributes);
            peasant.EquipArmor(bodyArmor);
            peasant.EquipArmor(headArmor);
            HeroAttributes expected = peasant.HeroAttributes + bodyArmorAttributes + headArmorAttributes; // = (17,5,2)
            // Act
            HeroAttributes actual = peasant.TotalAttributes();
            //Assert
            Assert.True(expected.Equals(actual));
        }
        #endregion

        #region Equip on same Slot twice
        [Fact]
        public void TotalAttributes_ReplaceOneArmor_ShouldReturn()
        {
            //Arrange
            Warrior peasant = new("Rene");
            HeroAttributes plateAttributes = new HeroAttributes(5, 1, 0);
            HeroAttributes mailAttributes = new HeroAttributes(2, 3, 2);
            Armor plateArmor = new("Plate Chest", 1, ItemSlot.body, ArmorType.Plate, plateAttributes);
            Armor mailArmor = new("Mail Chest", 1, ItemSlot.body, ArmorType.Mail, mailAttributes);
            peasant.EquipArmor(plateArmor);
            peasant.EquipArmor(mailArmor);
            HeroAttributes expected = peasant.HeroAttributes + mailAttributes; // = (7,5,3)
            // Act
            HeroAttributes actual = peasant.TotalAttributes();
            //Assert
            Assert.True(expected.Equals(actual));
        }
        #endregion
    }

}
