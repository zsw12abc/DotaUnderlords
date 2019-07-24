using Underlords.Model;

namespace Underlords.Models.ChessBoard
{
    public interface IPlayer
    {
        void SwitchHero(Position fromPosition, Position toPosition);
        void PickHeroFromBench(int index, Position position);
        void BuyHero(Hero hero);
        bool Lose();
        void Fight(Player enemy);
    }
}