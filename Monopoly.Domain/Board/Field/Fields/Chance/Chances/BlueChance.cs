using Monopoly.Domain.Board.Field.Fields.Property;

namespace Monopoly.Domain.Board.Field.Fields.Chance.Chances
{
    public class BlueChance : IChance
    {
        public string Name { get; }
        public Color Color { get; }

        public BlueChance()
        {
            Name = "Chance";
            Color = Color.Blue;
        }
    }
}