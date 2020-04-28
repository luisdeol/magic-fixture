using Xunit;
using MagicFixturePackage.Core.Models;

namespace MagicFixturePackage.Tests.Models
{
    public class MagicFixtureTests
    {
        [Fact]
        public void ClassWithIntegerValue_Called_ReturnIntegerValueGreaterThanZero() {
            // Arrange
            var magicFixture = new MagicFixture();

            // Act
            var fixture = magicFixture.Summon<VarietyTypesEntity>();

            // Assert
            Assert.NotNull(fixture);
            Assert.True(fixture.IntValue > 0);
            Assert.True(fixture.DoubleValue > 0);
            Assert.True(!string.IsNullOrWhiteSpace(fixture.StringValue));
        }
    }
}