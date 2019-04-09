using System.Collections.Generic;
using Engine.Board.Field.Building;

namespace Engine.Board.Field.Fields.Property
{
    public interface IProperty : IField
    {
        Color Color { get; }
        IList<IBuilding> Buildings { get; set; }
    }
}