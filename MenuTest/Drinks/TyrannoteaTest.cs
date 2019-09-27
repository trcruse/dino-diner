using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Menu;


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





    }
}
