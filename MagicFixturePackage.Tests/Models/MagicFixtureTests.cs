using Xunit;
using MagicFixturePackage.Core.Models;

namespace MagicFixturePackage.Tests.Models
{
    public class MagicFixtureTests
    {
        [Fact]
        public void ClassWithIntegerProperty_Called_ReturnObjectWithPropertyHavingIntegerValueGreaterThanZero() {
            // Arrange
            var magicFixture = new MagicFixture();
            
            // Act
            var fixture = magicFixture.Summon<IntegerValueModel>();

            // Assert
            Assert.NotNull(fixture);
            Assert.True(fixture.Value > 0);
        }

        [Fact]
        public void ClassWithDoubleProperty_Called_ReturnObjectWithPropertyHavingDoubleValueGreaterThanZero() {
            // Arrange
            var magicFixture = new MagicFixture();
            
            // Act
            var fixture = magicFixture.Summon<DoubleValueModel>();

            // Assert
            Assert.NotNull(fixture);
            Assert.True(fixture.Value > 0);
        }
    }
}