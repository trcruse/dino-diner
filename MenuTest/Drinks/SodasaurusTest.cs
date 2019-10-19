using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;



namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }


        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }



        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveDefalutIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        
        /// <summary>
        /// The correct default price, calories, ice, and size
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }



        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
        }


        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
            Assert.Equal<uint>(156, soda.Calories);
        }

        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
            Assert.Equal<uint>(208, soda.Calories);
        }


        /// <summary>
        /// That invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.DoesNotContain<string>("Ice", soda.Ingredients);
        }


        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void CorrectIngredientsAreGiven()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]

        public void SodaSaurusDescriptionShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }


        [Fact]
        public void HoldIceShouldAddSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

       

        [Fact]
        public void HoldingIceShouldNotifySpecialChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special",
                () =>
                {
                    soda.HoldIce();
                });
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyPriceChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price",
                () =>
                {
                    soda.Size = Size.Small;
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
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price",
                () =>
                {
                    soda.Size = Size.Medium;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyCalorieChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories",
                () =>
                {
                    soda.Size = Size.Medium;
                });
        }

        [Fact]
        public void ChangingLargeSizeShouldNotifyPriceChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price",
                () =>
                {
                    soda.Size = Size.Large;
                });
        }
        [Fact]
        public void ChangingLargeSizeShouldNotifyCalorieChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories",
                () =>
                {
                    soda.Size = Size.Large;
                });
        }


    }
}
