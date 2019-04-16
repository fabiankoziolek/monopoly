namespace Monopoly.Domain.Board.Field.Fields.Other
{
    public class CommunityChest : IField
    {
        public string Name { get; }

        public CommunityChest()
        {
            Name = "Community Chest";
        }
    }
}