using Monopoly.Domain.Players;
using Monopoly.Engine.Operation;
using Xunit;

namespace Monopoly.Engine.Test.Operation
{
    public class OperationsServiceTest
    {
        private IOperationsService _operationsService;

        [Fact]
        void ShouldWithdraw100FromPlayerOneToPlayerTwo()
        {
            // Arrange
            
            _operationsService = new OperationsService();
            
            IPlayer playerOne = new Domain.Players.Player()
            {
                Money = 1500
            };
            
            IPlayer playerTwo = new Domain.Players.Player()
            {
                Money = 1500
            };

            var expectedPlayerOneMoneyAfterWithdrawal = 1400;
            
            // Act
            
            _operationsService.TransferMoney(100, playerOne, playerTwo);
            var result = playerOne.Money;
            
            // Assert
            
            Assert.Equal(expectedPlayerOneMoneyAfterWithdrawal, result);
        }

        [Fact]
        void ShouldTransferMoneyToPlayerTwo()
        {
            // Arrange
            
            _operationsService = new OperationsService();
            
            IPlayer playerOne = new Domain.Players.Player()
            {
                Money = 1500
            };
            
            IPlayer playerTwo = new Domain.Players.Player()
            {
                Money = 1500
            };

            var expectedPlayerTwoMoneyAfterTransfer = 1600;
            
            // Act
            
            _operationsService.TransferMoney(100, playerOne, playerTwo);
            var result = playerTwo.Money;
            
            // Assert
            
            Assert.Equal(expectedPlayerTwoMoneyAfterTransfer, result);            
        }

        [Fact]
        void ShouldTransferRemainingMoneyNotHavingEnoughMoney()
        {
            // Arrange
            
            _operationsService = new OperationsService();
            
            IPlayer playerOne = new Domain.Players.Player()
            {
                Money = 200
            };
            
            IPlayer playerTwo = new Domain.Players.Player()
            {
                Money = 1500
            };

            const int expectedPlayerOneMoneyAfterTransfer = 0;
            const int expectedPlayerTwoMoneyAfterTransfer = 1700;
            
            // Act
            
            _operationsService.TransferMoney(300, playerOne, playerTwo);
            var playerOneResult = playerOne.Money;
            var playerTwoResult = playerTwo.Money;
            
            // Assert
            
            Assert.Equal(expectedPlayerOneMoneyAfterTransfer, playerOneResult);                        
            Assert.Equal(expectedPlayerTwoMoneyAfterTransfer, playerTwoResult);                        
        }
    }
}