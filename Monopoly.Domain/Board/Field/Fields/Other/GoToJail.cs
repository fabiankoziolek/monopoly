namespace Monopoly.Domain.Board.Field.Fields.Other
{
    public class GoToJail : IField
    {
        public string Name { get; }

        public GoToJail()
        {
            Name = "Go To Jail";
        }
    }
}