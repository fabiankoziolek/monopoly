namespace Monopoly.Domain.Board.Field.Fields.Railroad.Railroads
{
    public class FenchurchStreetStation : IRailroad
    {
        public string Name { get; }

        public FenchurchStreetStation()
        {
            Name = "Fenchurch Street station";
        }
    }
}