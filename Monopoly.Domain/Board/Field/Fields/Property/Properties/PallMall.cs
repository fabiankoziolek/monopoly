using System.Collections.Generic;
using Engine.Board.Field.Building;

namespace Engine.Board.Field.Fields.Property.Properties
{
    public class PallMall : IProperty
    {
        public string Name { get; set; }
        public Color Color { get; }
        public IList<IBuilding> Buildings { get; set; }
        
        public PallMall()
        {
            Name = "Pall Mall";
            Color = Color.Red;
        }
    }
}