using Monopoly.Domain.Players;

namespace Monopoly.Engine.Player.Builder
{
    public class PlayerBuilder : IPlayerBuilder
    {
        private IPlayer _player;

        public IPlayerBuilder ResetBuilder()
        {
            _player = new Domain.Players.Player();
            return this;
        }

        public IPlayerBuilder SetName(string name)
        {
            _player.Name = name;
            return this;
        }

        public IPlayerBuilder SetMoney()
        {
            _player.Money = 1500;
            return this;
        }

        public IPlayer GetPlayer()
        {
            return _player;
        }
    }
}