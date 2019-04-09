using System.Collections.Generic;
using Monopoly.Domain.Board.Field.Building;

namespace Monopoly.Domain.Board.Field.Fields.Property.Properties
{
    public class RegentStreet : IProperty
    {
        public string Name { get; }
        public Color Color { get; }
        public IList<IBuilding> Buildings { get; set; }

        public RegentStreet()
        {
            Name = "Regent Street";
            Color = Color.Yellow;
        }
    }
}