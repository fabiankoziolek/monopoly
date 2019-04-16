using System.Collections.Generic;
using Monopoly.Domain.Board.Field.Building;
using Monopoly.Domain.Players;

namespace Monopoly.Domain.Board.Field.Fields.Property
{
    public interface IProperty : IField
    {
        Color Color { get; }
        IList<IBuilding> Buildings { get; set; }
        IPlayer Owner { get; }
        void SetOwner(IPlayer player);
    }
}