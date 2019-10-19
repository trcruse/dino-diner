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

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }


        [Fact]
        public void AddIceShouldAddSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                });
        }

        [Fact]
        public void AddIceAndLeaveRoomForCreamToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                },
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                });
        }


        [Fact]
        public void AddingIceShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special",
                () =>
                {
                    java.AddIce();
                });
        }

        [Fact]
        public void LeavingRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special",
                () =>
                {
                    java.LeaveRoomForCream();
                });
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price",
                () =>
                {
                    java.Size = Size.Small;
                });
        }

        [Fact]
        public void ChangingSmallSizeShouldNotifyCalorieChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories",
                () =>
                {
                    java.Size = Size.Small;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price",
                () =>
                {
                    java.Size = Size.Medium;
                });
        }
        [Fact]
        public void ChangingMediumSizeShouldNotifyCalorieChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories",
                () =>
                {
                    java.Size = Size.Medium;
                });
        }

        [Fact]
        public void ChangingLargeSizeShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price",
                () =>
                {
                    java.Size = Size.Large;
                });
        }
        [Fact]
        public void ChangingLargeSizeShouldNotifyCalorieChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories",
                () =>
                {
                    java.Size = Size.Large;
                });
        }
    }
}
