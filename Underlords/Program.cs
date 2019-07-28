using Underlords.Model;
using Underlords.Models.ChessBoard;

namespace Underlords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new Player();
            var player2 = new Player();
//            var chessBoard = new ChessBoard(player1, player2);


//            chessBoard.ShoppingTime(1);
//
//
//            player1.BuyHero(1, chessBoard.Shop);
//            player1.BuyHero(2, chessBoard.Shop);
//            player1.BuyHero(1, chessBoard.Shop);
            player1.Bench.Add(new AntiMage(1));
            player1.Bench.Add(new Axe(1));
            player1.DisplayBench();
            player1.PickHeroFromBench(0, new Position(0, 1));
            player1.PickHeroFromBench(1, new Position(0, 2));
//            player1.SwitchHero(new Position(0, 1), new Position(0, 2));
//            player1.SwitchHero(new Position(0, 1), new Position(0, 3));

//            chessBoard.ShoppingTime(1);
//            player2.BuyHero(3, chessBoard.Shop);
//            player2.BuyHero(4, chessBoard.Shop);
            player2.Bench.Add(new Bloodseeker(1));
            player2.Bench.Add(new Razor(1));
            player2.DisplayBench();
            player2.PickHeroFromBench(0, new Position(3, 4));
            player2.PickHeroFromBench(1, new Position(2, 6));


            player1.PrintPlayerBoard();
            player2.PrintPlayerBoard();
            var chessBoard = new ChessBoard(player1, player2);
            chessBoard.Load();
            chessBoard.Play();
//            player2.BuyHero(new Bloodseeker(1));
//            player2.PickHeroFromBench(0, new Position(0, 1));
        }
    }
}