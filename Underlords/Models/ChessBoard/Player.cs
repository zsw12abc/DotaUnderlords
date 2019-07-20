using System.Collections.Generic;

namespace Underlords.Models.ChessBoard
{
    public class Player
    {
        public int InitialLife { get; set; } = 100;
        public int CurrentLife { get; set; }
        public int Life { get; set; }
        public int CurrentExp { get; set; }
        public List<Underlords> UnderlordGroup { get; set; }
        public int Money { get; set; }
    }
}