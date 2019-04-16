namespace Monopoly.Domain.Board.Field.Fields.Railroad.Railroads
{
    public class MaryleboneStation : IRailroad
    {
        public string Name { get; }

        public MaryleboneStation()
        {
            Name = "Marylebone station";
        }
    }
}