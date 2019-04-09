namespace Engine.Board.Field.Building
{
    public interface IBuildable
    {
        void SetType(Type type);
        void SetFine(int fine);
        void SetPrice(int price);
    }
}