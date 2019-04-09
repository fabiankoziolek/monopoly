namespace Monopoly.Domain.Board.Field.Building
{
    public interface IBuilding : IBuildable
    {
        Type Type { get; }
        int Price { get; }
        int Fine { get; }
    }
}