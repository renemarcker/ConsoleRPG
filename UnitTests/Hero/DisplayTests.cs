using ConsoleRPG.Heroes;
using ConsoleRPG.Heroes.Classes;
using System.Text;
using System.Xml.Linq;

namespace UnitTests.Hero
{
    public class DisplayTests
    {
        #region Stringbuilder
        [Fact]
        public void Display_CreateHeroClass_ShouldReturnStringBuilderWithAllStats() 
        {
            //Arrange
            Warrior peasant = new("Rene");
            StringBuilder builder = new("The states of the Hero:\n\n");
            decimal damage = 1.05m;
            builder.Append("Name:         Rene\n");
            builder.Append("Class:        Warrior\n");
            builder.Append("Level:        1\n");
            builder.Append("Strength:     5\n");
            builder.Append("Dexterity:    2\n");
            builder.Append("Intelligence: 1\n");
            builder.AppendFormat("Damage:       {0}\n", damage);
            string expected = builder.ToString();   
            //Act
            string actual = peasant.Display();
            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
