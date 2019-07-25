using System;
using System.Collections.Generic;
using System.Text;
using Underlords.Model;

namespace Underlords.Models.ChessBoard
{
    public class ChessBoard : IChessBoard
    {
        private readonly Player attacker;
        private readonly Player defender;
        private readonly Chess[,] Gameboard;
        private readonly List<Hero> Level1Heros = new List<Hero>();
        public readonly List<Hero> Shop;
        private int roundLevel;

        public ChessBoard(Player defender, Player attacker)
        {
            this.defender = defender;
            this.attacker = attacker;
            Gameboard = new Chess[8, 8];
            roundLevel = 0;
            Shop = new List<Hero>();
            InitializeShop();
        }

        public void Load()
        {
            foreach (var chess in defender.Gameboard)
                if (chess != null)
                {
                    Gameboard[chess.Position.x, chess.Position.y] = chess;
                    Console.WriteLine(
                        $"Chess {chess.Name} has been set to Position [{chess.Position.x},{chess.Position.y}], which IsEnemy is {chess.IsEnemy}");
                }

            foreach (var chess in attacker.Gameboard)
                if (chess != null)
                {
                    chess.IsEnemy = true;
                    chess.Position = new Position(7 - chess.Position.x, 7 - chess.Position.y);
                    Gameboard[chess.Position.x, chess.Position.y] = chess;
                    Console.WriteLine(
                        $"Chess {chess.Name} has been set to Position [{chess.Position.x},{chess.Position.y}], which IsEnemy is {chess.IsEnemy}");
                }
        }

        public void ShoppingTime(int roundLevel)
        {
            var random = new Random();
            for (var i = 0; i < 6; i++)
            {
                var hero = Level1Heros[random.Next(0, 3)];
                Shop.Add(hero);
                Console.WriteLine($"Add No.{i} Hero {hero.Name} to Shop");
            }

            DisplayShop(Shop);
        }


        public void Play()
        {
            while (defender.Lose() || attacker.Lose())
            {
            }

            throw new NotImplementedException();
        }

        public void BattleSettlement()
        {
            throw new NotImplementedException();
        }

        private void DisplayShop(List<Hero> shop)
        {
            var DisplayShop = new StringBuilder();
            for (var i = 0; i < shop.Count; i++) DisplayShop.AppendLine($"Sort: {i}, {shop[i].Name}");

            Console.WriteLine(DisplayShop.ToString());
        }

        private void InitializeShop()
        {
            Level1Heros.Add(new Axe(1));
            Level1Heros.Add(new Bloodseeker(1));
            Level1Heros.Add(new AntiMage(1));
        }
    }

    public interface IChessBoard
    {
        void Load();
        void ShoppingTime(int roundLevel);
        void Play();
        void BattleSettlement();
    }
}