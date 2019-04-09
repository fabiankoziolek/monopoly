using System.Collections.Generic;
using Monopoly.Domain.Board.Field.Building;

namespace Monopoly.Domain.Board.Field.Fields.Property.Properties
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