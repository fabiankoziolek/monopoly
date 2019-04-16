namespace Monopoly.Domain.Board.Field.Fields.Other
{
    public class Jail : IField
    {
        public string Name { get; }

        public Jail()
        {
            Name = "Jail";
        }
    }
}