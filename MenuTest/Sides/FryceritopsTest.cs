using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionShouldGiveNameForSize(Size size)
        {
            Fryceritops fry = new Fryceritops();
            fry.Size = size;
            Assert.Equal($"{size} Fryceritops", fry.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Fryceritops fry = new Fryceritops();
            Assert.Empty(fry.Special);
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyPriceChange()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Price",
                () =>
                {
                    fry.Size = Size.Small;
                });
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyCalorieChange()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Calories",
                () =>
                {
                    fry.Size = Size.Small;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyPriceChange()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Price",
                () =>
                {
                    fry.Size = Size.Medium;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyCalorieChange()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Calories",
                () =>
                {
                    fry.Size = Size.Medium;
                });
        }

        [Fact]
        public void ChangingLargeSizeShouldNotifyPriceChange()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Price",
                () =>
                {
                    fry.Size = Size.Large;
                });
        }
        [Fact]
        public void ChangingLargeSizeShouldNotifyCalorieChange()
        {
            Fryceritops fry = new Fryceritops();
            Assert.PropertyChanged(fry, "Calories",
                () =>
                {
                    fry.Size = Size.Large;
                });
        }


    }
}
