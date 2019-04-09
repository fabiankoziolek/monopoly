using System.Collections.Generic;
using Engine.Board.Field.Building;

namespace Engine.Board.Field.Fields.Property.Properties
{
    public class CoventryStreet : IProperty
    {
        public string Name { get; }
        public Color Color { get; }
        public IList<IBuilding> Buildings { get; set; }

        public CoventryStreet()
        {
            Name = "Coventry Street";
            Color = Color.Brown;
        }
    }
}