using Monopoly.Engine.Player.Builder;
using Xunit;

namespace Monopoly.Engine.Test.Player
{
    public class PlayerBuilderTest
    {
        private IPlayerBuilder _playerBuilder;

        [Fact]
        public void ShouldCreatePlayerNamedFoo()
        {
            // Arrange 
            
            _playerBuilder = new PlayerBuilder();
            const string expectedPlayerName = "Foo";
            
            // Act

            var result = _playerBuilder.ResetBuilder().SetName("Foo").GetPlayer().Name;
            
            // Assert
            
            Assert.Equal(expectedPlayerName, result);
        }

        [Fact]
        public void ShouldSetPlayerMoneyToFiveHundred()
        {
            // Arrange
            
            _playerBuilder = new PlayerBuilder();
            const int expectedPlayerMoney = 1500;
            
            // Act

            var result = _playerBuilder.ResetBuilder().SetMoney().GetPlayer().Money;

            // Assert
            
            Assert.Equal(expectedPlayerMoney, result);
        }
    }
}