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
            foreach (var chess in defender.PlayerBoard)
                if (chess != null)
                {
                    chess.Position.x += 4;
                    Gameboard[chess.Position.x, chess.Position.y] = chess;
                    chess.IsEnemy = false;
                    Console.WriteLine(
                        $"Chess {chess.Name} has been set to Position [{chess.Position.x},{chess.Position.y}], which IsEnemy is {chess.IsEnemy}");
                }

            foreach (var chess in attacker.PlayerBoard)
                if (chess != null)
                {
                    chess.Position.x = 3 - chess.Position.x;
                    chess.Position.y = 7 - chess.Position.y;
                    chess.IsEnemy = true;
                    Gameboard[chess.Position.x, chess.Position.y] = chess;
                    Console.WriteLine(
                        $"Chess {chess.Name} has been set to Position [{chess.Position.x},{chess.Position.y}], which IsEnemy is {chess.IsEnemy}");
                }

            DisplayGameBoard();
        }

        public void ShoppingTime(int roundLevel)
        {
            Shop.Clear();
            var random = new Random();
            for (var i = 0; i < 5; i++)
            {
                var hero = Level1Heros[random.Next(0, 3)];
                Shop.Add(hero);
                Console.WriteLine($"Add No.{i} Hero {hero.Name} to Shop");
            }

            DisplayShop(Shop);
        }


        public void Play()
        {
            while (!defender.Lose() || !attacker.Lose()) FindEnemy(defender, attacker);
        }


        public void BattleSettlement()
        {
            throw new NotImplementedException();
        }

        private void DisplayGameBoard()
        {
            var len = 0;
            var gameBoard = new StringBuilder();
            foreach (var chess in Gameboard)
            {
                len++;
                if (chess == null)
                {
                    gameBoard.Append("O");
                }
                else
                {
                    if (chess.IsEnemy)
                        gameBoard.Append("*");
                    else
                        gameBoard.Append("x");
                }

                if (len == 8)
                {
                    len = 0;
                    gameBoard.AppendLine();
                }
            }

            Console.WriteLine(gameBoard.ToString());
        }

        private void FindEnemy(Player defender, Player attacker)
        {
            foreach (var chess in Gameboard)
                if (chess != null)
                {
                    if (!chess.IsEnemy)
                    {
                        var minDistance = 10;
                        foreach (var attackerChess in attacker.PlayerBoard)
                            if (attackerChess != null)
                            {
                                var distance = GetDistance(chess.Position, attackerChess.Position);
                                if (minDistance > distance)
                                {
                                    minDistance = distance;
                                    chess.Target = attackerChess;
                                    Console.WriteLine(
                                        $"Defender {chess.Name} located at ({chess.Position.x}, {chess.Position.y}) found enemy, which is {attackerChess.Name} located at ({attackerChess.Position.x},{attackerChess.Position.y})");
                                }
                            }
                    }
                    else
                    {
                        var minDistance = 10;
                        foreach (var defenderChess in defender.PlayerBoard)
                            if (defenderChess != null)
                            {
                                var distance = GetDistance(chess.Position, defenderChess.Position);
                                if (minDistance > distance)
                                {
                                    minDistance = distance;
                                    chess.Target = defenderChess;
                                    Console.WriteLine(
                                        $"Attacker {chess.Name} located at ({chess.Position.x}, {chess.Position.y}) found enemy, which is {defenderChess.Name} located at ({defenderChess.Position.x},{defenderChess.Position.y})");
                                }
                            }
                    }
                }
        }

        private void DisplayShop(List<Hero> shop)
        {
            var DisplayShop = new StringBuilder();
            for (var i = 0; i < shop.Count; i++) DisplayShop.AppendLine($"Shop Slot: {i}, {shop[i].Name}");

            Console.WriteLine(DisplayShop.ToString());
        }

        private void InitializeShop()
        {
            Level1Heros.Add(new Axe(1));
            Level1Heros.Add(new Bloodseeker(1));
            Level1Heros.Add(new AntiMage(1));
        }

        private int GetDistance(Position position1, Position position2)
        {
            var xDistance = Math.Abs(position2.x - position1.x);
            var yDistance = Math.Abs(position2.y - position2.y);
            return xDistance > yDistance ? xDistance : yDistance;
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