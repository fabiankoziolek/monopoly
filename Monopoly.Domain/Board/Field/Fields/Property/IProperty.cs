using System.Collections.Generic;
using Monopoly.Domain.Board.Field.Building;

namespace Monopoly.Domain.Board.Field.Fields.Property
{
    public interface IProperty : IField
    {
        Color Color { get; }
        IList<IBuilding> Buildings { get; set; }
    }
}