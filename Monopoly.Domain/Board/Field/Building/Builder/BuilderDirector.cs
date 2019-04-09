using System;
using System.Drawing;
using Domain.Board.Field.Building.Builder;

namespace Engine.Board.Field.Building.Builder
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