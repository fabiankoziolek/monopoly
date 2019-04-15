using Monopoly.Domain.Players;

namespace Monopoly.Engine.Player.Builder
{
    public interface IPlayerBuilder
    {
        IPlayerBuilder ResetBuilder();
        IPlayerBuilder SetName(string name);
        IPlayerBuilder SetMoney();
        IPlayer GetPlayer();

    }
}