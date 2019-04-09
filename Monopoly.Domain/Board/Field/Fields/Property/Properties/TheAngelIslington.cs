using System.Collections.Generic;
using Engine.Board.Field.Building;

namespace Engine.Board.Field.Fields.Property.Properties
{
    public class TheAngelIslington : IProperty
    {
        public string Name { get; }
        public Color Color { get; }
        public IList<IBuilding> Buildings { get; set; }

        public TheAngelIslington()
        {
            Name = "The Angel Islington";
            Color = Color.Purple;
        }
    }
}