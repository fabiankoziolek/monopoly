using System.Collections.Generic;
using Monopoly.Domain.Board.Field.Building;
using Monopoly.Domain.Players;

namespace Monopoly.Domain.Board.Field.Fields.Property
{
    public class Property : IProperty
    {
        public string Name { get; protected set; }
        public Color Color { get; protected set; }
        public IList<IBuilding> Buildings { get; set; }
        public IPlayer Owner { get; private set; }
        
        public void SetOwner(IPlayer player)
        {
            Owner = player;
        }
    }
}