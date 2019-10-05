using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

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
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// The correct default price, calories, ice, and size
        /// </summary>
        [Fact]
        public void ShouldHaveDefalutIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }


        /// <summary>
        /// The correct default price, calories, ice, and size
        /// small is the default for size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// That invoking AddIce() results in the Ice property being true
        /// </summary>
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
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
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.DoesNotContain("Ice", java.Ingredients);
            Assert.False(java.Ice);
        }

    }
}
