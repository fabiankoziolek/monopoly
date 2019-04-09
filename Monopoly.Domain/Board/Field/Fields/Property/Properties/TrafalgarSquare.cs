using System.Collections.Generic;
using Engine.Board.Field.Building;

namespace Engine.Board.Field.Fields.Property.Properties
{
    public class TrafalgarSquare : IProperty
    {
        public string Name { get; }
        public Color Color { get; }
        public IList<IBuilding> Buildings { get; set; }

        public TrafalgarSquare()
        {
            Name = "Trafalgar Square";
            Color = Color.Purple;
        }
    }
}