using System.Collections.Generic;
using Underlords.Model;

namespace Underlords.Models.ChessBoard
{
    public interface IPlayer
    {
        void SwitchHero(Position fromPosition, Position toPosition);
        void DisplayBench();
        void PickHeroFromBench(int index, Position position);
        void BuyHero(int index, List<Hero> Shop);
        bool Lose();
        void Fight(Player enemy);
    }
}