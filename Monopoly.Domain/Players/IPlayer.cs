using Monopoly.Domain.Players.Attributes;

namespace Monopoly.Domain.Players
{
    public interface IPlayer : ITransferable
    {
        string Name { get; set; }
        int Money { get; set; }
    }
}