namespace Monopoly.Domain.Board.Field.Fields.Railroad.Railroads
{
    public class KingsCrossStation : IRailroad
    {
        public string Name { get; }

        public KingsCrossStation()
        {
            Name = "King's Cross station";
        }
    }
}