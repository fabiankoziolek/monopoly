using Monopoly.Domain.Players;
using Monopoly.Domain.Players.Attributes;

namespace Monopoly.Engine.Operation
{
    public interface IOperationsService
    {
        void TransferMoney(int amount, ITransferable from, ITransferable to);
    }
}