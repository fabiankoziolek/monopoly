namespace Monopoly.Domain.Board.Field.Building
{
    public class Building : IBuilding
    {
        public Type Type { get; private set; }
        public int Price { get; private set; }
        public int Fine { get; private set; }
        
        public void SetType(Type type)
        {
            Type = type;
        }

        public void SetFine(int fine)
        {
            Fine = fine;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }
    }
}