using System.Collections.Generic;
using Monopoly.Domain.Board.Field;

namespace Monopoly.Domain.Board
{
    public interface IBoard
    {
        IList<IField> Fields { get; set; }
    }
}