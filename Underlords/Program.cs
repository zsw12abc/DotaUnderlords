using Underlords.Models.ChessBoard;

namespace Underlords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new Player();
            var player2 = new Player();
            var chessBoard = new ChessBoard(player1, player2);
            chessBoard.Load();
            chessBoard.ShoppingTime(1);


            player1.BuyHero(1, chessBoard.Shop);
            player1.BuyHero(2, chessBoard.Shop);
            player1.BuyHero(1, chessBoard.Shop);

//            player1.PickHeroFromBench(0, new Position(0, 1));
//            player1.PickHeroFromBench(1, new Position(0, 2));
//            player1.SwitchHero(new Position(0, 1), new Position(0, 2));
//            player1.SwitchHero(new Position(0, 1), new Position(0, 3));
//            player2.BuyHero(new Bloodseeker(1));
//            player2.PickHeroFromBench(0, new Position(0, 1));
        }
    }
}