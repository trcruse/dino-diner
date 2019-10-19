using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class WaterTest
    {

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveDefalutIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size, sweet
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }



        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }


        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// That invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.DoesNotContain<string>("Ice", water.Ingredients);
            Assert.False(water.Ice);
        }

        /// <summary>
        /// That invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains("Lemon", water.Ingredients);
            Assert.True(water.Lemon);
        }

        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void CorrectIngredientsAreGiven()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);

        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }


        [Fact]
        public void AddLemonShouldAddSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldingIceShouldAddSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonAndHoldIceToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            water.HoldIce();

            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddingLemonShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special",
                () =>
                {
                    water.AddLemon();
                });
        }

        [Fact]
        public void HoldingIceShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special",
                () =>
                {
                    water.HoldIce();
                });
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyPriceChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Price",
                () =>
                {
                    water.Size = Size.Small;
                });
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyCalorieChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Calories",
                () =>
                {
                    water.Size = Size.Small;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyPriceChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Price",
                () =>
                {
                    water.Size = Size.Medium;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyCalorieChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Calories",
                () =>
                {
                    water.Size = Size.Medium;
                });
        }

        [Fact]
        public void ChangingLargeSizeShouldNotifyPriceChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Price",
                () =>
                {
                    water.Size = Size.Large;
                });
        }
        [Fact]
        public void ChangingLargeSizeShouldNotifyCalorieChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Calories",
                () =>
                {
                    water.Size = Size.Large;
                });
        }

    }
}
