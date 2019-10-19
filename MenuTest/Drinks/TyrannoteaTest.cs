using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;



namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveDefalutIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size, sweet
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size, sweet
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            Assert.True(tea.Sweet);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size, sweet
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }


        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// That invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.DoesNotContain<string>("Ice", tea.Ingredients);
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// That invoking AddLemon() sets results in the Lemon property being true.
        /// </summary>
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains("Lemon", tea.Ingredients);
            Assert.True(tea.Lemon);
        }


        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void TrueSweetPropertyToRightCaloriesForSizeSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }

        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void TrueSweetPropertyToRightCaloriesForSizeMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void TrueSweetPropertyToRightCaloriesForSizeLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }



        /// <summary>
        /// That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        /// </summary>
        [Fact]
        public void FalseSweetPropertyToRightCaloriesForSizeSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.RemoveSweet();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        /// </summary>
        [Fact]
        public void FalseSweetPropertyToRightCaloriesForSizeMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.RemoveSweet();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        /// </summary>
        [Fact]
        public void FalseSweetPropertyToRightCaloriesForSizeLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.RemoveSweet();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }


        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void CorrectIngredientsAreGiven()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Water", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]

        public void TyrannoTeaDescriptionShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }


        [Fact]
        public void AddLemonShouldAddSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldingIceShouldAddSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonAndHoldIceToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.HoldIce();
            
            Assert.Collection<string>(tea.Special,
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
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special",
                () =>
                {
                    tea.AddLemon();
                });
        }

        [Fact]
        public void HoldingIceShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special",
                () =>
                {
                    tea.HoldIce();
                });
        }


    }
}
