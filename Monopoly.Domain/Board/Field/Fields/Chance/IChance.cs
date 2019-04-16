using Monopoly.Domain.Board.Field.Fields.Property;

namespace Monopoly.Domain.Board.Field.Fields.Chance
{
    public interface IChance : IField
    {
        Color Color { get; }
    }
}