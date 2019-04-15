using System;

namespace Monopoly.Domain.Players
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Money { get; set; }
        
        public int WithdrawMoney(int amount)
        {
            return Withdraw(amount);
        }

        private int Withdraw(int amount)
        {
            if (HasEnoughMoney(amount))
            {
                Money -= amount;
                return amount;
            }

            var remainingMoney = Money;
            Money = 0;
            return remainingMoney;
        }

        private bool HasEnoughMoney(int amount)
        {
            return Money - amount > 0;
        }

        public void DepositMoney(int amount)
        {
            Money += amount;
        }
    }
}