namespace Monopoly.Domain.Players.Attributes
{
    public interface ITransferable
    {
        int WithdrawMoney(int amount);
        void DepositMoney(int amount);
    }
}