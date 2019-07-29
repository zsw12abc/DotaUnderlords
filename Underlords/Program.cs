using System;
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

            var chessBoard = new ChessBoard(player1, player2);

            var Axe = CreateHeroByName("Axe");
            var Antimage = CreateHeroByName("Antimage");
            chessBoard.ChessBattle(Axe, Antimage);
            Console.WriteLine($"Axe: {Axe.CurrentHP}");
            Console.WriteLine($"Antimage: {Antimage.CurrentHP}");

            player1.Bench.Add(CreateHeroByName("AntiMage"));
            player1.Bench.Add(CreateHeroByName("Axe"));
            player1.DisplayBench();
            player1.PickHeroFromBench(0, new Position(0, 1));
            player1.PickHeroFromBench(1, new Position(0, 2));
            player2.Bench.Add(CreateHeroByName("Bloodseeker"));
            player2.Bench.Add(CreateHeroByName("Razor"));
            player2.DisplayBench();
            player2.PickHeroFromBench(0, new Position(3, 4));
            player2.PickHeroFromBench(1, new Position(2, 6));


            player1.PrintPlayerBoard();
            player2.PrintPlayerBoard();
//            var chessBoard = new ChessBoard(player1, player2);

//            chessBoard.Load();
//            chessBoard.Play();
        }

        private static Hero CreateHeroByName(string heroName, int level = 1)
        {
            switch (heroName.ToUpper())
            {
                case "AXE":
                    return new Axe(level);
                case "ANTIMAGE":
                    return new AntiMage(level);
                case "BLOODSEEKER":
                    return new Bloodseeker(level);
                case "RAZOR":
                    return new Razor(level);
                default:
                    return null;
            }
        }
    }
}