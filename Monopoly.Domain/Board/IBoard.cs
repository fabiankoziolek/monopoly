using System.Collections.Generic;
using Engine.Board.Field;

namespace Engine.Board
{
    public interface IBoard
    {
        IList<IField> Fields { get; set; }
    }
}