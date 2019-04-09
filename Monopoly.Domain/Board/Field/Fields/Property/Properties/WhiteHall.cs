using System.Collections.Generic;
using Engine.Board.Field.Building;

namespace Engine.Board.Field.Fields.Property.Properties
{
    public class WhiteHall : IProperty
    {
        public string Name { get; set; }
        public Color Color { get; }
        public IList<IBuilding> Buildings { get; set; }

        public WhiteHall()
        {
            Name = "White Hall";
            Color = Color.Red;
        }
    }
}