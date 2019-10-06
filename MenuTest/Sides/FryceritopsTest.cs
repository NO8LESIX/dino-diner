using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Friceritops ft = new Friceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Friceritops ft = new Friceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Friceritops ft = new Friceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Friceritops ft = new Friceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Friceritops ft = new Friceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Friceritops ft = new Friceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Friceritops ft = new Friceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Friceritops ft = new Friceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Friceritops ft = new Friceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Friceritops ft = new Friceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }
    }
}
