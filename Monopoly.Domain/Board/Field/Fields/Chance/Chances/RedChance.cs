using Monopoly.Domain.Board.Field.Fields.Property;

namespace Monopoly.Domain.Board.Field.Fields.Chance.Chances
{
    public class RedChance : IChance
    {
        public string Name { get; }
        public Color Color { get; }

        public RedChance()
        {
            Name = "Chance";
            Color = Color.Red;
        }

    }
}