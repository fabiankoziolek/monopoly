using Monopoly.Domain.Players.Attributes;

namespace Monopoly.Engine.Operation
{
    public class OperationsService : IOperationsService
    {
        public void TransferMoney(int amount, ITransferable from, ITransferable to)
        {
            var money = from.WithdrawMoney(amount);
            to.DepositMoney(money);
        }
    }
}