using System.Collections.Generic;
using Underlords.Model.Races;

namespace Underlords.Models.ChessBoard
{
    public class Player
    {
        public int InitialLife { get; set; } = 100;
        public int CurrentLife { get; set; }
        public int Life { get; set; }
        public int CurrentExp { get; set; }
        public List<Underlord> UnderlordGroup { get; set; }
        public int Money { get; set; }
    }
}