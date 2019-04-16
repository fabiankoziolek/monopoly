namespace Monopoly.Domain.Board.Field.Fields.Railroad.Railroads
{
    public class LiverpoolStStation : IRailroad
    {
        public string Name { get; }

        public LiverpoolStStation()
        {
            Name = "Liverpool St. Station";
        }
    }
}