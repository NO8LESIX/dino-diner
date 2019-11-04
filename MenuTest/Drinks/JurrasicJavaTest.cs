using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(.59, java.Price);
            Assert.True(java.Calories == 2);
            Assert.True(java.Ice == true);
            Assert.True(java.decaf == false);
            Assert.True(java.roomForCream == false);

        }
        [Fact]
        public void ShouldHaveCorrectValuesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price);
            Assert.True(java.Calories == 4);
            Assert.True(java.Ice == false);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price);
            Assert.True(java.Calories == 8);
            Assert.True(java.Ice == false);
        }
        [Fact]
        public void AddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice == true);
        }
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
        [Fact]
        public void IsDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.MakeDecaf();
            Assert.True(java.decaf == true);
        }
        [Fact]
        public void HasRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.roomForCream == true);
        }
    }
}
