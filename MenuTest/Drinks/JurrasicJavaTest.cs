using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveDefalutIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// That invoking AddIce() results in the Ice property being true
        /// </summary>
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.DoesNotContain("Ice", java.Ingredients);
            Assert.True(java.Ice);
        }

        /// <summary>
        /// That invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void LeaveSpaceForCreamInvokesSpaceForCreamTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.DoesNotContain("Ice", java.Ingredients);
            Assert.False(java.Ice);
        }

    }
}
