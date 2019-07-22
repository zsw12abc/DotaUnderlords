using Underlords.Model;
using Underlords.Models.ChessBoard;

namespace Underlords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new Player();
            player1.BuyHero(new AntiMage(1));
            player1.BuyHero(new Bloodseeker(1));
            player1.MoveHero(new AntiMage(1), new Position(1, 1));
        }
    }
}