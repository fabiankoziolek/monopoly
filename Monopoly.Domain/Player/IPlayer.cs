namespace Monopoly.Domain.Player
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Money { get; set; }
    }
}