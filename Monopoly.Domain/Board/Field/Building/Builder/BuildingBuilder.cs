namespace Monopoly.Domain.Board.Field.Building.Builder
{
    public class BuildingBuilder : IBuildingBuilder
    {
        private IBuildable _building;
        //TODO: move to engine
        public IBuildingBuilder Reset()
        {
            _building = new Building();
            return this;
        }

        public IBuildingBuilder SetType(Type type)
        {
            _building.SetType(type);
            return this;
        }

        public IBuildingBuilder SetFine(int fine)
        {
            _building.SetFine(fine);
            return this;
        }

        public IBuildingBuilder SetPrice(int price)
        {
            _building.SetPrice(price);
            return this;
        }

        public IBuildable GetBuilding()
        {
            return _building;
        }
    }
}