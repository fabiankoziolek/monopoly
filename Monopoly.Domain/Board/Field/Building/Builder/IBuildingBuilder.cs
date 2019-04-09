namespace Engine.Board.Field.Building.Builder
{
    public interface IBuildingBuilder
    {
        IBuildingBuilder Reset();
        IBuildingBuilder SetType(Type type);
        IBuildingBuilder SetFine(int fine);
        IBuildingBuilder SetPrice(int price);
        IBuildable GetBuilding();
    }
}