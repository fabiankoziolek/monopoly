using System;
using System.Drawing;

namespace Monopoly.Domain.Board.Field.Building.Builder
{
    public class BuilderDirector
    {
        private IBuildingBuilder _builder;

        public BuilderDirector()
        {
            _builder = new BuildingBuilder();
        }

        public IBuilding BuildHouse(Color propertyColor)
        {
            return (IBuilding) _builder.Reset()
                .SetFine(150)
                .SetType(Type.House)
                .SetPrice(100)
                .GetBuilding();
        }

        public IBuilding BuildHotel(Color propertyColor)
        {
            throw new NotImplementedException();
        }
    }
}