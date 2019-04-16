namespace Monopoly.Domain.Board.Field.Fields.Other
{
    public class FreeParking : IField
    {
        public string Name { get; }

        public FreeParking()
        {
            Name = "Free Parking";
        }
    }
}